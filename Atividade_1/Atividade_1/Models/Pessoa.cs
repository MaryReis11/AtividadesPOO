using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1.Models
{
    internal class Pessoa
    {
        private string nome;
        private DateTime dataDeNascimento;
        private float altura;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }



        public DateTime DataDeNascimento
        {
            get
            {
                return dataDeNascimento;
            }
            set
            {
                dataDeNascimento = value;
            }
        }


        public float Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }

        }

        //Metodo para imprimir dados da pessoa
        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("A data de nascimento da pessoa é: " + dataDeNascimento);
            Console.WriteLine("A altura da pessoa é : " + altura);
        }

        //Metodo para calcular idade da pessoa
        public int CalculoIdade()
        {
            return DateTime.Today.Year - dataDeNascimento.Year;
        }
    }
}

