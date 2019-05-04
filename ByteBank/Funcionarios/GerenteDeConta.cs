﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        //diz que o construtor Diretor vai chamar o construtor Funcionario, passando o seu argumento cpf
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Gerente");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}