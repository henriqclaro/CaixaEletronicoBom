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
        private float fixa;
        private int atual;
        private double investido;
        private float variavel;
        Random random = new Random();
        Form1 form1;
        double saldo;
        public Form2(Form1 anterior)
        {
            InitializeComponent();
            this.form1 = anterior;
            this.saldo = anterior.saldo;
            this.fixa = anterior.fixa;
            this.investido = anterior.investido;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            startInvestimentos();
            if (saldo < 0 && investimentos.SelectedItems.Count == 0)
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
            form1.ReceberStuff(saldo, fixa, investido);
            form1.Show();
        }
        private void startInvestimentos()
        {
            prefixado = (float)(random.NextDouble()*(20f- 9f) + 9f);
            if(!(fixa != 0)) {
                fixa = (float)(random.NextDouble() * (19f - 13f) + 13f);
            }
            variavel = (float)(random.NextDouble() * (30f - 0.01f) + 0.01f);
            prefixado_texto.Text = prefixado.ToString();
            fixa_texto.Text = fixa.ToString();
            variavel_texto.Text = variavel.ToString();
        }
        private void invest_Click(object sender, EventArgs e)
        {
            if ((double)numValor.Value > saldo)
            {
                MessageBox.Show("Saldo insuficiente.");
            }
            else
            {
                investido = (double)numValor.Value;
                saldo -= (double)numValor.Value;
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
            total.Text = "R$" + ((float)investido);
            saldo_text.Text = "R$" + ((float)saldo);
        }

        private void resgata_Click(object sender, EventArgs e)
        {
            if((double)numResgate.Value > investido)
            {
                MessageBox.Show("Valor de resgate maior que o investido.");
            }
            else
            {
                saldo += (double)numResgate.Value;
                investido -= (double)numResgate.Value;
            }
        }

        private void addinvest_Tick(object sender, EventArgs e)
        {
            if (atual == 0)
            {
                investido *= (prefixado / 100 + 1);
            }
            else if (atual == 1)
            {
                investido *= (fixa / 100 + 1);
            }
            else if (atual == 2)
            {
                investido *= (variavel / 100 + 1);
            }
        }

        private void invest_tudo_Click(object sender, EventArgs e)
        {
            investido += saldo;
            saldo = 0;
        }

        private void resgatarTudo_Click(object sender, EventArgs e)
        {
            saldo += investido;
            investido = 0;
        }
    }
}
