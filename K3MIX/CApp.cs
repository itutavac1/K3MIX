using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3MIX
{

    public class CApp
    {
        CLogic  Logic;
      
        public  CApp()
        {
            Logic = new  CLogic();
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
            CGlobals.Logic = Logic;
            return true;
        }
    }
}
