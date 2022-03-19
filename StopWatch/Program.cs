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
            Console.WriteLine("S => segundo => 10s => 10 segundos" + '\n');
            Console.WriteLine("M => minuto => 5m => 5 minutos" + '\n');
            Console.WriteLine("00 => sair");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Indique o tempo e a unidade que deseja contar:");

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
        static void Message(string message, int sleepTime)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(sleepTime);
        }
        static void PreStart(int time)
        {
            Message("Ready?", 1000);
            Message("Set...", 1000);
            Message("GO!", 1000);

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

            Message("Contagem finalizada!", 1500);
            Message("Voltando para o menu...", 1500);

            Menu();
        }
    }
}
