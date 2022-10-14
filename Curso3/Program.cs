using System;
using System.Collections;
using System.Xml;
using Curso3.Entities;

namespace Curso3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("quantos funcionarios deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("digite o nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.WriteLine("digite o Id do funcionario: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionario(id,nome ,salario));

            }

          Console.WriteLine("digite o id do funcionario que deseja aumentar o salario");
            int busca = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a porcentagem de aumento: ");
            int porcent = int.Parse(Console.ReadLine());

            funcionarios.Find(x => x.Id == busca).AumentarSalario(porcent);

            foreach(Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}
