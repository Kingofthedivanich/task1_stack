using System;
using System.Windows.Forms;
using task1_stack.Forms;

namespace StackApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}