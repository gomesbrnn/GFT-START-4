using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao polo de doação se sangue!" + "\n");
            Console.WriteLine("Informe sua idade: ");
            Console.WriteLine();
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18 && idade <= 67)
            {
                Console.WriteLine("Você está dentro da idade permitida para doar, parabéns pela iniciativa!");
            }
            else if(idade > 67)
            {
                Console.WriteLine("Poxa, infelizmente você ultrapassou a idade permitida para doação de sangue :(.");

            }
            else
            {
                Console.WriteLine("Poxa, você não tem idade suficiente :(. Você pode voltar assim que possuir no minimo 18 anos, parabéns pela iniciativa!");
            } 

        }
    }
}