using System;

namespace CalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a Idade de uma pessoa");
            Console.Write("Nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Pessoa p;
            p = new Pessoa(nome, ano);
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
