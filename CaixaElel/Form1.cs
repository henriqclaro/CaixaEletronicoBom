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
        double saldo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void AtualizarSaldo()
        {
            lblSaldo.Text = saldo.ToString("c");
            VerificarLimite();
        }

        void VerificarLimite()
        {
            btnSacar.Enabled = !((saldo - (double)numValor.Value) < ((double)numLimite.Value * -1));
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

        double taxa = 0.05;

        private void tmrJuros_Tick(object sender, EventArgs e)
        {
            saldo += saldo*taxa; 
            lblSaldo.Text = saldo.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text =
                $"* Taxa: {taxa * 100}% a.c {tmrJuros.Interval/1000f}s";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Desseja mesmo sair do banco?","Banco",MessageBoxButtons.YesNo);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
                lblTaxa.Text = e.ToString();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Tchau, pobre!");
        }
    }
}
