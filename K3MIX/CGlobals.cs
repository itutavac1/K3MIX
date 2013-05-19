using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3MIX
{
    /// <summary>
    /// All available forms 
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
    /// </summary>
    public static class CGlobals
    {
        static State state;

        public static IForm Form;

        public static CLogic Logic;

        /// <summary>
        /// Load a form, set up the Logic and display the form
        /// </summary>
        /// <param name="state">Which form will be loaded </param>
        /// <param name="Form">Where it will loaded</param>
        public static void SetUp(State state, ref IForm Form)
        {
            CGlobals.ChangeForm(state, ref Form);
            CGlobals.Form.SetLogic(Logic);
            CGlobals.Form.DisplayForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newState">Which form will be loaded</param>
        /// <param name="Form">Where it will be loaded</param>
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
                Form = new FPriceList();
            }
            else if (state == State.Show)
            {
                Form = new FShow();
            }
            else if (state == State.Track)
            {
                Form = new FTrack();
            }
        }
    }
}
