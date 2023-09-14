using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class PessoaFisica
    {
        public string Nome { get; set; }
        public int NumeroConta { get; private set; }
        public double ValorNaConta { get;  private set; }


        public PessoaFisica(string nome, int numeroconta)
        {
            Nome = nome;
            NumeroConta = numeroconta;
        }

        public PessoaFisica(string nome, int numeroconta, double depositoinicial)
        {
            Nome = nome;
            NumeroConta = numeroconta;
            ValorNaConta = depositoinicial;
        }

        public void SomarValorDeposito(double valordeposito2)
        {
            ValorNaConta += valordeposito2;
        }

        public void SomarValorSaque(double valorsaque)
        {
            //valor do saque com taxa de 5 reais
            ValorNaConta -= valorsaque + 5;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + Nome + ", Saldo $" + ValorNaConta ;
        }
    }
}
