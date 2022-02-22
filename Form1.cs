using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        Suma s = new Suma();
        Resta r = new Resta();
        Multiplicacion m = new Multiplicacion();
        Division d = new Division();
        Potencia p = new Potencia();

        ws_calculadora.CalculatorSoapClient calcular = new ws_calculadora.CalculatorSoapClient();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Código Suma
            String operacion = "Suma ";
            String operador1 = txtValor1.Text.Replace(".", ",");
            String operador2 = txtValor2.Text.Replace(".", ",");
            if ((float.Parse(operador1) % 1) == 0 && (float.Parse(operador2) % 1) == 0)
            {
                operacion += "web:";
                txtResultado.Text = calcular.Add((int)float.Parse(operador1), (int)float.Parse(operador2)) + "";
            }
            else
            {
                operacion += "local:";
                s.setOperador1(float.Parse(txtValor1.Text.Replace(".", ",")));
                s.setOperador2(float.Parse(txtValor2.Text.Replace(".", ",")));
                txtResultado.Text = s.Operar() + "";
            }
            Bitacora log = new Bitacora(operacion, txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n" + log.getBitacora() + ", Fecha: " + DateTime.Now;
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            //Código Resta
            String operacion = "Resta ";
            String operador1 = txtValor1.Text.Replace(".", ",");
            String operador2 = txtValor2.Text.Replace(".", ",");
            if ((float.Parse(operador1) % 1) == 0 && (float.Parse(operador2) % 1) == 0)
            {
                operacion += "web:";
                txtResultado.Text = calcular.Subtract((int)float.Parse(operador1), (int)float.Parse(operador2)) + "";
            }
            else
            {
                operacion += "local:";
                r.setOperador1(float.Parse(txtValor1.Text.Replace(".", ",")));
                r.setOperador2(float.Parse(txtValor2.Text.Replace(".", ",")));
                txtResultado.Text = r.Operar() + "";
            }            
            Bitacora log = new Bitacora(operacion, txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n" + log.getBitacora() + ", Fecha: " + DateTime.Now;

        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {

           //Codigo multiplicacion

            String operacion = "Multiplicación ";
            String operador1 = txtValor1.Text.Replace(".", ",");
            String operador2 = txtValor2.Text.Replace(".", ",");
            if ((float.Parse(operador1) % 1) == 0 && (float.Parse(operador2) % 1) == 0)
            {
                operacion += "web:";
                txtResultado.Text = calcular.Multiply((int)float.Parse(operador1), (int)float.Parse(operador2)) + "";
            }
            else
            {
                operacion += "local:";
                m.setOperador1(float.Parse(txtValor1.Text.Replace(".", ",")));
                m.setOperador2(float.Parse(txtValor2.Text.Replace(".", ",")));
                txtResultado.Text = m.Operar() + "";
            }
            Bitacora log = new Bitacora(operacion, txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n" + log.getBitacora() + ", Fecha: " + DateTime.Now;
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            //Codigo division
            String operacion = "Division ";
            String operador1 = txtValor1.Text.Replace(".", ",");
            String operador2 = txtValor2.Text.Replace(".",",");
            if ((float.Parse(operador1) % 1) == 0 && (float.Parse(operador2) % 1) == 0)
            {
                operacion += "web:";
                txtResultado.Text = calcular.Divide((int)float.Parse(operador1), (int)float.Parse(operador2)) + "";
            }
            else
            {
                operacion += "local:";
                d.setOperador1(float.Parse(txtValor1.Text.Replace(".", ",")));
                d.setOperador2(float.Parse(txtValor2.Text.Replace(".", ",")));
                txtResultado.Text = d.Operar() + "";
            }
            Bitacora log = new Bitacora(operacion, txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n" + log.getBitacora() + ", Fecha: " + DateTime.Now;
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            p.setOperador1(float.Parse(txtValor1.Text));
            p.setOperador2(float.Parse(txtValor2.Text));
            txtResultado.Text = p.Operar() + "";

            Bitacora log = new Bitacora("Potencia", txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n" + log.getBitacora();
        }

    }

    interface Operacion
    {
        float Operar();
        void setOperador1(float op1);
        void setOperador2(float op2);

    }
    public class Suma : Operacion
    {
        public float operador1;
        public float operador2;

        public float Operar()
        {
            return operador1 + operador2;
        }

        public void setOperador1(float op1)
        {
            operador1 = op1;
        }
        public void setOperador2(float op2)
        {
            operador2 = op2;
        }

    }

    public class Resta : Operacion
    {
        public float operador1;
        public float operador2;

        public float Operar()
        {
            return operador1 - operador2;
        }

        public void setOperador1(float op1)
        {
            operador1 = op1;
        }

        public void setOperador2(float op2)
        {
            operador2 = op2;
        }

    }

    public class Multiplicacion : Operacion
    {
        public float operador1;
        public float operador2;

        public float Operar()
        {
            return operador1 * operador2;
        }

        public void setOperador1(float op1)
        {
            operador1 = op1;
        }
        public void setOperador2(float op2)
        {
            operador2 = op2;
        }

    }
    public class Division : Operacion
    {
        public float operador1;
        public float operador2;

        public float Operar()
        {
            return operador1 / operador2;
        }

        public void setOperador1(float op1)
        {
            operador1 = op1;
        }
        public void setOperador2(float op2)
        {
            operador2 = op2;
        }

    }

    public class Potencia : Operacion
    {
        public float operador1;
        public float operador2;

        public float Operar()
        {
            return Convert.ToSingle(Math.Pow(operador1, operador2));
        }

        public void setOperador1(float op1)
        {
            operador1 = op1;
        }
        public void setOperador2(float op2)
        {
            operador2 = op2;
        }

    }

    public class Bitacora
    {
        public string operacion;
        public string operando1;
        public string operando2;
        public string resultado;

        public Bitacora(string operacion, string operando1, string operando2, string resultado)
        {
            this.operacion = operacion;
            this.operando1 = operando1;
            this.operando2 = operando2;
            this.resultado = resultado;
        }

        public string getBitacora()
        {
            string bitacora = "";
            bitacora = "Operacion: " + this.operacion + ", Operando 1: " + this.operando1 + ", Operando 2: " + this.operando2 + ", Resultado: " + this.resultado;
            return bitacora;
        }
    }

}
