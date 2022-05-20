using System;

namespace exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double ano;


            Console.WriteLine("escolha um ano");
            ano = Convert.ToDouble(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0)
            {
               
                Console.WriteLine("O ano " + ano + " e bissexto.");
            }
            else
            {
                Console.WriteLine("O ano " + ano + " nao e Bissexto.");
            }
        }
    }
}