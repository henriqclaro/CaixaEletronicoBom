using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaElel
{
    public partial class Form1 : Form
    {
        public double saldo = 0;
        public double investido;
        public float fixa;
        public Form1()
        {
            InitializeComponent();
        }

        public void ReceberStuff(double saldo, float fixa, double invest)
        {
            this.fixa = fixa;
            this.saldo = saldo;
            this.investido = invest;
            AtualizarSaldo();
        }

        void AtualizarSaldo()
        {
            lblSaldo.Text = saldo.ToString("c");
            VerificarLimite();
        }

        void VerificarLimite()
        {
            btnSacar.Enabled = !((saldo - (double)numValor.Value) < ((double)numLimite.Value * -1));
            invest.Enabled = !((saldo - (double)numValor.Value) < ((double)numLimite.Value * -1) && investido<=0);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            saldo += (double) numValor.Value;
            AtualizarSaldo();
        }
        private void btnSacar_Click(object sender, EventArgs e)
        {
            saldo -= (double) numValor.Value;
            AtualizarSaldo();
        }

        private void numValor_ValueChanged(object sender, EventArgs e)
        {
            VerificarLimite();
        }

        private void invest_Click(object sender, EventArgs e)
        {
            Form2 inves = new Form2(this);
            inves.Show();
            this.Hide();
        }
    }
}
