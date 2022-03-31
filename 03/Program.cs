using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo a nossa venda de sucos!" + "\n");
            Console.WriteLine("Sucos disponiveis:" + "\n");
            Console.WriteLine("L - Limão");
            Console.WriteLine("T - Tamarindo");
            Console.WriteLine();

            System.Console.WriteLine("Informe qual suco deseja comprar: ");
            string SucoVendido = Console.ReadLine();
            System.Console.WriteLine("Digite a quantidade de Litros que deseja comprar: ");
            double LitrosVendidos = double.Parse(Console.ReadLine());
            double ValorPorLitro = LitrosVendidos * 5;
            double CalculoDesconto;
            double ValorFinal;

            if (SucoVendido == "L")
            {
                if (LitrosVendidos <= 2 && LitrosVendidos < 5)
                {
                   CalculoDesconto = 0.03 * ValorPorLitro;
                   ValorFinal = ValorPorLitro - CalculoDesconto;
                    Console.WriteLine($"Valor a ser pago = {ValorFinal}");
                }
                else if (LitrosVendidos >= 5)
                {
                    CalculoDesconto = 0.05 * ValorPorLitro;
                    ValorFinal = ValorPorLitro - CalculoDesconto;
                    Console.WriteLine($"Valor a ser pago = {ValorFinal}");
                }
            }
            else if (SucoVendido == "T")
            {
                if (LitrosVendidos <= 2 && LitrosVendidos < 5)
                {
                    CalculoDesconto = 0.04 * ValorPorLitro;
                    ValorFinal = ValorPorLitro - CalculoDesconto;
                    Console.WriteLine($"Valor a ser pago = {ValorFinal}");
                }
                else if (LitrosVendidos >= 5)
                {
                    CalculoDesconto = 0.06 * ValorPorLitro;
                    ValorFinal = ValorPorLitro - CalculoDesconto;
                    Console.WriteLine($"Valor a ser pago = {ValorFinal}");
                }
            }

        }
    }
}
