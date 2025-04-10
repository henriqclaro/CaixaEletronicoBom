namespace CaixaElel
{
    partial class Form3
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
            this.girar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.acertos_label = new System.Windows.Forms.Label();
            this.resgata = new System.Windows.Forms.Button();
            this.aposta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.multiplier_text = new System.Windows.Forms.Label();
            this.numResgate = new System.Windows.Forms.NumericUpDown();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.resgTudo = new System.Windows.Forms.Button();
            this.aposTudo = new System.Windows.Forms.Button();
            this.atual = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.apostadoLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roletas = new System.Windows.Forms.NumericUpDown();
            this.multiplicador = new System.Windows.Forms.Timer(this.components);
            this.killAllButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sortRich = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbVitorias = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numResgate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roletas)).BeginInit();
            this.SuspendLayout();
            // 
            // girar
            // 
            this.girar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girar.Location = new System.Drawing.Point(10, 90);
            this.girar.Name = "girar";
            this.girar.Size = new System.Drawing.Size(156, 40);
            this.girar.TabIndex = 3;
            this.girar.Text = "GIRAR!";
            this.girar.UseVisualStyleBackColor = true;
            this.girar.Click += new System.EventHandler(this.girar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Acertos: Acertos: ";
            // 
            // acertos_label
            // 
            this.acertos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acertos_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acertos_label.Location = new System.Drawing.Point(110, 7);
            this.acertos_label.Name = "acertos_label";
            this.acertos_label.Size = new System.Drawing.Size(26, 24);
            this.acertos_label.TabIndex = 5;
            this.acertos_label.Text = "0";
            // 
            // resgata
            // 
            this.resgata.AutoSize = true;
            this.resgata.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resgata.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resgata.Location = new System.Drawing.Point(239, 337);
            this.resgata.Name = "resgata";
            this.resgata.Size = new System.Drawing.Size(124, 41);
            this.resgata.TabIndex = 29;
            this.resgata.Text = "Resgatar";
            this.resgata.UseVisualStyleBackColor = true;
            this.resgata.Click += new System.EventHandler(this.resgata_Click);
            // 
            // aposta
            // 
            this.aposta.AutoSize = true;
            this.aposta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aposta.Location = new System.Drawing.Point(239, 384);
            this.aposta.Name = "aposta";
            this.aposta.Size = new System.Drawing.Size(124, 41);
            this.aposta.TabIndex = 28;
            this.aposta.Text = "Apostar";
            this.aposta.UseVisualStyleBackColor = true;
            this.aposta.Click += new System.EventHandler(this.aposta_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(135, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "=>";
            // 
            // multiplier_text
            // 
            this.multiplier_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplier_text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplier_text.Location = new System.Drawing.Point(180, 7);
            this.multiplier_text.Name = "multiplier_text";
            this.multiplier_text.Size = new System.Drawing.Size(164, 40);
            this.multiplier_text.TabIndex = 31;
            this.multiplier_text.Text = "multiplicador";
            // 
            // numResgate
            // 
            this.numResgate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.numResgate.DecimalPlaces = 2;
            this.numResgate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResgate.ForeColor = System.Drawing.Color.White;
            this.numResgate.Location = new System.Drawing.Point(75, 337);
            this.numResgate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numResgate.Name = "numResgate";
            this.numResgate.Size = new System.Drawing.Size(158, 38);
            this.numResgate.TabIndex = 33;
            // 
            // numValor
            // 
            this.numValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValor.ForeColor = System.Drawing.Color.White;
            this.numValor.Location = new System.Drawing.Point(75, 387);
            this.numValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(158, 38);
            this.numValor.TabIndex = 32;
            // 
            // resgTudo
            // 
            this.resgTudo.AutoSize = true;
            this.resgTudo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resgTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resgTudo.Location = new System.Drawing.Point(22, 337);
            this.resgTudo.Name = "resgTudo";
            this.resgTudo.Size = new System.Drawing.Size(49, 38);
            this.resgTudo.TabIndex = 34;
            this.resgTudo.Text = "↓*";
            this.resgTudo.UseVisualStyleBackColor = true;
            this.resgTudo.Click += new System.EventHandler(this.resgTudo_Click);
            // 
            // aposTudo
            // 
            this.aposTudo.AutoSize = true;
            this.aposTudo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aposTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aposTudo.Location = new System.Drawing.Point(22, 387);
            this.aposTudo.Name = "aposTudo";
            this.aposTudo.Size = new System.Drawing.Size(49, 38);
            this.aposTudo.TabIndex = 35;
            this.aposTudo.Text = "↑*";
            this.aposTudo.UseVisualStyleBackColor = true;
            this.aposTudo.Click += new System.EventHandler(this.aposTudo_Click);
            // 
            // atual
            // 
            this.atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atual.ForeColor = System.Drawing.Color.White;
            this.atual.Location = new System.Drawing.Point(169, 305);
            this.atual.Name = "atual";
            this.atual.Size = new System.Drawing.Size(204, 32);
            this.atual.TabIndex = 39;
            this.atual.Text = "R$0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 31);
            this.label11.TabIndex = 38;
            this.label11.Text = "Saldo atual:";
            // 
            // apostadoLbl
            // 
            this.apostadoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apostadoLbl.ForeColor = System.Drawing.Color.White;
            this.apostadoLbl.Location = new System.Drawing.Point(169, 273);
            this.apostadoLbl.Name = "apostadoLbl";
            this.apostadoLbl.Size = new System.Drawing.Size(204, 32);
            this.apostadoLbl.TabIndex = 37;
            this.apostadoLbl.Text = "R$0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 31);
            this.label8.TabIndex = 36;
            this.label8.Text = "Apostado: ";
            // 
            // roletas
            // 
            this.roletas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.roletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roletas.ForeColor = System.Drawing.Color.White;
            this.roletas.Location = new System.Drawing.Point(38, 46);
            this.roletas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.roletas.Name = "roletas";
            this.roletas.Size = new System.Drawing.Size(98, 38);
            this.roletas.TabIndex = 40;
            // 
            // multiplicador
            // 
            this.multiplicador.Enabled = true;
            this.multiplicador.Tick += new System.EventHandler(this.multiplicador_Tick);
            // 
            // killAllButton
            // 
            this.killAllButton.Enabled = false;
            this.killAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killAllButton.Location = new System.Drawing.Point(10, 136);
            this.killAllButton.Name = "killAllButton";
            this.killAllButton.Size = new System.Drawing.Size(156, 40);
            this.killAllButton.TabIndex = 41;
            this.killAllButton.Text = "Reiniciar";
            this.killAllButton.UseVisualStyleBackColor = true;
            this.killAllButton.Click += new System.EventHandler(this.killAll_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(248, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 11);
            this.label3.TabIndex = 43;
            this.label3.Text = "*Taxa minima de resgate: 20%\r\n";
            // 
            // sortRich
            // 
            this.sortRich.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortRich.Location = new System.Drawing.Point(185, 80);
            this.sortRich.Name = "sortRich";
            this.sortRich.Size = new System.Drawing.Size(171, 96);
            this.sortRich.TabIndex = 44;
            this.sortRich.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(181, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Números sorteados";
            // 
            // chbVitorias
            // 
            this.chbVitorias.AutoSize = true;
            this.chbVitorias.Checked = true;
            this.chbVitorias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVitorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVitorias.ForeColor = System.Drawing.Color.Coral;
            this.chbVitorias.Location = new System.Drawing.Point(185, 201);
            this.chbVitorias.Name = "chbVitorias";
            this.chbVitorias.Size = new System.Drawing.Size(156, 28);
            this.chbVitorias.TabIndex = 46;
            this.chbVitorias.Text = "Apenas vitorias";
            this.chbVitorias.UseVisualStyleBackColor = true;
            this.chbVitorias.CheckedChanged += new System.EventHandler(this.chbVitorias_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.chbVitorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortRich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.killAllButton);
            this.Controls.Add(this.roletas);
            this.Controls.Add(this.atual);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.apostadoLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.aposTudo);
            this.Controls.Add(this.resgTudo);
            this.Controls.Add(this.numResgate);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.multiplier_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resgata);
            this.Controls.Add(this.aposta);
            this.Controls.Add(this.acertos_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girar);
            this.Name = "Form3";
            this.Text = "Apostar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numResgate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button girar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label acertos_label;
        private System.Windows.Forms.Button resgata;
        private System.Windows.Forms.Button aposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label multiplier_text;
        private System.Windows.Forms.NumericUpDown numResgate;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Button resgTudo;
        private System.Windows.Forms.Button aposTudo;
        private System.Windows.Forms.Label atual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label apostadoLbl;
        private System.Windows.Forms.NumericUpDown roletas;
        private System.Windows.Forms.Timer multiplicador;
        private System.Windows.Forms.Button killAllButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox sortRich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbVitorias;
    }
}