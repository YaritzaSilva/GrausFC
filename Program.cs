using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double C,F;

            Console.Beep();
            Console.WriteLine("---------");
            Console.Write("Digite a temperatura (em °F): ");
            entrada = Console.ReadLine();
            F= Convert.ToDouble(entrada);

            C = (F-32)/1.8;

            Console.Beep();
            Console.WriteLine("----------");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("\n---Equivalencia---");
            Console.ResetColor();
            Console.WriteLine($"Essa temperatura em °C fica: {C}");
            Console.WriteLine("----------");
        }
    }
}
