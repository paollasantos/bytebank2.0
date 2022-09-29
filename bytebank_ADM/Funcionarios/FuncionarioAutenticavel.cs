using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return senha == senha;
        }
    }
}
