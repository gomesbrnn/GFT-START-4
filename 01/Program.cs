using System;

namespace _01 
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Breno","15/03/2000",1.79);
            p1.DadosPessoa();
            p1.CalculaIdade();
        }
    }
}