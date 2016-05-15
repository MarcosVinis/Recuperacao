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
    public partial class calcReajuste : Form
    {
        public calcReajuste()
        {
            InitializeComponent();
        }

        private void calcReajuste_Load(object sender, EventArgs e)
        {

        }

        private void btnReajuste_Click(object sender, EventArgs e)
        {
            double resultSalTotal = 0;
            double salMensal = 0;
            double bonus = 299.99;

            salMensal = Convert.ToDouble(txtSalario.Text);

            resultSalTotal = (salMensal + bonus) * 6;
            lblMensagem.Text= " O seu salario total em 6 meses com Bonus será de " + resultSalTotal;

        }
    }
}
