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
        CData Data;
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
            CGlobals.Form.FinishDialog();
            CGlobals.ChangeForm(State.Menu,ref CGlobals.Form);
            CGlobals.Form.SetLogic(CGlobals.Logic);
            //Globals.Form.ContinueDialog();
            CGlobals.Form.DisplayForm();
        }
    }
}
