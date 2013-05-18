using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Naming, declaration, and stuff like that ...
    class CName;  
    CName Name;   
    Name->Init(); 
    int firstSecondThird = 0;
    void FirstSecondThird();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if (!something)
            {
                // try again
            }
        }
    }
*/

namespace K3MIX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CApp App = new CApp();
            if (!App.Init())
                return;
            Application.Run(new Form1());
        }
    }
}
