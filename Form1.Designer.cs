
namespace Ejercicio1_Factorial_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Factorial";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(12, 61);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(51, 15);
            this.lb_numero.TabIndex = 1;
            this.lb_numero.Text = "Numero";
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(12, 105);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(59, 15);
            this.lb_resultado.TabIndex = 2;
            this.lb_resultado.Text = "Resultado";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(77, 58);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(177, 23);
            this.txt_numero.TabIndex = 3;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(77, 102);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(177, 23);
            this.txt_resultado.TabIndex = 4;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(12, 153);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(102, 28);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(152, 153);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(102, 28);
            this.btn_nuevo.TabIndex = 6;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 212);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_nuevo;
    }
}

