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
    public partial class frmSaudacao : Form
    {
        public frmSaudacao()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja Bem Vindo(a) " + txtNome.Text);
        }
    }
}
