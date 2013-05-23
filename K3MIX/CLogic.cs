using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3MIX
{
    /*
        koristiti interface ILogic, i onda ga alocirati za odgovarajuću klasu, ili abstract class koji ima odgovarajuće metode 
     */
    public class CLogic
    {
        CData Data;

        public CLogic()
        {
            Data = new CData();
        }

        ~CLogic()
        {

        }

        public bool Init()
        {
            if (!Data.Init())
                return false;
            return true;
        }

        public void SignUp()
        {
            CGlobals.Form.FinishDialog();
            CGlobals.ChangeForm(State.Menu,ref CGlobals.Form);
            CGlobals.Form.SetLogic(CGlobals.Logic); // ha, provjeriti dal treba pomoću ref slati, dakle negdje u CApp mjenjati vrijednost i viditi unutar nove forme
            //Globals.Form.ContinueDialog();
            CGlobals.Form.DisplayForm();
        }
    }
}
