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

            Funcionario carlos = new Funcionario("054.438.115-65");
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor("054.438.115-65");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            gerenfiador.Registrar(carlos);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            gerenfiador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenfiador.GetTotalBonificacao());


            Console.ReadLine();

        }
    }
}
