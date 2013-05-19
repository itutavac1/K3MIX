using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3MIX
{
    /// <summary>
    /// State should contain all forms, the selected one will be shown
    /// </summary>
    public enum State
    {
        Nothing,
        Temp,
        Login,
        Menu,
        Track,
        Input,
        PriceList,
        Show
    }
    /// <summary>
    /// Main class
    /// Here should be everything that Main uses
    /// </summary>
    public class CApp
    {
        State   state;
        CLogic  Logic;
        //FLogin  Login;
        //IForm   Form;
        public  CApp()
        {
            state = State.Nothing;
            Logic = new  CLogic();
            //Form  = new  FLogin();
            //Login = new FLogin();
        }
        ~CApp()
        {

        }
        /// <summary>
        /// Calls Logic Init
        /// </summary>
        /// <returns>true if logic initialized</returns>
        public bool Init()
        {
            if (!Logic.Init())
                return false;
            Globals.Logic = Logic;
            //Globals.Form.ContinueDialog();
            //ChangeForm(State.Login, ref Form);
            //Form.SetLogic(Logic);
            //Form.DisplayForm();
            return true;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newState">Which form will be loaded</param>
        /// <param name="Form">Where it will be loaded</param>
        public void ChangeForm(State newState,ref IForm Form)
        {
            if (state == newState)
                return;
            state = newState;
            Form = null;
            if (state == State.Temp)
                Form = new FTemp();
            else if (state == State.Login)
                Form = new FLogin();
        }
    }

    public static class Globals
    {
        static State state;

        public static IForm Form;

        public static CLogic Logic;

        public static void SetUp(State state, ref IForm Form)
        {
            Globals.ChangeForm(state, ref Form);
            Globals.Form.SetLogic(Logic);
            Globals.Form.DisplayForm();
        }

        public static void ChangeForm(State newState, ref IForm Form)
        {
            if (state == newState)
                return;
            state = newState;
            Form = null;
            if (state == State.Temp)
            {
                Form = new FTemp();
            }
            else if (state == State.Login)
            {
                Form = new FLogin();
            }
            else if (state == State.Menu)
            {
                Form = new FMenu();
            }
            else if (state == State.Input)
            {
                Form = new FInput();
            }
            else if (state == State.PriceList)
            {
            }
            else if (state == State.Show)
            {
            }
            else if (state == State.Track)
            {
            }
        }
    }
}
