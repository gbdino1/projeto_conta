using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade3_recuperacao_gabriel_nicolas
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public ushort Saldo { get; set; }

        // verificar o saldo dos correntistas
        public string Versaldo()
        {
            return $"O saldo do correntista: {Titular}, conta número {Numero} é de: {Saldo.ToString()}";
        }

        // adicionar saldo nas contas dos correntistas
        public void Depositar(ushort Saldo)
        {
            this.Saldo += Saldo; // soma dos atributos
        }

        // sacar valores dos correntistas
        public void Sacar(ushort Saldo)
        {
            this.Saldo -= Saldo; // subtração dos atributos
        }

        // tranferência de R$ 1000,00 de um correntista para outro
        public void Transferir(ushort Saldo, Conta destino)
        {
            // retirada do valor depositado
            this.Saldo -= Saldo;

            // adição do valor depositado
            destino.Saldo += Saldo;
        }
    }
}
