using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperação
{
    public partial class quantPaes : Form
    {
        public quantPaes()
        {
            InitializeComponent();
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
           
            int quantPao = 0;
            int quantLeite = 0;
            double totalPao;
            double totalLeite;
            double valPao = 0.25;
            double valLitroLeite = 2.85;
            double contaCli;

            quantPao = Convert.ToInt16(txtPao.Text);
            quantLeite = Convert.ToInt16(txtLeite.Text);

            totalPao = quantPao * valPao;
            totalLeite = quantLeite * valLitroLeite;
            contaCli = totalLeite + totalPao;
            lblMensagem.Text = "Conta : Sua conta foi de " + contaCli+ "\n sendo que o total de leite foi de " +totalLeite+ " e o total dos pães foi de " +totalPao  ;

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLeite.Text = " ";
            txtPao.Text = " ";
            lblMensagem.Text = "Conta :";

        }
    }
}
