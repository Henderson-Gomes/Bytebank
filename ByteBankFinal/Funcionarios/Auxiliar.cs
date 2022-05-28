using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankFinal.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar(string cpf) : base(2000,cpf)
        {

        }
        public Auxiliar (string nome,string cpf,double salario) : base(salario, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario*=1.1;
        }
        public override double GetBonificacao()
        {
            return Salario *= 0.2 ;
        }
    }
}
