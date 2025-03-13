﻿using System;
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
        double taxa = 0.05;

        public Form1()
        {
            InitializeComponent();
            AtualizarSaldo();
        }

        void AtualizarSaldo()
        {
            lblSaldo.Text = saldo.ToString("c");
            VerificarLimite();
        }

        void VerificarLimite()
        {
            btnSacar.Enabled = !(((saldo - (double)numValor.Value) < ((double)numLimite.Value * -1))||numValor.Value==0);
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

        private void tmrJuros_Tick(object sender, EventArgs e)
        {
            saldo += saldo * taxa;
            AtualizarSaldo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text =
                $"* Taxa: {taxa * 100}% / {tmrJuros.Interval / 1000f}s";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("r u sr?",
                "Bangkok Bank",
                MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("thx mf");
        }
    }
}
