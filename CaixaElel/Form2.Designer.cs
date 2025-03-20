namespace CaixaElel
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.invest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.escolha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.investimentos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.variavel_texto = new System.Windows.Forms.Label();
            this.fixa_texto = new System.Windows.Forms.Label();
            this.prefixado_texto = new System.Windows.Forms.Label();
            this.prefix = new System.Windows.Forms.Timer(this.components);
            this.variable = new System.Windows.Forms.Timer(this.components);
            this.mudamudamuda = new System.Windows.Forms.Timer(this.components);
            this.resgata = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numResgate = new System.Windows.Forms.NumericUpDown();
            this.saldo_text = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addinvest = new System.Windows.Forms.Timer(this.components);
            this.invest_tudo = new System.Windows.Forms.Button();
            this.resgatarTudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResgate)).BeginInit();
            this.SuspendLayout();
            // 
            // numValor
            // 
            this.numValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValor.ForeColor = System.Drawing.Color.White;
            this.numValor.Location = new System.Drawing.Point(287, 474);
            this.numValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(158, 38);
            this.numValor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor a ser investido:";
            // 
            // invest
            // 
            this.invest.AutoSize = true;
            this.invest.Enabled = false;
            this.invest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.invest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invest.Location = new System.Drawing.Point(452, 470);
            this.invest.Name = "invest";
            this.invest.Size = new System.Drawing.Size(124, 41);
            this.invest.TabIndex = 9;
            this.invest.Text = "Investir";
            this.invest.UseVisualStyleBackColor = true;
            this.invest.Click += new System.EventHandler(this.invest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = " ";
            // 
            // escolha
            // 
            this.escolha.AutoSize = true;
            this.escolha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.escolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolha.Location = new System.Drawing.Point(26, 186);
            this.escolha.Name = "escolha";
            this.escolha.Size = new System.Drawing.Size(122, 41);
            this.escolha.TabIndex = 11;
            this.escolha.Text = "Escolher";
            this.escolha.UseVisualStyleBackColor = true;
            this.escolha.Click += new System.EventHandler(this.escolha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Escolha um investimento:";
            // 
            // investimentos
            // 
            this.investimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investimentos.FormattingEnabled = true;
            this.investimentos.ItemHeight = 26;
            this.investimentos.Items.AddRange(new object[] {
            "Tesouro prefixado (até 1min)",
            "Renda fixa (CDI 100%)",
            "Renda variável (0.01% - 30%)"});
            this.investimentos.Location = new System.Drawing.Point(26, 51);
            this.investimentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.investimentos.Name = "investimentos";
            this.investimentos.Size = new System.Drawing.Size(300, 108);
            this.investimentos.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(419, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Taxas atuais (% cada 5s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tesouro prefixado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(412, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Renda fixa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(364, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Renda variável:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valor atual investido:";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(282, 341);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(508, 32);
            this.total.TabIndex = 19;
            this.total.Text = "xx.x";
            // 
            // variavel_texto
            // 
            this.variavel_texto.AutoSize = true;
            this.variavel_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variavel_texto.ForeColor = System.Drawing.Color.White;
            this.variavel_texto.Location = new System.Drawing.Point(560, 136);
            this.variavel_texto.Name = "variavel_texto";
            this.variavel_texto.Size = new System.Drawing.Size(61, 31);
            this.variavel_texto.TabIndex = 22;
            this.variavel_texto.Text = "xx.x";
            // 
            // fixa_texto
            // 
            this.fixa_texto.AutoSize = true;
            this.fixa_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixa_texto.ForeColor = System.Drawing.Color.White;
            this.fixa_texto.Location = new System.Drawing.Point(560, 105);
            this.fixa_texto.Name = "fixa_texto";
            this.fixa_texto.Size = new System.Drawing.Size(61, 31);
            this.fixa_texto.TabIndex = 23;
            this.fixa_texto.Text = "xx.x";
            // 
            // prefixado_texto
            // 
            this.prefixado_texto.AutoSize = true;
            this.prefixado_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixado_texto.ForeColor = System.Drawing.Color.White;
            this.prefixado_texto.Location = new System.Drawing.Point(560, 73);
            this.prefixado_texto.Name = "prefixado_texto";
            this.prefixado_texto.Size = new System.Drawing.Size(61, 31);
            this.prefixado_texto.TabIndex = 24;
            this.prefixado_texto.Text = "xx.x";
            // 
            // prefix
            // 
            this.prefix.Enabled = true;
            this.prefix.Interval = 1000;
            this.prefix.Tick += new System.EventHandler(this.prefix_Tick);
            // 
            // variable
            // 
            this.variable.Enabled = true;
            this.variable.Interval = 20000;
            this.variable.Tick += new System.EventHandler(this.variable_Tick);
            // 
            // mudamudamuda
            // 
            this.mudamudamuda.Enabled = true;
            this.mudamudamuda.Tick += new System.EventHandler(this.mudamudamuda_Tick);
            // 
            // resgata
            // 
            this.resgata.AutoSize = true;
            this.resgata.Enabled = false;
            this.resgata.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resgata.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resgata.Location = new System.Drawing.Point(452, 422);
            this.resgata.Name = "resgata";
            this.resgata.Size = new System.Drawing.Size(124, 41);
            this.resgata.TabIndex = 27;
            this.resgata.Text = "Resgatar";
            this.resgata.UseVisualStyleBackColor = true;
            this.resgata.Click += new System.EventHandler(this.resgata_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(2, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Valor a ser resgatado:";
            // 
            // numResgate
            // 
            this.numResgate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.numResgate.DecimalPlaces = 2;
            this.numResgate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResgate.ForeColor = System.Drawing.Color.White;
            this.numResgate.Location = new System.Drawing.Point(288, 426);
            this.numResgate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numResgate.Name = "numResgate";
            this.numResgate.Size = new System.Drawing.Size(158, 38);
            this.numResgate.TabIndex = 25;
            // 
            // saldo_text
            // 
            this.saldo_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo_text.ForeColor = System.Drawing.Color.White;
            this.saldo_text.Location = new System.Drawing.Point(282, 384);
            this.saldo_text.Name = "saldo_text";
            this.saldo_text.Size = new System.Drawing.Size(508, 32);
            this.saldo_text.TabIndex = 29;
            this.saldo_text.Text = "xx.x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(117, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 31);
            this.label11.TabIndex = 28;
            this.label11.Text = "Saldo atual:";
            // 
            // addinvest
            // 
            this.addinvest.Enabled = true;
            this.addinvest.Interval = 5000;
            this.addinvest.Tick += new System.EventHandler(this.addinvest_Tick);
            // 
            // invest_tudo
            // 
            this.invest_tudo.AutoSize = true;
            this.invest_tudo.Enabled = false;
            this.invest_tudo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.invest_tudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invest_tudo.Location = new System.Drawing.Point(589, 470);
            this.invest_tudo.Name = "invest_tudo";
            this.invest_tudo.Size = new System.Drawing.Size(177, 41);
            this.invest_tudo.TabIndex = 30;
            this.invest_tudo.Text = "Investir tudo";
            this.invest_tudo.UseVisualStyleBackColor = true;
            this.invest_tudo.Click += new System.EventHandler(this.invest_tudo_Click);
            // 
            // resgatarTudo
            // 
            this.resgatarTudo.AutoSize = true;
            this.resgatarTudo.Enabled = false;
            this.resgatarTudo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resgatarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resgatarTudo.Location = new System.Drawing.Point(589, 422);
            this.resgatarTudo.Name = "resgatarTudo";
            this.resgatarTudo.Size = new System.Drawing.Size(177, 42);
            this.resgatarTudo.TabIndex = 31;
            this.resgatarTudo.Text = "Resgatar tudo";
            this.resgatarTudo.UseVisualStyleBackColor = true;
            this.resgatarTudo.Click += new System.EventHandler(this.resgatarTudo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.resgatarTudo);
            this.Controls.Add(this.invest_tudo);
            this.Controls.Add(this.saldo_text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resgata);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numResgate);
            this.Controls.Add(this.prefixado_texto);
            this.Controls.Add(this.fixa_texto);
            this.Controls.Add(this.variavel_texto);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.investimentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.escolha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numValor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Investimento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResgate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button invest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button escolha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox investimentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label variavel_texto;
        private System.Windows.Forms.Label fixa_texto;
        private System.Windows.Forms.Label prefixado_texto;
        private System.Windows.Forms.Timer prefix;
        private System.Windows.Forms.Timer variable;
        private System.Windows.Forms.Timer mudamudamuda;
        private System.Windows.Forms.Button resgata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numResgate;
        private System.Windows.Forms.Label saldo_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer addinvest;
        private System.Windows.Forms.Button invest_tudo;
        private System.Windows.Forms.Button resgatarTudo;
    }
}