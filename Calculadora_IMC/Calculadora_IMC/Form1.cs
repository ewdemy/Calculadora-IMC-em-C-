using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        double peso, altura, imc;
        string result;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            BoxPeso.Text = "Selecione seu Peso";
            BoxAltura.Text = "Selecione sua Altura";
            lbResultado.Text = "";
            lbResult.Text = "";
            pb1.Visible = true;
            pbBaixoPeso.Visible = false;
            pbNormal.Visible = false;
            pbSobrepeso.Visible = false;
            pbObesidade.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            peso = Convert.ToDouble(BoxPeso.Text);
            altura = Convert.ToDouble(BoxAltura.Text);
            imc = (peso * 100 * 100) / (altura * altura);
            lbResultado.Text = imc.ToString("##.##");

            if (imc < 18.5)
                {
                    lbResult.Text = ("BAIXO PESO");
                    pb1.Visible = false;
                    pbNormal.Visible = false;
                    pbSobrepeso.Visible = false;
                    pbObesidade.Visible = false;
                    pbBaixoPeso.Visible = true;
                }
            else
                if (imc >= 18.5 && imc < 25)
                    {
                        lbResult.Text = ("PESO ADEQUADO");
                        pb1.Visible = false;
                        pbBaixoPeso.Visible = false;
                        pbNormal.Visible = true;
                        pbSobrepeso.Visible = false;
                        pbObesidade.Visible = false;
                    }
                else
                    if (imc >= 25 && imc < 30)
                        {
                            lbResult.Text = ("SOBREPESO");
                            pb1.Visible = false;
                            pbBaixoPeso.Visible = false;
                            pbNormal.Visible = false;
                            pbSobrepeso.Visible = true;
                            pbObesidade.Visible = false;
                        }
                    else
                        { 
                            lbResult.Text = ("OBESIDADE");
                            pb1.Visible = false;
                            pbBaixoPeso.Visible = false;
                            pbNormal.Visible = false;
                            pbSobrepeso.Visible = false;
                            pbObesidade.Visible = true;

                        }
        }
    }
}
