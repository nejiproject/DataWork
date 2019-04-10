using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataWork
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
            Application.Run(new fmMain());
            using (WorkerContext db = new WorkerContext())
            {
                Worker worker1 = new Worker { Name = "Tom", Age = 33 };
                Worker worker2 = new Worker { Name = "Sam", Age = 26 };
                db.Workers.Add(worker1);
                db.Workers.Add(worker2);
                db.SaveChanges();
            }
        }
    }

   
}
