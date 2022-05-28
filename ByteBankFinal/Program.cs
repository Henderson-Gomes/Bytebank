using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankFinal.Funcionarios;
using ByteBankFinal.Sistemas;

namespace ByteBankFinal
{
     class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.ReadLine();

        }
        public static void UsarSistema()
        {
            SistemaInterno sistemainterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "roberta";
            roberta.Senha = "123";
            ParceiroComercial parceirocomercial = new ParceiroComercial();
            parceirocomercial.Senha = "aaa";

            sistemainterno.Logar(parceirocomercial, "aaa");
            sistemainterno.Logar(roberta, "123");

            


            

        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Desenvolvedor henderson = new Desenvolvedor("442.063.338-74");
            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(henderson);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("total bonificações: "+ gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
