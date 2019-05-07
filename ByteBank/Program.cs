using ByteBank.Funcionarios;
using ByteBank.Sis;
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
            //static é chamado sozinho pois é da classe
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            GerenteDeConta camila = new GerenteDeConta("054.438.115-65");
            camila.Nome = "Camila";
            camila.Senha = "123";

            Diretor roberta = new Diretor("054.438.115-65");
            roberta.Nome = "Roberta";
            roberta.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }


        //static pois vai ser chamado pelo metodo main que também é estático da classe program
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenfiador = new GerenciadorBonificacao();

            Auxiliar igor = new Auxiliar("054.438.115-65");
            igor.Nome = "Igor";

            Designer pedro = new Designer("054.438.115-65");
            pedro.Nome = "Pedro";

            Funcionario camila = new GerenteDeConta("054.438.115-65");
            camila.Nome = "Camila";

            Funcionario roberta = new Diretor("054.438.115-65");
            roberta.Nome = "Roberta";

            gerenfiador.Registrar(igor);
            gerenfiador.Registrar(pedro);
            gerenfiador.Registrar(camila);
            gerenfiador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenfiador.GetTotalBonificacao());
        }
    }
}
