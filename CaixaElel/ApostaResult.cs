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
    public partial class ApostaResult : Form
    {
        int[] spins;
        Label[] tela;
        int[] roleta;
        byte acertosLocal = 0;
        bool parado = false;
        bool bonus = false;
        Form3 form;
        Timer timer;
        Random r = new Random();
        public ApostaResult(int rV1, int rV2, int rV3, Form3 ant)
        {
            InitializeComponent();
            roleta = new int[3];
            spins = new int[3];
            spins[0] = r.Next(20, 40);
            spins[1] = r.Next(30, 50);
            spins[2] = r.Next(40, 60);
            tela = new Label[] { num1, num2, num3 };

            for (int i = 0; i < roleta.Length; i++)
            {
                if (i == 0)
                    roleta[i] = rV1;
                else if (i == 1)
                    roleta[i] = rV2;
                else if (i == 2)
                    roleta[i] = rV3;

                atualizar(i);
            }
            this.form = ant;
            iniciarTimer();
        }

        public void iniciarTimer()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            timer.Start();
        }

        void atualizar(int i)
        {
            tela[i].Text = roleta[i].ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < spins.Length; i++)
            {
                if (spins[i] > 0)
                {
                    spins[i]--;
                    if (spins[i] == 0)
                    {
                        parado = true;
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
                    
                    if(parado && (i>0 && roleta[i] == roleta[i - 1]) && roleta[i] != 7)
                    {
                        acertosLocal+=2;
                        Program.acertos_aposta+=2;
                        tela[i].ForeColor = Color.Green;
                        tela[i - 1].ForeColor = Color.Green;
                        bonus = false;
                    } else if(parado )
                    {
                        tela[i].ForeColor = Color.Red;
                    }
                    if (parado && (roleta[i] == 7))
                    {
                        tela[i].ForeColor = Color.Purple;
                        acertosLocal++;
                        bonus = true;
                        Program.acertos_aposta++;
                    }
                    if (i == 2)
                    {
                        Program.multiplicador += Program.acertos_aposta * 0.7f + 0.9f;
                        if (acertosLocal == 0)
                        {
                            Program.multiplicador = Program.acertos_aposta * 0.1f;
                        }
                        else if (acertosLocal == 3)
                        {
                            if (bonus)
                                Program.multiplicador += 3f;
                            else
                                Program.multiplicador *= 1.5f;

                        }
                    }
                }
            }
        } 
      

        private void ApostaResult_Load(object sender, EventArgs e)
        {
            iniciarTimer();
        }

        private void ApostaResult_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
