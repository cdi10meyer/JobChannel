
using Cryptography;
using IHM.Properties;
using MetroFramework.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class frmPink : MetroForm
    {
        private HubConnection _connection;
        TaskScheduler _scheduler;
        AsymmetricEncryptionRSA _RSA;
        SymmetricEncryptionAES _AES;

        public frmPink()
        {
            InitializeComponent();
            _scheduler = TaskScheduler.FromCurrentSynchronizationContext();
            txtAdresse.Text = Settings.Default.AdresseHubWebService;
            txtPseudo.Text = UserPrincipal.Current.Name;
            cbxLanguage.Text = "fr";
        }

        private void lbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btSend.Enabled = lbxUsers.SelectedIndex != -1;
        }

        private async void btCnx_Click(object sender, EventArgs e)
        {
            gbxConnection.Enabled = false;
            btCnx.Enabled = false;

            if (btCnx.Text == "Connecter")
            {
                try
                {
                    var ks = AsymmetricEncryptionRSA.GenerateKeys();
                   _RSA = new AsymmetricEncryptionRSA(ks.privateKey, ks.publicKey);

                    HubConnectionBuilder builder = new HubConnectionBuilder();
                    builder.WithUrl($"{txtAdresse.Text}/chat?pseudo={txtPseudo.Text}&language={cbxLanguage.Text}&publicKey={ks.publicKey.EncodeURL()}");
                    _connection = builder.Build();
                    _connection.On<string, string>("BroadcastMessage", Hub_BroadcastMessage);
                    _connection.On<string, string>("SendMessage", Hub_SendMessage);
                    _connection.On<IList<string>>("UsersList", Hub_UsersList);
                    _connection.On<string>("EncryptionKey", Hub_EncryptionKey);

                    _connection.Closed += (error) =>
                    {
                        Task.Factory.StartNew(() =>
                        {
                            gbxConnection.Enabled = true;
                            btCnx.Text = "Connecter";
                            btCnx.Enabled = true;
                            gbxChat.Enabled = false;
                            gbxUsers.Enabled = false;
                            lbxUsers.Items.Clear();
                            gbxReception.Enabled = false;
                            lblCryptage.Text = null;
                            _RSA = null;
                            _AES = null;
                        }, CancellationToken.None, TaskCreationOptions.None, _scheduler);
                        return Task.CompletedTask;
                    };

                    await _connection.StartAsync();

                    btCnx.Text = "Déconnecter";
                    gbxChat.Enabled = true;
                    btSend.Enabled = false;
                    gbxUsers.Enabled = true;
                    gbxReception.Enabled = true;
                    Settings.Default.AdresseHubWebService = txtAdresse.Text;
                    Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    gbxConnection.Enabled = true;
                }
                finally
                {
                    btCnx.Enabled = true;
                }
            }
            else
            {
                try
                {
                    await _connection.StopAsync();;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void btChat_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AES != null)
                    await _connection.InvokeAsync("Broadcast", _AES.EncryptStringURL(txtChat.Text));
                else
                    await _connection.InvokeAsync("Broadcast", txtChat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AES != null)
                    await _connection.InvokeAsync("Send", lbxUsers.SelectedItem, _AES.EncryptStringURL(txtChat.Text));
                else
                    await _connection.InvokeAsync("Send", lbxUsers.SelectedItem, txtChat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Hub_BroadcastMessage(string name, string message)
        {
            Task.Factory.StartNew(() =>
            {
                if (_AES != null)
                    message = _AES.DecryptStringURL(message);
                txtReception.AppendText($"Public  > {name} : {message}\r\n ");
            }, CancellationToken.None, TaskCreationOptions.None, _scheduler);
        }

        private void Hub_SendMessage(string name, string message)
        {
            Task.Factory.StartNew(() =>
            {
                if (_AES != null)
                    message = _AES.DecryptStringURL(message);
                txtReception.AppendText($"Private > {name} : {message}\r\n");
            }, CancellationToken.None, TaskCreationOptions.None, _scheduler);
        }

        private void Hub_UsersList(IList<string> users)
        {
            Task.Factory.StartNew(() =>
            {
                lbxUsers.Items.Clear();
                lbxUsers.Items.AddRange(users.ToArray());
            }, CancellationToken.None, TaskCreationOptions.None, _scheduler);
        }

        private void Hub_EncryptionKey(string symmetricKey)
        {
            Task.Factory.StartNew(() =>
            {
                if (!String.IsNullOrEmpty(symmetricKey))
                {
                    string keyAES = _RSA.DecryptStringURL(symmetricKey);
                    _AES = new SymmetricEncryptionAES(keyAES);
                    lblCryptage.Text = keyAES;
                }
                else
                {
                    _AES = null;
                    lblCryptage.Text = null;
                }
            }, CancellationToken.None, TaskCreationOptions.None, _scheduler);
        }

        private async void frmPink_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                await _connection.StopAsync(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
