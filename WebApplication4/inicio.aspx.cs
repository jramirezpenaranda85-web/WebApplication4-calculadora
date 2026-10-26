
using System;
using System.Web.UI;

namespace WebApplication4
{
    public partial class inicio : System.Web.UI.Page
    {
        double num1 = 0;
        double num2 = 0;
        double resultado = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string calcular(int operacion)
        {
            if (operacion == 0)
            {
                resultado = num1 + num2;
            }
            else if (operacion == 1)
            {
                resultado = num1 - num2;
            }
            else if (operacion == 2)
            {
                resultado = num1 * num2;
            }
            else if (operacion == 3)
            {
                if (num2 == 0)
                {
                    return "No se puede dividir entre cero";
                }

                resultado = num1 / num2;
            }
            else if (operacion == 4)
            {
                resultado = Math.Pow(num1, 2);
            }
            else if (operacion == 5)
            {
                resultado = Math.Pow(num1, num2);
            }

            return resultado.ToString();
        }

        private void menudesplegable()
        {
            lresultado.Text = calcular(doperacion.SelectedIndex);
        }

        private void checkbox()
        {
            string resultados = "";

            if (csuma.Checked)
            {
                resultados += "Suma: " + calcular(0) + "; ";
            }

            if (cresta.Checked)
            {
                resultados += "Resta: " + calcular(1) + "; ";
            }

            if (cmultiplicacion.Checked)
            {
                resultados += "Multiplicacion: " + calcular(2) + "; ";
            }

            if (cdivision.Checked)
            {
                resultados += "Division: " + calcular(3) + "; ";
            }

            if (cpotencia.Checked)
            {
                resultados += "Potencia 2: " + calcular(4) + "; ";
            }

            if (cexponencial.Checked)
            {
                resultados += "Exponencial: " + calcular(5) + "; ";
            }

            lresultado.Text = resultados;
        }

        protected void bresultado_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tn1.Text, out num1) ||
                !double.TryParse(tn2.Text, out num2))
            {
                lresultado.Text = "Ingrese numeros validos";
                return;
            }

            if (csuma.Checked || cresta.Checked ||
                cmultiplicacion.Checked || cdivision.Checked ||
                cpotencia.Checked || cexponencial.Checked)
            {
                checkbox();
            }
            else
            {
                menudesplegable();
            }
        }
    }
}
