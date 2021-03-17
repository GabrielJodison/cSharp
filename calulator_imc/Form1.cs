using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calulator_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //declaracao de variavel

            double weight, height, imc;
            weight = Convert.ToDouble(txtWeight.Text);
            height = Convert.ToDouble(txtHeight.Text);
            imc = weight / (height * height);

            /* textboc recebe conteudo da variavel imc = resultado do calculo
             * definindo 2 casas decimais*/
            txtResult.Text = imc.ToString("0.00");

            //condicoes

            if (imc < 18.49)
                MessageBox.Show("Situacao: Voce esta abaixo do peso", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("Situacao: Voce esta com peso dentro da normalidade", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("Situacao: Voce esta com obesidade grau I", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("Situacao: Voce esta com obesidade grau II", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("Situacao: Voce esta com obesidade grau II", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtResult.Text = "";
            txtWeight.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
