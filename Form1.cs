﻿using System;
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


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Código Suma
            //Codigo Suma
            s.setOperador1(float.Parse(txtValor1.Text));
            s.setOperador2(float.Parse(txtValor2.Text));
            txtResultado.Text = s.Operar() + "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Código Resta
            r.setOperador1(float.Parse(txtValor1.Text));
            r.setOperador2(float.Parse(txtValor2.Text));
            txtResultado.Text = r.Operar() + "";

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //Codigo multiplicacion
            m.setOperador1(float.Parse(txtValor1.Text));
            m.setOperador2(float.Parse(txtValor2.Text));
            txtResultado.Text = m.Operar() + "";
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

}
