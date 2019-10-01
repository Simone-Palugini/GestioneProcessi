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

            Process.Start(@"\\DC01SRV\_Condivisa\INF\4 A\Palugini Simone\AppProgetti\AppProgetti\HelloWorld.txt");
            Process.Start("Chrome.exe", @"https://www.inter.it/it/squadra/G0943/tommaso-berni");

            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"\\DC01SRV\_Condivisa\INF\4 A\Palugini Simone\AppProgetti\AppProgetti\HelloWorld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            //app.WaitForExit();
            

            var processes = Process.GetProcesses();
            foreach(var p in processes)
            {
                if (p.ProcessName = "Notepad")
                {
                    p.Kill();
                }
            }

            Console.WriteLine("Programma terminato");
            Console.ReadLine();
        }
    }
}
