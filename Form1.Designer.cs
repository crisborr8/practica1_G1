namespace Practica1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivicion = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(236, 23);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(176, 44);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(424, 23);
            this.btnResta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(182, 44);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(236, 79);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(176, 44);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.Text = "Multiplicación";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivicion
            // 
            this.btnDivicion.Location = new System.Drawing.Point(424, 79);
            this.btnDivicion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDivicion.Name = "btnDivicion";
            this.btnDivicion.Size = new System.Drawing.Size(182, 44);
            this.btnDivicion.TabIndex = 3;
            this.btnDivicion.Text = "División";
            this.btnDivicion.UseVisualStyleBackColor = true;
            this.btnDivicion.Click += new System.EventHandler(this.btnDivicion_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(24, 46);
            this.txtValor1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(196, 31);
            this.txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(618, 46);
            this.txtValor2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(196, 31);
            this.txtValor2.TabIndex = 5;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(24, 190);
            this.txtLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1040, 229);
            this.txtLog.TabIndex = 6;
            this.txtLog.Text = "";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(868, 46);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(196, 31);
            this.txtResultado.TabIndex = 7;
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(344, 135);
            this.btnPotencia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(150, 44);
            this.btnPotencia.TabIndex = 9;
            this.btnPotencia.Text = "Potencia";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1088, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btnDivicion);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Practica 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivicion;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Label label1;
    }
}

