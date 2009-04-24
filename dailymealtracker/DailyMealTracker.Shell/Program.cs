using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ninject.Core;
using MealTracker.View;

namespace MealTracker.Shell
{
    static class Program
    {
        [STAThread]
        static void Main()
        { 
          //Setup Ninject for DI.
            IKernel kernel = new StandardKernel(new ServiceModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Get the main form through the kernel so it gets injected.
            Application.Run(kernel.Get<WF_MainForm>());
        }
    }
}
