using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenfiador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "054.438.115-65");
            carlos.Nome = "Carlos";
            carlos.AumentarSalario();

            Diretor roberta = new Diretor("054.438.115-65");
            roberta.Nome = "Roberta";
            roberta.AumentarSalario();

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.Salario);
            Console.WriteLine(carlos.GetBonificacao());
            gerenfiador.Registrar(carlos);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.Salario);
            Console.WriteLine(roberta.GetBonificacao());

            gerenfiador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenfiador.GetTotalBonificacao());


            Console.ReadLine();

        }
    }
}
