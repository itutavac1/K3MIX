using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3MIX
{
    /// <summary>
    /// This class should contain all function that will be called from Event functions
    /// </summary>
    public class CLogic
    {
        public CLogic()
        {

        }

        ~CLogic()
        {

        }

        public bool Init()
        {
            return true;
        }

        public void SignUp()
        {
            Globals.Form.FinishDialog();
            Globals.ChangeForm(State.Menu,ref Globals.Form);
            Globals.Form.SetLogic(Globals.Logic);
            //Globals.Form.ContinueDialog();
            Globals.Form.DisplayForm();
        }
    }
}
