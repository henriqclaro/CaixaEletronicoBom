using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaElel
{
    public partial class Form1 : Form
    {
        public double saldo = 0;
        public double investido = 0;
        public float fixa = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void ReceberStuff(double saldo, float fixa, double invest)
        {
            this.saldo = saldo;
            if(!(fixa == -1))
            {
                this.fixa = fixa;
            }
            if(!(invest == -1))
            {
                this.investido = invest;
            }
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
            aposta.Enabled = !((saldo - (double)numValor.Value) < ((double)numLimite.Value * -1) && investido <= 0);
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

        private void aposta_Click(object sender, EventArgs e)
        {
            mouse = false;
            Form3 apost = new Form3(this);
            apost.Show();
            this.Hide();
        }

        Random rnd = new Random();
        bool mouse = false;
        private async void aposta_Enter(object sender, EventArgs e)
        {
            mouse = true;
            while(mouse){
                BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                await Task.Delay(100);
            }
            BackColor = Color.FromArgb(50, 51, 53);
            

        }
        private void aposta_Leave(object sender, EventArgs e)
        {
            mouse = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
