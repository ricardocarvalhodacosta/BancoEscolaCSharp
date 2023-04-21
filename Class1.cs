using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEscola
{
    internal class Menu
    {
        public char menu { get; set; }
        public int op { get; set; }
        public string leitura { get; set; }

        public void SelectClass()
        {
            Console.WriteLine("Olá, eu sou o banco de dados da Escola,");
            Console.WriteLine("e estou aqui para ajudar!");
            Console.WriteLine("Antes de começarmos, me diga:");
            Console.WriteLine("Qual classe você gostaria de acessar?");
            Console.WriteLine();
            Console.WriteLine("Classe A, Classe B ou Classe C?");
            Console.WriteLine();
            Console.Write("Por favor, digite a letra da Classe: ");
        }

        public void SelectFuncion()
        {
            Console.WriteLine();
            Console.WriteLine("Ótimo, você escolheu a Classe " + menu + ", agora me diga, o que iremos fazer hoje?");
            Console.WriteLine();
            Console.WriteLine("1. Adicionar um novo Aluno;");
            Console.WriteLine("2. Alterar os Dados de um Aluno;");
            Console.WriteLine();
        }
    }

    internal class Dados
    {
        public string nome { get; set; }
        public float nota1 { get; set; }
        public float nota2 { get; set; }
    }

}
