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
        Login
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
        IForm   Form;
        public  CApp()
        {
            state = State.Nothing;
            Logic = new  CLogic();
            Form  = new  FLogin();
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
            ChangeForm(State.Temp, ref Form);
            Form.DisplayForm();
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
}
