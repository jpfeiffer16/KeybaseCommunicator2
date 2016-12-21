// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using DevZH.UI;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new MainWindow("KeybaseCommunicator", 640, 480, true);
            app.Run(window);
        }
    }
}
