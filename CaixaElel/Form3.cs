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
    public partial class Form3 : Form
    {
        double saldo;

        Form1 form1 = new Form1();
        int[] roleta;
        int[] spins;
        Label[] tela;
        Random r = new Random();
        public Form3(Form1 ant)
        {
            InitializeComponent();
            this.saldo = ant.saldo;
            roleta = new int[3];
            spins = new int[3];
            tela = new Label[] { num1, num2, num3};
            for (int i = 0; i < roleta.Length; i++)
            {
                roleta[i] = r.Next(0, 10);
                atualizar(i);
            }
        }
        void atualizar(int i)
        {
            tela[i].Text = roleta[i].ToString();
        }

        private void girar_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < spins.Length; i++)
                {
                    spins[i] = r.Next(1, 21);
                    atualizar(i);
                    tela[i].ForeColor = Color.Black;

                }
                Array.Sort(spins);
                girar.Enabled = true;
                timer1.Enabled = true;
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.ReceberStuff(saldo, -1, -1);
            form1.Show();
        }
        bool parado = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < spins.Length; i++)
                {
                    if (spins[i] > 0)
                    {
                        spins[i]--;
                        if (spins[i] == 0)
                        {
                            parado = true;
                            tela[i].ForeColor = Color.Red;
                        }
                        else
                        {
                            parado = false;
                        }
                        roleta[i]++;
                        if (roleta[i] > 9)
                        {
                            roleta[i] = 0;
                        }
                        atualizar(i);
                    }
                    if(parado && roleta[i] == 1)
                    {
                        tela[i].ForeColor = Color.Green;
                    }
                }
            }
        }
    }
}
