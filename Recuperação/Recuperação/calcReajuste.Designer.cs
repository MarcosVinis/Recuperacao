namespace Recuperação
{
    partial class calcReajuste
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnReajuste = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(100, 27);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(129, 20);
            this.txtSalario.TabIndex = 0;
            // 
            // btnReajuste
            // 
            this.btnReajuste.Location = new System.Drawing.Point(131, 132);
            this.btnReajuste.Name = "btnReajuste";
            this.btnReajuste.Size = new System.Drawing.Size(75, 23);
            this.btnReajuste.TabIndex = 1;
            this.btnReajuste.Text = "Reajuste";
            this.btnReajuste.UseVisualStyleBackColor = true;
            this.btnReajuste.Click += new System.EventHandler(this.btnReajuste_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 80);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 2;
            // 
            // calcReajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 167);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnReajuste);
            this.Controls.Add(this.txtSalario);
            this.Name = "calcReajuste";
            this.Text = "Cálculo de Reajuste";
            this.Load += new System.EventHandler(this.calcReajuste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnReajuste;
        private System.Windows.Forms.Label lblMensagem;
    }
}

