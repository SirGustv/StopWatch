using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Instruções:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("S => segundo => 10s => 10 segundos");
            Console.WriteLine("M => minuto => 5m => 5 minutos");
            Console.WriteLine("0s => sair");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplyer = 1;

            if (type == 'm')
            {
                multiplyer = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplyer);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready?");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("GO!");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro Finalizado...");
            Thread.Sleep(1500);
            Console.WriteLine("Retornando ao Menu...");
            Thread.Sleep(1500);
            Menu();
        }
    }
}
