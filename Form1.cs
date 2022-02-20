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

        ws_calculadora.CalculatorSoapClient calcular = new ws_calculadora.CalculatorSoapClient();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Código Suma
            String operacion = "Suma ";
            if ((float.Parse(txtValor1.Text) % 1) == 0 && (float.Parse(txtValor2.Text) % 1) == 0)
            {
                operacion += "web:";
                txtResultado.Text = calcular.Add((int)float.Parse(txtValor1.Text), (int)float.Parse(txtValor2.Text)) + "";
            }
            else
            {
                operacion += "local:";
                s.setOperador1(float.Parse(txtValor1.Text));
                s.setOperador2(float.Parse(txtValor2.Text));
                txtResultado.Text = s.Operar() + "";
            }
            Bitacora log = new Bitacora(operacion, txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n" + log.getBitacora();
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            //Código Resta
            txtResultado.Text = calcular.Subtract(int.Parse(txtValor1.Text), int.Parse(txtValor2.Text)) + "";
            Bitacora log = new Bitacora("Resta", txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n" + log.getBitacora();
            /*r.setOperador1(float.Parse(txtValor1.Text));
            r.setOperador2(float.Parse(txtValor2.Text));
            txtResultado.Text = r.Operar() + "";*/

        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            ws_calculadora.CalculatorSoapClient calcular = new ws_calculadora.CalculatorSoapClient();
            txtResultado.Text = calcular.Multiply(int.Parse(txtValor1.Text), int.Parse(txtValor2.Text)) + "";
            Bitacora log = new Bitacora("Multiplicación", txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n"  + log.getBitacora();
            //Codigo multiplicacion
            /* m.setOperador1(float.Parse(txtValor1.Text));
             m.setOperador2(float.Parse(txtValor2.Text));
             txtResultado.Text = m.Operar() + "";*/
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            //Codigo divicion
            ws_calculadora.CalculatorSoapClient calcular = new ws_calculadora.CalculatorSoapClient();
            txtResultado.Text = calcular.Divide(int.Parse(txtValor1.Text), int.Parse(txtValor2.Text)) + "";
            Bitacora log = new Bitacora("Divicion", txtValor1.Text, txtValor2.Text, txtResultado.Text);
            txtLog.Text = txtLog.Text + "\n" + log.getBitacora();
            //d.setOperador1(float.Parse(txtValor1.Text));
            //d.setOperador2(float.Parse(txtValor2.Text));
            //txtResultado.Text = d.Operar() + "";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            //Código Potencia
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
            bitacora = "Operacion: " + this.operacion + ", Operando 1: " + this.operando1 + ", Operando 2: " + this.operando2 + ", Resultado: " + this.resultado + ", Fecha: " + DateTime.Now;
            return bitacora;
        }
    }

}
