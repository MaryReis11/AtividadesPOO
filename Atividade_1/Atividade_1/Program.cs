using Atividade_1.Models;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe pessoa
            Pessoa p = new Pessoa();

            //atribuindo os valores
            p.Nome = "Hellen";
            p.Altura = 1.71f;

            //instancia do metado dateTime
            p.DataDeNascimento = new DateTime(2002, 11, 9);//ano, mês e dia

            //Invocando metodo imprimirDados para os dados serem preenchidos na tela
            p.ImprimirDados();

            int idade = p.CalculoIdade();

            Console.WriteLine("Idade: " + idade);


            Console.ReadKey();
        }
    }
}