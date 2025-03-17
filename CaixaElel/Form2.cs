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
        private float prefixado = 0f;
        private float fixa = 0f;
        private float variavel = 0f;
        Random random = new Random();
        Form1 form1;
        double saldo;
        public Form2(Form1 anterior)
        {
            InitializeComponent();
            this.form1 = anterior;
            this.saldo = anterior.saldo;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            startInvestimentos();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.ReeberSaldo(saldo);
            form1.Show();
        }
        private void startInvestimentos()
        {
            prefixado = (float)(random.NextDouble()*(20f- 9f) + 9f);
            fixa = (float)(random.NextDouble() * (19f - 13f) + 13f);
            variavel = (float)(random.NextDouble() * (30f - 0.01f) + 0.01f);
            prefixado_texto.Text = prefixado.ToString();
            fixa_texto.Text = fixa.ToString();
            variavel_texto.Text = variavel.ToString();
            tick.Interval = 1;
            tick.Start();
        }
        private void invest_Click(object sender, EventArgs e)
        {

        }

        private void investimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void escolha_Click(object sender, EventArgs e)
        {
            if(investimentos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleciona um investimento.");
            }
            else
            {
                invest.Enabled = true;
                if(investimentos.SelectedIndex == 0)
                {

                }
            }
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            total.Text = "a";
            total.Text += "a";
        }
    }
}
