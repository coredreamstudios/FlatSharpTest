using System;
using System.Windows.Forms;

namespace FlatSharpTest
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainApp());
        }
    }
}