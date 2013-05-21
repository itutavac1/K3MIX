using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3MIX
{
    public interface IForm
    {
        /// <summary>
        /// this.ShowDialog();
        /// </summary>
        void DisplayForm();
        /// <summary>
        /// Should be set before DisplayForm, because DisplayForm will show the form and lock the app
        /// So SetLogic will not be called in time
        /// </summary>
        /// <param name="Logic">Logic from App object</param>
        /// <returns></returns>
        bool SetLogic(CLogic Logic);
        void FinishDialog();
        void ContinueDialog();
    }
}
