using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses = 30;
            Console.WriteLine("Quantos meses você deseja somar?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            

            int total = meses * quantidade;

            Console.WriteLine($"O total de dias é {total}.");

        }
    }
}
;