using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //abstract serve como um modelo, não faz sentido ser intanciado
    public abstract class Funcionario
    {
        //estático pois é da classe assim todas as instancias da classe terão o TotalDeFuncionarios
        public static int TotalDeFucionarios { get; private set; }

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; } //protected para ser setado pela classe e seus filhos como no salario do metodo diretor

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando funcionário");
            TotalDeFucionarios++;
            Cpf = cpf;
            Salario = salario;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
