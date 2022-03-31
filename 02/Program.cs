using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo! Tudo bem?" + "\n");
            Console.WriteLine("Poderia me informar em que turno você trabalha?" + "\n");
            Console.WriteLine("Para informar seu turno digite uma das opções: " + "\n");
            Console.WriteLine("M-matutino");
            Console.WriteLine("V-vespertino");
            Console.WriteLine("N-noturno");
            Console.WriteLine();

            string Turno = (Console.ReadLine());

            if(Turno == "M")
            {
                Console.WriteLine("Bom dia!");
            }
            else if(Turno == "V")
            {
                Console.WriteLine("Boa tarde!");
            }
            else if(Turno == "N")
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }
    }
}