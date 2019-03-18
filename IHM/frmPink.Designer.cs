namespace IHM
{
    partial class frmPink
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxReception = new System.Windows.Forms.GroupBox();
            this.txtReception = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxConnection = new System.Windows.Forms.GroupBox();
            this.lblCryptage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCnx = new System.Windows.Forms.Button();
            this.gbxUsers = new System.Windows.Forms.GroupBox();
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.gbxChat = new System.Windows.Forms.GroupBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btChat = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxReception.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbxConnection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxUsers.SuspendLayout();
            this.gbxChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbxReception, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbxUsers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbxChat, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 650);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gbxReception
            // 
            this.gbxReception.Controls.Add(this.txtReception);
            this.gbxReception.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxReception.Enabled = false;
            this.gbxReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReception.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxReception.Location = new System.Drawing.Point(3, 452);
            this.gbxReception.Name = "gbxReception";
            this.gbxReception.Size = new System.Drawing.Size(827, 195);
            this.gbxReception.TabIndex = 10;
            this.gbxReception.TabStop = false;
            this.gbxReception.Text = "Réception des messages";
            // 
            // txtReception
            // 
            this.txtReception.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReception.Location = new System.Drawing.Point(6, 25);
            this.txtReception.Multiline = true;
            this.txtReception.Name = "txtReception";
            this.txtReception.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReception.Size = new System.Drawing.Size(815, 155);
            this.txtReception.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.86266F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.13734F));
            this.tableLayoutPanel2.Controls.Add(this.gbxConnection, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(827, 148);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gbxConnection
            // 
            this.gbxConnection.BackColor = System.Drawing.Color.Transparent;
            this.gbxConnection.Controls.Add(this.lblCryptage);
            this.gbxConnection.Controls.Add(this.label4);
            this.gbxConnection.Controls.Add(this.cbxLanguage);
            this.gbxConnection.Controls.Add(this.label3);
            this.gbxConnection.Controls.Add(this.txtPseudo);
            this.gbxConnection.Controls.Add(this.label2);
            this.gbxConnection.Controls.Add(this.txtAdresse);
            this.gbxConnection.Controls.Add(this.label1);
            this.gbxConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConnection.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxConnection.Location = new System.Drawing.Point(3, 3);
            this.gbxConnection.Name = "gbxConnection";
            this.gbxConnection.Size = new System.Drawing.Size(646, 142);
            this.gbxConnection.TabIndex = 11;
            this.gbxConnection.TabStop = false;
            this.gbxConnection.Text = "Connexion";
            // 
            // lblCryptage
            // 
            this.lblCryptage.AutoEllipsis = true;
            this.lblCryptage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCryptage.Location = new System.Drawing.Point(375, 100);
            this.lblCryptage.Name = "lblCryptage";
            this.lblCryptage.Size = new System.Drawing.Size(350, 20);
            this.lblCryptage.TabIndex = 18;
            this.lblCryptage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Clé cryptage :";
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "en",
            "fr",
            "ru",
            "de",
            "zh",
            "es"});
            this.cbxLanguage.Location = new System.Drawing.Point(184, 95);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(85, 28);
            this.cbxLanguage.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Langue :";
            // 
            // txtPseudo
            // 
            this.txtPseudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPseudo.Location = new System.Drawing.Point(184, 62);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(456, 26);
            this.txtPseudo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pseudo :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresse.Location = new System.Drawing.Point(184, 30);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(456, 26);
            this.txtAdresse.TabIndex = 11;
            this.txtAdresse.Text = "http://";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adresse Hub SignalR :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCnx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(655, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 142);
            this.panel1.TabIndex = 12;
            // 
            // btCnx
            // 
            this.btCnx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCnx.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btCnx.Location = new System.Drawing.Point(33, 62);
            this.btCnx.Name = "btCnx";
            this.btCnx.Size = new System.Drawing.Size(133, 26);
            this.btCnx.TabIndex = 14;
            this.btCnx.Text = "Connecter";
            this.btCnx.UseVisualStyleBackColor = true;
            this.btCnx.Click += new System.EventHandler(this.btCnx_Click);
            // 
            // gbxUsers
            // 
            this.gbxUsers.Controls.Add(this.lbxUsers);
            this.gbxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUsers.Enabled = false;
            this.gbxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUsers.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxUsers.Location = new System.Drawing.Point(3, 202);
            this.gbxUsers.Name = "gbxUsers";
            this.gbxUsers.Size = new System.Drawing.Size(827, 160);
            this.gbxUsers.TabIndex = 8;
            this.gbxUsers.TabStop = false;
            this.gbxUsers.Text = "Utilisateurs";
            // 
            // lbxUsers
            // 
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.ItemHeight = 20;
            this.lbxUsers.Location = new System.Drawing.Point(6, 25);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(532, 124);
            this.lbxUsers.TabIndex = 0;
            this.lbxUsers.SelectedIndexChanged += new System.EventHandler(this.lbxUsers_SelectedIndexChanged);
            // 
            // gbxChat
            // 
            this.gbxChat.Controls.Add(this.btSend);
            this.gbxChat.Controls.Add(this.btChat);
            this.gbxChat.Controls.Add(this.txtChat);
            this.gbxChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxChat.Enabled = false;
            this.gbxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChat.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxChat.Location = new System.Drawing.Point(3, 368);
            this.gbxChat.Name = "gbxChat";
            this.gbxChat.Size = new System.Drawing.Size(827, 78);
            this.gbxChat.TabIndex = 9;
            this.gbxChat.TabStop = false;
            this.gbxChat.Text = "Chat";
            // 
            // btSend
            // 
            this.btSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSend.Enabled = false;
            this.btSend.Location = new System.Drawing.Point(709, 48);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(113, 26);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btChat
            // 
            this.btChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChat.Location = new System.Drawing.Point(709, 16);
            this.btChat.Name = "btChat";
            this.btChat.Size = new System.Drawing.Size(113, 26);
            this.btChat.TabIndex = 1;
            this.btChat.Text = "Broadcast";
            this.btChat.UseVisualStyleBackColor = true;
            this.btChat.Click += new System.EventHandler(this.btChat_Click);
            // 
            // txtChat
            // 
            this.txtChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChat.Location = new System.Drawing.Point(6, 37);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(689, 26);
            this.txtChat.TabIndex = 0;
            // 
            // frmPink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frmPink";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Chat\'Room";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPink_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxReception.ResumeLayout(false);
            this.gbxReception.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbxConnection.ResumeLayout(false);
            this.gbxConnection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbxUsers.ResumeLayout(false);
            this.gbxChat.ResumeLayout(false);
            this.gbxChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbxConnection;
        private System.Windows.Forms.Label lblCryptage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCnx;
        private System.Windows.Forms.GroupBox gbxUsers;
        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.GroupBox gbxReception;
        private System.Windows.Forms.TextBox txtReception;
        private System.Windows.Forms.GroupBox gbxChat;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btChat;
        private System.Windows.Forms.TextBox txtChat;
    }
}