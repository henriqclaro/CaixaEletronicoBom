using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaElel
{
    public partial class Form2 : Form
    {
        private float prefixado;
        private int atual;
        private float variavel;
        Random random = new Random();
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            startInvestimentos();
            if (Program.saldo < 0 && investimentos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleciona um investimento.");
            }
            else
            {
                invest.Enabled = true;
                resgata.Enabled = true;
                resgatarTudo.Enabled = true;
                invest_tudo.Enabled = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            form1.VerificarLimite();
        }
        private void startInvestimentos()
        {
            prefixado = (float)(random.NextDouble() * (20f - 9f) + 9f);
            if (!(Program.fixa != 0))
            {
                Program.fixa = (float)(random.NextDouble() * (19f - 13f) + 13f);
            }
            variavel = (float)(random.NextDouble() * (30f - 0.01f) + 0.01f);
            prefixado_texto.Text = prefixado.ToString();
            fixa_texto.Text = Program.fixa.ToString();
            variavel_texto.Text = variavel.ToString();
        }
        private void invest_Click(object sender, EventArgs e)
        {
            if ((double)numValor.Value > Program.saldo)
            {
                MessageBox.Show("Saldo insuficiente.");
            }
            else
            {
                Program.investido = (double)numValor.Value;
                Program.saldo -= (double)numValor.Value;
            }
        }

        private void escolha_Click(object sender, EventArgs e)
        {
            atual = investimentos.SelectedIndex;
        }

        private void prefix_Tick(object sender, EventArgs e)
        {
            prefixado = prefixado = (float)(random.NextDouble() * (20f - 9f) + 9f);
            prefixado_texto.Text = prefixado.ToString();
            prefix.Interval = (int)random.Next(10000, 60000);
        }

        private void variable_Tick(object sender, EventArgs e)
        {
            variavel = (float)(random.NextDouble() * (30f - 0.01f) + 0.01f);
            variavel_texto.Text = variavel.ToString();
            variable.Interval = (int)random.Next(7000, 20000);
        }

        private void mudamudamuda_Tick(object sender, EventArgs e)
        {
            total.Text = ((float)Program.investido).ToString("c");
            saldo_text.Text = ((float)Program.saldo).ToString("c");
        }

        private void resgata_Click(object sender, EventArgs e)
        {
            if ((double)numResgate.Value > Program.investido)
            {
                MessageBox.Show("Valor de resgate maior que o investido.");
            }
            else
            {
                Program.saldo += (double)numResgate.Value;
                Program.investido -= (double)numResgate.Value;
            }
        }

        private void addinvest_Tick(object sender, EventArgs e)
        {
            if (atual == 0)
            {
                Program.investido *= (prefixado / 100 + 1);
            }
            else if (atual == 1)
            {
                Program.investido *= (Program.fixa / 100 + 1);
            }
            else if (atual == 2)
            {
                Program.investido *= (variavel / 100 + 1);
            }
        }

        private void invest_tudo_Click(object sender, EventArgs e)
        {
            Program.investido += Program.saldo;
            Program.saldo = 0;
        }

        private void resgatarTudo_Click(object sender, EventArgs e)
        {
            Program.saldo += Program.investido;
            Program.investido = 0;
        }
    }
}
