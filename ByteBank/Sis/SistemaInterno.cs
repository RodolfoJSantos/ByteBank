using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sis
{
    public class SistemaInterno
    {
        /// <summary>
        /// Método responsável por realizar login
        /// </summary>
        /// <param name="funcionario">Tipo IAutenticavel 'assim só podem usar esse método as classes que herdam essa interface'</param>
        /// <param name="senha"></param>
        /// <returns>bool</returns>
        /// As classes que herdam IAuten.. também são do tipo da interface
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
