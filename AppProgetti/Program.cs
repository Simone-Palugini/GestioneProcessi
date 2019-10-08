using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProgetti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione dei processi");

            //Process.Start(@"C:\Users\studenti\Source\Repos\GestioneProcessi\AppProgetti\HelloWorld.txt");
            Process.Start("Chrome.exe", @"https://www.inter.it/it/squadra/G0943/tommaso-berni");

            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"C:\Users\studenti\Source\Repos\GestioneProcessi\AppProgetti\HelloWorld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            //app.WaitForExit();
            

            var processes = Process.GetProcesses();
            foreach(var p in processes)
            {
                if (p.ProcessName == "Notepad")
                {
                    p.Kill();
                }
            }
            

            Console.WriteLine("Programma terminato");
            Console.ReadLine();
        }
    }
}
