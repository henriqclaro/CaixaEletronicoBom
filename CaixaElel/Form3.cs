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
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();
        int forms = 0;
        public static bool noForms = false;
        Random r = new Random();
        List<ApostaResult> apostas = new List<ApostaResult>();
        public Form3(Form1 ant)
        {
            InitializeComponent();
            atualizarCoisas();
        }
        private void girar_Click(object sender, EventArgs e)
        {
            if(roletas.Value == 0)
            {
                killAllButton.Enabled = false;
                MessageBox.Show("Selecione um valor maior que 0.");
            }
            else
            {
                apostas.Clear();
                forms = 0;

                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
                int formWidth = 300;
                int formHeight = 200;
                int totalWidth = (int)roletas.Value * formWidth;
                int startX = (screenWidth - totalWidth) / 2;
                int startY = (screenHeight - formHeight) / 2;

                for (int i = 0; i < roletas.Value; i++)
                {
                    ApostaResult aposta = new ApostaResult(r.Next(0, 10), r.Next(0, 10), r.Next(0, 10), this);
                    aposta.StartPosition = FormStartPosition.Manual;
                    aposta.Location = new Point(startX + (i * formWidth), startY);

                    apostas.Add(aposta);
                    aposta.Show();
                    aposta.iniciarTimer();
                }
                girar.Enabled = false;
                killAllButton.Enabled = true;
            }
               
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            killAll();
            form1.Show();
        }
        private void atualizarCoisas()
        {
            apostadoLbl.Text = Program.apostado.ToString("c");
            atual.Text = Program.saldo.ToString("c");
        }
        private void aposta_Click(object sender, EventArgs e)
        {
            if ((double)numValor.Value > Program.saldo)
            {
                MessageBox.Show("Saldo insuficiente.");
            }
            else
            {
                Program.apostado += (double)numValor.Value;
                Program.saldo -= (double)numValor.Value;
                
                atualizarCoisas();
            }
        }

        private void resgata_Click(object sender, EventArgs e)
        {
            if ((double)numResgate.Value > Program.apostado)
            {
                MessageBox.Show("Valor de resgate maior que o investido.");
            }
            else
            {
                Program.saldo += ((double)numResgate.Value*0.8);
                Program.apostado -= (float)numResgate.Value;
                atualizarCoisas();
            }
        }
        private void multiplicador_Tick(object sender, EventArgs e)
        {
            multiplier_text.Text = Program.multiplicador.ToString();
            acertos_label.Text = Program.acertos_aposta.ToString();
            if (apostas.Count == 0)
            {
                noForms = true;
                girar.Enabled = true;
            }
            else
            {
                noForms = false;
            }
        }
        public void killAll()
        {
            for (int i = 0; i < apostas.Count; i++)
            {
                apostas[i].Close();
            }
            apostas.Clear();
            Program.apostado *= Program.multiplicador; 
            apostadoLbl.Text = Program.apostado.ToString("c");
        }
        private void killAll_Click(object sender, EventArgs e)
        {
            killAll();
            Program.multiplicador = 0;
            Program.acertos_aposta = 0;
        }

        private void aposTudo_Click(object sender, EventArgs e)
        {
            Program.apostado += (float)Program.saldo;
            Program.saldo = 0;
            atualizarCoisas();
        }

        private void resgTudo_Click(object sender, EventArgs e)
        {
            Program.saldo += Program.apostado * 0.8;
            Program.apostado = 0;
            atualizarCoisas();
        }
    }
}
