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
    public partial class Form2 : Form
    {
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

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.ReeberSaldo(saldo);
            form1.Show();
        }

        private void invest_Click(object sender, EventArgs e)
        {

        }
    }
}
