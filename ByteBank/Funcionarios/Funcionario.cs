using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        //estático pois é da classe assim todas as instancias da classe terão o TotalDeFuncionarios
        public static int TotalDeFucionarios { get; private set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando funcionário");
            TotalDeFucionarios++;
            Cpf = cpf;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
