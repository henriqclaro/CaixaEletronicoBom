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
            this.label10 = new System.Windows.Forms.Label();
            this.rendimento = new System.Windows.Forms.Label();
            this.variavel_texto = new System.Windows.Forms.Label();
            this.fixa_texto = new System.Windows.Forms.Label();
            this.prefixado_texto = new System.Windows.Forms.Label();
            this.tick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // numValor
            // 
            this.numValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValor.ForeColor = System.Drawing.Color.White;
            this.numValor.Location = new System.Drawing.Point(383, 462);
            this.numValor.Margin = new System.Windows.Forms.Padding(4);
            this.numValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(211, 45);
            this.numValor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor a ser investido:";
            // 
            // invest
            // 
            this.invest.AutoSize = true;
            this.invest.Enabled = false;
            this.invest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.invest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invest.Location = new System.Drawing.Point(602, 457);
            this.invest.Margin = new System.Windows.Forms.Padding(4);
            this.invest.Name = "invest";
            this.invest.Size = new System.Drawing.Size(137, 50);
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
            this.label2.Location = new System.Drawing.Point(27, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = " ";
            // 
            // escolha
            // 
            this.escolha.AutoSize = true;
            this.escolha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.escolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolha.Location = new System.Drawing.Point(34, 229);
            this.escolha.Margin = new System.Windows.Forms.Padding(4);
            this.escolha.Name = "escolha";
            this.escolha.Size = new System.Drawing.Size(146, 50);
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
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Escolha um investimento:";
            // 
            // investimentos
            // 
            this.investimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investimentos.FormattingEnabled = true;
            this.investimentos.ItemHeight = 31;
            this.investimentos.Items.AddRange(new object[] {
            "Tesouro prefixado (até 1min)",
            "Renda fixa (CDI 100%)",
            "Renda variável (0.01% - 30%)"});
            this.investimentos.Location = new System.Drawing.Point(34, 63);
            this.investimentos.Name = "investimentos";
            this.investimentos.Size = new System.Drawing.Size(398, 159);
            this.investimentos.TabIndex = 13;
            this.investimentos.SelectedIndexChanged += new System.EventHandler(this.investimentos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(559, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "Taxas atuais (% cada 5s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(439, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 39);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tesouro prefixado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(550, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 39);
            this.label6.TabIndex = 16;
            this.label6.Text = "Renda fixa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(485, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 39);
            this.label7.TabIndex = 17;
            this.label7.Text = "Renda variável:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 391);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(333, 39);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valor atual investido:";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(376, 391);
            this.total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(363, 39);
            this.total.TabIndex = 19;
            this.total.Text = "xx.x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(134, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 39);
            this.label10.TabIndex = 20;
            this.label10.Text = "Rendimento: ";
            // 
            // rendimento
            // 
            this.rendimento.AutoSize = true;
            this.rendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendimento.ForeColor = System.Drawing.Color.White;
            this.rendimento.Location = new System.Drawing.Point(376, 338);
            this.rendimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rendimento.Name = "rendimento";
            this.rendimento.Size = new System.Drawing.Size(108, 39);
            this.rendimento.TabIndex = 21;
            this.rendimento.Text = "+-xx.x";
            // 
            // variavel_texto
            // 
            this.variavel_texto.AutoSize = true;
            this.variavel_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variavel_texto.ForeColor = System.Drawing.Color.White;
            this.variavel_texto.Location = new System.Drawing.Point(747, 168);
            this.variavel_texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.variavel_texto.Name = "variavel_texto";
            this.variavel_texto.Size = new System.Drawing.Size(77, 39);
            this.variavel_texto.TabIndex = 22;
            this.variavel_texto.Text = "xx.x";
            // 
            // fixa_texto
            // 
            this.fixa_texto.AutoSize = true;
            this.fixa_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixa_texto.ForeColor = System.Drawing.Color.White;
            this.fixa_texto.Location = new System.Drawing.Point(747, 129);
            this.fixa_texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fixa_texto.Name = "fixa_texto";
            this.fixa_texto.Size = new System.Drawing.Size(77, 39);
            this.fixa_texto.TabIndex = 23;
            this.fixa_texto.Text = "xx.x";
            // 
            // prefixado_texto
            // 
            this.prefixado_texto.AutoSize = true;
            this.prefixado_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixado_texto.ForeColor = System.Drawing.Color.White;
            this.prefixado_texto.Location = new System.Drawing.Point(747, 90);
            this.prefixado_texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prefixado_texto.Name = "prefixado_texto";
            this.prefixado_texto.Size = new System.Drawing.Size(77, 39);
            this.prefixado_texto.TabIndex = 24;
            this.prefixado_texto.Text = "xx.x";
            // 
            // tick
            // 
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.prefixado_texto);
            this.Controls.Add(this.fixa_texto);
            this.Controls.Add(this.variavel_texto);
            this.Controls.Add(this.rendimento);
            this.Controls.Add(this.label10);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Investimento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label rendimento;
        private System.Windows.Forms.Label variavel_texto;
        private System.Windows.Forms.Label fixa_texto;
        private System.Windows.Forms.Label prefixado_texto;
        private System.Windows.Forms.Timer tick;
    }
}