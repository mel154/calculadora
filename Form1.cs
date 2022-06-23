using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DECLARACION DE VARIABLES
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;
        private double Memoria = 0;



        //BOTONES NUMEROS

        //boton 0
        private void btn0_Click(object sender, EventArgs e)
        {   
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        //boton 1
        private void btn1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        //boton 2
        private void btn2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        //boton 3
        private void btn3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        //boton 4
        private void btn4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        //boton 5
        private void btn5_Click(object sender, EventArgs e)
        {   
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        //boton6
        private void btn6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        //boton 7
        private void btn7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "7";
        }


        //boton 8
        private void btn8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        //boton 9
        private void btn9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }


        //BOTONES BORRAR TODO, BORRAR, RETROCEDER, SIGNO, DECIMAL

        //boton borrar todo
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            operacion = '\0';
            tbDisplay.Text = "0";
        }


        //boton borrar
        private void btnCE_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "0";     
        }

        //boton retroceder
        private void btnRe_Click(object sender, EventArgs e)
        {
            if (tbDisplay.TextLength > 1)
            {
                tbDisplay.Text = tbDisplay.Text.Substring(0, tbDisplay.Text.Length - 1);
            }
            else 
            {
                tbDisplay.Text = "0";
            }
        }

        //boton signo
        private void btnSigno_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = Convert.ToString(0 - Convert.ToDouble(tbDisplay.Text));
        }

        //boton decimal
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Contains(",")) { }
            else
            {
                tbDisplay.Text = tbDisplay.Text + ",";
            }
        }


                    //BOTONES MEMORIA
        //boton MC
        private void btnMC_Click(object sender, EventArgs e)
        {
            Memoria = 0;
        }

        //boton MR
        private void btnMR_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = Memoria.ToString();
        }

        //boton MS
        private void btnMS_Click(object sender, EventArgs e)
        {
            Memoria = Convert.ToDouble(tbDisplay.Text);
        }

        //boton M+
        private void btnMmas_Click(object sender, EventArgs e)
        {
            Memoria = Memoria + Convert.ToDouble(tbDisplay.Text);
        }

        //boton M-
        private void btnMmenos_Click(object sender, EventArgs e)
        {
            Memoria = Memoria - Convert.ToDouble(tbDisplay.Text);           
        }


                    //BOTONES OPERACIONES
        //boton suma
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Clear();
        }

        //boton resta
        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Clear();
        }

        //boton multiplicacion
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Clear();
        }

        //boton division
        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Clear();
        }


        //boton igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(tbDisplay.Text);
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    tbDisplay.Text = resultado.ToString();
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    tbDisplay.Text = resultado.ToString();
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    tbDisplay.Text = resultado.ToString();
                    break;
                case 4:
                    if (valor2 == 0)
                    {
                        tbDisplay.Text = "Error";
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                        tbDisplay.Text = resultado.ToString();                       
                    }
                    break;
            }   
        }

        //boton raiz
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            if (valor1 >= 0)
            {
                tbDisplay.Text = Math.Sqrt(valor1).ToString();
            }
            else
            {
                tbDisplay.Text = "Error";
            }
        }

        //boton potencia
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Math.Pow(valor1, 2).ToString();
        }

        //boton porcentaje
        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(valor1 / 100);
        }

        //boton logaritmo
        private void btnLog_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            if (valor1 >= 1)
            {
                tbDisplay.Text = Convert.ToString(Math.Log10(valor1));
            }
            else
            {
                tbDisplay.Text = "Error";
            }
        }

        //boton logaritmo natural
        private void btnLn_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            if (valor1 >= 1)
            {
                tbDisplay.Text = Convert.ToString(Math.Log(valor1));
            }
            else
            {
                tbDisplay.Text = "Error";
            }
        }

        //boton 1/x
        private void btn1x_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(1 / valor1);
        }

        //boton 10 a la x
        private void btnDiezelevado_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(Math.Pow(10, valor1));
        }

        //boton exp
        private void btnExp_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(Math.Exp(valor1));
        }

        //boton factorial
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int a = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            for (int i = 1; i <= valor1; i++)
            {
                a = a * i;
            }
            tbDisplay.Text = Convert.ToString(a);
        }


                        // BOTONES E, PI
        //boton pi                  
        private void btnPi_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = Math.PI.ToString();
        }

        //boton e
        private void btnE_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = Math.E.ToString();
        }


                    //BOTONES FUNCIONES TRIGONOMETRICAS
        //boton sin
        private void btnSin_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(Math.Sin(valor1));
        }

        //boton cos
        private void btnCos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(Math.Cos(valor1));
        }

        //boton tan
        private void btnTan_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(Math.Tan(valor1));
        }

        //boton Asin
        private void btnAsin_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(Math.Asin(valor1));
        }

        //boton Acos
        private void btnAcos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(Math.Acos(valor1));           
        }

        //boton Atan
        private void btnAtan_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = Convert.ToString(Math.Atan(valor1));
        }       
    }
}