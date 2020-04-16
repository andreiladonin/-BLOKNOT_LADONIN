using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blocknot.BL;

namespace Blocknot
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            MessageService service = new MessageService();
            FileManger file = new FileManger();

            MainPresenter mainPresenter = new MainPresenter(form, file, service);


            Application.Run(form);


        }
    }
}
