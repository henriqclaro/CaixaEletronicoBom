namespace CaixaElel
{
    partial class ApostaResult
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
            this.num3 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num3.Location = new System.Drawing.Point(232, 31);
            this.num3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 87);
            this.num3.TabIndex = 5;
            this.num3.Text = "label1";
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num2.Location = new System.Drawing.Point(132, 31);
            this.num2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 87);
            this.num2.TabIndex = 4;
            this.num2.Text = "label1";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.num1.Location = new System.Drawing.Point(36, 31);
            this.num1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 87);
            this.num1.TabIndex = 3;
            this.num1.Text = "label1";
            // 
            // ApostaResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(350, 191);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "ApostaResult";
            this.Text = "ApostaResult";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApostaResult_FormClosed);
            this.Load += new System.EventHandler(this.ApostaResult_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num1;
    }
}