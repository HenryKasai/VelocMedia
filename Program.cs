using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira os dados de seu objeto em estudo, e veja sua velocidade média.");

            Console.Write("Distância percorrida em metros:");
            string d = Console.ReadLine();
            decimal Distância = Convert.ToDecimal(d);

            Console.Write("Tempo gasto em segundos:");
            string t = Console.ReadLine();
            decimal Tempo = Convert.ToDecimal(t);
            
            decimal resultfinal = Distância / Tempo;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A velocidade média de seu objeto em estudo é " + resultfinal + " m/s");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();




        }
    }
}
