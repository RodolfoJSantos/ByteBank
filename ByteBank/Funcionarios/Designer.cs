using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        //diz que o construtor Diretor vai chamar o construtor Funcionario, passando o seu argumento cpf
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
