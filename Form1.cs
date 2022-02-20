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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Código Suma
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Código Resta
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //Código Multiplicacion
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            //Código Divicion
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
}
