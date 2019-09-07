using ppUpdator.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ppUpdator.App
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Updator u = new Updator();
            u.Do();
            Console.WriteLine("Finished...\n\nStarting application...");
            u.StartApp();
        }
    }
}
