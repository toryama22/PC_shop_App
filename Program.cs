using Project_1.EditDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
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
            Application.Run(new Load_Form());
            //Application.Run(new Tables_Form());
            //Application.Run(new Suppliers_Form());
            //Application.Run(new Employees_Form());
            //Application.Run(new Clients_Form());
            //Application.Run(new Contracts_Form());

            //Application.Run(new ClientsAndOrders());
            //Application.Run(new Home_Form(1));


            //Application.Run(new EditEmployee());
            //Application.Run(new EditClient());
        }
    }
}
