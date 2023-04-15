using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade3_recuperacao_gabriel_nicolas
{
    public partial class Form1 : Form
    {

        // objetos que serão parte da classe Form1
        Conta correntista1 = new Conta
        {
            Numero = 1000,
            Titular = "Gabriel",
            Saldo = 1000
        };

        Conta correntista2 = new Conta
        {
            Numero = 1001,
            Titular = "Barth",
            Saldo = 1000
        };

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // CRIAÇÃO DOS CORRENTISTAS E ATRIBUIÇÃO DOS DADOS
            Conta correntista1 = new Conta
            {
                Numero = 1000,
                Titular = "Gabriel",
                Saldo = 1000
            };

            Conta correntista2 = new Conta
            {
                Numero = 1001,
                Titular = "Barth",
                Saldo = 1000
            };

            lblSaldoCorrentista1.Text = correntista1.Saldo.ToString();
            lblSaldoCorrentista2.Text = correntista2.Saldo.ToString();
            lblNomeC1.Text = correntista1.Titular;
            lblNomeC2.Text = correntista2.Titular;
            lblContaC1.Text = correntista1.Numero.ToString();
            lblContaC2.Text = correntista2.Numero.ToString();
        }

        private void btnVersSaldoC1_Click(object sender, EventArgs e)
        {
            // ver saldo dos correntistas
            lblSaldoCorrentista1.Text = correntista1.Saldo.ToString();
        }

        private void btnVerSaldo2_Click(object sender, EventArgs e)
        {
            lblSaldoCorrentista2.Text = correntista2.Saldo.ToString();
        }

        private void btnAddC1_Click(object sender, EventArgs e)
        {
            // Adição de R$ 100 a conta do correntista 1
            correntista1.Depositar(100);
        }

        private void btnAddC2_Click(object sender, EventArgs e)
        {
            // Adição de R$ 100 a conta do correntista 2
            correntista2.Depositar(100);
        }

        private void btnSubC1_Click(object sender, EventArgs e)
        {
            // saque de R$ 100 do correntista 1
            correntista1.Sacar(100);
        }

        private void btnSubC2_Click(object sender, EventArgs e)
        {
            // saque de R$ 100 do correntista 2
            correntista2.Sacar(100);
        }

        private void btnTranfC1ToC2_Click(object sender, EventArgs e)
        {
            // transferência de R$ 100 do correntita 1 para o correntista 2
            correntista1.Transferir(100, correntista2);
        }
    }
}
