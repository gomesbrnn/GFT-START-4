namespace _01
{
    public class Pessoa
    {
        public Pessoa(string Nome, string DataNascimento, double Altura)
        {
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Altura = Altura;
        }
        
        private string Nome { get; set; }
        private string DataNascimento { get; set; }
        private double Altura { get; set; }

        public void DadosPessoa()
        {
            Console.WriteLine("Dados fornecidos: " + "\n");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine(); // quebra de linha
        }
    
        public void CalculaIdade()
        {
            System.Console.WriteLine("Informe seu ano de nascimento: ");
            int AnoNascimento = int.Parse(Console.ReadLine());
            int AnoAtual = 2022;
            int idade = AnoAtual - AnoNascimento;
            Console.WriteLine($"Sua idade é: {idade}");
        }
    
    }
}