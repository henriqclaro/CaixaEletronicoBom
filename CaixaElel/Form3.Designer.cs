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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.girar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(61, 44);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(56, 71);
            this.num1.TabIndex = 0;
            this.num1.Text = "label1";
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(156, 44);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(56, 71);
            this.num2.TabIndex = 1;
            this.num2.Text = "label1";
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(262, 44);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(56, 71);
            this.num3.TabIndex = 2;
            this.num3.Text = "label1";
            // 
            // girar
            // 
            this.girar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girar.Location = new System.Drawing.Point(102, 130);
            this.girar.Name = "girar";
            this.girar.Size = new System.Drawing.Size(146, 86);
            this.girar.TabIndex = 3;
            this.girar.Text = "GIRAR!";
            this.girar.UseVisualStyleBackColor = true;
            this.girar.Click += new System.EventHandler(this.girar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.girar);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form3";
            this.Text = "Apostar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Button girar;
        private System.Windows.Forms.Timer timer1;
    }
}