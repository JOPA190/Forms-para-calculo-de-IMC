using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImcForms_22_2i {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void txPeso_TextChanged(object sender, EventArgs e) 
        {

        }

        private void btResultado_Click(object sender, EventArgs e) 
        {
            try {
                double a, b, resultado,imc;
                a = double.Parse(txPeso.Text);
                b = double.Parse(txAltura.Text);
                imc = a / (Math.Pow(b, 2));
                resultado = imc;

                lbResultado.Text = resultado.ToString("F");

                if (imc > 40.0) {
                    lbCategoria.Text = "Obeso(a) Grau III (Mórbida)"; }

                else if (imc >= 35.0) {
                    lbCategoria.Text= "Obeso(a) Grau III (Severa)";
                }
                else if (imc >= 30.0) {
                    lbCategoria.Text = "Obeso(a) Grau II (Severa)";
                }
                else if (imc >= 25.0) {
                    lbCategoria.Text="Acima do Peso Ideal - Sobrepeso";
                }
                else if (imc >= 18.5) {
                    lbCategoria.Text= "Saudável - Peso Ideal (Normal)";
                }
                else if (imc >= 17.0) {
                    lbCategoria.Text= "Abaixo do Peso (Magreza leve)";
                }
                else if (imc >= 16.0) {
                    lbCategoria.Text = "Abaixo do Peso (Magreza Moderada)";
                }
                else {
                    lbCategoria.Text = "magreza grave";

                }

            }
            catch (Exception exErro) {
                MessageBox.Show("Erro: " + exErro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            txAltura.Clear();
            txPeso.Clear();
            lbResultado.Text = "0";
            lbCategoria.Text = ".";
            txPeso.Focus();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void lbCategoria_Click(object sender, EventArgs e) 
        {

        }
    }
}
