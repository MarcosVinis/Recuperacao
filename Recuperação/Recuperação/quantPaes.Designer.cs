namespace Recuperação
{
    partial class quantPaes
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
            this.lblPao = new System.Windows.Forms.Label();
            this.lblLeite = new System.Windows.Forms.Label();
            this.txtPao = new System.Windows.Forms.TextBox();
            this.txtLeite = new System.Windows.Forms.TextBox();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPao
            // 
            this.lblPao.AutoSize = true;
            this.lblPao.Location = new System.Drawing.Point(1, 28);
            this.lblPao.Name = "lblPao";
            this.lblPao.Size = new System.Drawing.Size(95, 13);
            this.lblPao.TabIndex = 0;
            this.lblPao.Text = "Quantide de Pães:";
            // 
            // lblLeite
            // 
            this.lblLeite.AutoSize = true;
            this.lblLeite.Location = new System.Drawing.Point(1, 86);
            this.lblLeite.Name = "lblLeite";
            this.lblLeite.Size = new System.Drawing.Size(106, 13);
            this.lblLeite.TabIndex = 1;
            this.lblLeite.Text = "Quantidade de Leite:";
            // 
            // txtPao
            // 
            this.txtPao.Location = new System.Drawing.Point(113, 28);
            this.txtPao.Name = "txtPao";
            this.txtPao.Size = new System.Drawing.Size(100, 20);
            this.txtPao.TabIndex = 2;
            // 
            // txtLeite
            // 
            this.txtLeite.Location = new System.Drawing.Point(113, 86);
            this.txtLeite.Name = "txtLeite";
            this.txtLeite.Size = new System.Drawing.Size(100, 20);
            this.txtLeite.TabIndex = 3;
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.Location = new System.Drawing.Point(113, 203);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(75, 23);
            this.btnCalcTotal.TabIndex = 4;
            this.btnCalcTotal.Text = "Total";
            this.btnCalcTotal.UseVisualStyleBackColor = true;
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 153);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(44, 13);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Conta : ";
            // 
            // quantPaes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.txtLeite);
            this.Controls.Add(this.txtPao);
            this.Controls.Add(this.lblLeite);
            this.Controls.Add(this.lblPao);
            this.Name = "quantPaes";
            this.Text = "quantPaes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPao;
        private System.Windows.Forms.Label lblLeite;
        private System.Windows.Forms.TextBox txtPao;
        private System.Windows.Forms.TextBox txtLeite;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.Label lblMensagem;
    }
}