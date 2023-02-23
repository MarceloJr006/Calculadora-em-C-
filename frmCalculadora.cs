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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intNumero1;
            int intNumero2;

            intNumero1 = Convert.ToInt16(txtNum1.Text);
            intNumero2 = Convert.ToInt16(txtNum2.Text);
            txtExpressao.Text = intNumero1 + " + " + intNumero2;
            txtResultado.Text = Convert.ToString(intNumero1 + intNumero2);
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            int intNumero1;
            int intNumero2;

            intNumero1 = Convert.ToInt16(txtNum1.Text);
            intNumero2 = Convert.ToInt16(txtNum2.Text);
            txtExpressao.Text = intNumero1 + " + " + intNumero2;
            txtResultado.Text = Convert.ToString(intNumero1 + intNumero2);
        }

        private void txtExpressao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            int intNumero1;
            int intNumero2;

            intNumero1 = Convert.ToInt16(txtNum1.Text);
            intNumero2 = Convert.ToInt16(txtNum2.Text);
            txtExpressao.Text = intNumero1 + " - " + intNumero2;
            txtResultado.Text = Convert.ToString(intNumero1 - intNumero2);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            int intNumero1;
            int intNumero2;

            intNumero1 = Convert.ToInt16(txtNum1.Text);
            intNumero2 = Convert.ToInt16(txtNum2.Text);
            txtExpressao.Text = intNumero1 + " * " + intNumero2;
            txtResultado.Text = Convert.ToString(intNumero1 * intNumero2);
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int intNumero1;
            int intNumero2;

            intNumero1 = Convert.ToInt16(txtNum1.Text);
            intNumero2 = Convert.ToInt16(txtNum2.Text);
            txtExpressao.Text = intNumero1 + " / " + intNumero2;
            txtResultado.Text = Convert.ToString(intNumero1 * intNumero2);
        }

        private void btnRestoDivisao_Click(object sender, EventArgs e)
        {
            int intNumero1;
            int intNumero2;

            intNumero1 = Convert.ToInt16(txtNum1.Text);
            intNumero2 = Convert.ToInt16(txtNum2.Text);
            txtExpressao.Text = intNumero1 + " % " + intNumero2;
            txtResultado.Text = Convert.ToString(intNumero1 % intNumero2);
            if (intNumero1 % intNumero2 == 0)
            {
                MessageBox.Show("O resto da divisão é igual a Zero!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtExpressao.Text = "";
            txtResultado.Text = "";
            txtNum1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
