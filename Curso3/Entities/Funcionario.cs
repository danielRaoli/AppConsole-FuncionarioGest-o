using System;
using System.Collections.Generic;


namespace Curso3.Entities
{
   class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return "Id: "+ Id+"\n Nome: "+ Nome+"\n Salario: "+Salario;
        }

        public void AumentarSalario(int porcentagem)
        {
            Salario += (Salario*porcentagem/100);
        }
    }
}
