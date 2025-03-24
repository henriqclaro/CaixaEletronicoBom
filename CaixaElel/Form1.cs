using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
        int color = 50;
        public Form1()
        {
            InitializeComponent();
        }

        void AtualizarSaldo()
        {
            lblSaldo.Text = Program.saldo.ToString("c");
            VerificarLimite();
        }

        public void VerificarLimite()
        {
            btnSacar.Enabled = !((Program.saldo - (double)numValor.Value) < ((double)numLimite.Value * -1));
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Program.saldo += (double)numValor.Value;
            AtualizarSaldo();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Program.saldo -= (double)numValor.Value;
            AtualizarSaldo();
        }

        private void numValor_ValueChanged(object sender, EventArgs e)
        {
            VerificarLimite();
        }

        private void invest_Click(object sender, EventArgs e)
        {
            Form2 inves = new Form2();
            inves.Show();
            this.Hide();
        }

        private void aposta_Click(object sender, EventArgs e)
        {
            Form3 apost = new Form3(this);
            apost.Show();
            this.Hide();
        }

        Random rnd = new Random();
        bool aumenta;
        private async void aposta_Enter(object sender, EventArgs e)
        {
            aumenta = false;
            await mudarCor(-3);
        }

        private async Task mudarCor(int quanto)
        {
            while ((aumenta == true && quanto > 0) || (aumenta == false && quanto < 0))
            {
                color += quanto;
                if (color >= 50)
                    break;
                if (color <= 0)
                    break;
                BackColor = Color.FromArgb(color, color, color);
                await Task.Delay(1); // btw, ta ai só pra funcionar, se n tiver o codigo roda tão rapido q n acontece nada (eu acho)
            }
        }

        private async void aposta_Leave(object sender, EventArgs e)
        {
            aumenta = true;
            await mudarCor(3);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void background_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = Program.saldo.ToString("c");
        }
    }
}
