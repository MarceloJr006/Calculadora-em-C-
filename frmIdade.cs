using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_CSharp
{
    public partial class frmIdade : Form
    {
        public frmIdade()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string strNome;
            int intIdade;

            strNome = txtNome.Text;
            intIdade = int.Parse(txtIdade.Text);

            lblMostrar.Text = "O(A) " + strNome + " tem " + intIdade + " anos.";
        }
    }
}
