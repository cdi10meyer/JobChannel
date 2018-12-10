using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Preference
    {
        private static Selection MySelection;

        private Preference(Selection selection)
        {
            MySelection = selection;
        }

        public static Preference GetInstance(Selection selection)
        {
            if(MySelection is null)
            {
                return CreateInstance(selection);
            }
            return new Preference(MySelection);

        }
        private static Preference CreateInstance(Selection selection)
        {

            return new Preference(selection);
        }

    }
}
