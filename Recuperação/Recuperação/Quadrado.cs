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
    public partial class Quadrado : Form
    {
        public Quadrado()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLado.Text = "";
            lblArea.Text = "Area do quadrado";
        }

        private void Quadrado_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ladoQuad;
            double areaResult;

            ladoQuad = Convert.ToDouble(txtLado.Text);
       
            areaResult = ladoQuad * ladoQuad;

            lblArea.Text = " Area do quadrado é igual a " + areaResult;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
