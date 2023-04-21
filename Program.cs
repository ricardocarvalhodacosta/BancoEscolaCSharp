using BancoEscola;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.SelectClass();
        menu.menu = char.Parse(Console.ReadLine().ToUpper());
        menu.SelectFuncion();
        menu.op = int.Parse(Console.ReadLine());

        if (menu.op == 1)
        {
            switch (menu.menu)
            {
                case 'A':
                    Console.WriteLine("Dados dos Alunos da Classe A");
                    break;
                case 'B':
                    Console.WriteLine("Dados dos Alunos da Classe B");
                    break;
                case 'C':
                    Console.WriteLine("Dados dos Alunos da Classe C");
                    break;
                default: Console.WriteLine("Dados invalidos");
                    break;
            }
        }
    }
}