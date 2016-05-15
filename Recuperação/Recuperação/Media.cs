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
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double N1;
            Double N2;
            Double N3;
            Double N4;
            Double N5;
            Double N6;
            Double N7;
            Double N8;
            Double Media;

            N1 = Convert.ToDouble(txtN1.Text);
            N2 = Convert.ToDouble(txtN2.Text);
            N3 = Convert.ToDouble(txtN3.Text);
            N4 = Convert.ToDouble(txtN4.Text);
            N5 = Convert.ToDouble(txtN5.Text);
            N6 = Convert.ToDouble(txtN6.Text);
            N7 = Convert.ToDouble(txtN7.Text);
            N8 = Convert.ToDouble(txtN8.Text);

            Media = (N1 + N2 + N3 + N4 + N5 + N6 + N7 + N8) / 8;

            MessageBox.Show("Sua média é de " + Media.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
            txtN5.Text = "";
            txtN6.Text = "";
            txtN7.Text = "";
            txtN8.Text = "";
                    }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
