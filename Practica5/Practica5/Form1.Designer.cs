namespace Practica5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Resultado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btndivision);
            this.panel1.Controls.Add(this.btnmulti);
            this.panel1.Controls.Add(this.btnsuma);
            this.panel1.Controls.Add(this.btnresta);
            this.panel1.Controls.Add(this.numero1);
            this.panel1.Controls.Add(this.numero2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 152);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(127, 71);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(59, 20);
            this.numero2.TabIndex = 2;
            this.numero2.TextChanged += new System.EventHandler(this.numero2_TextChanged);
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(127, 12);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(59, 20);
            this.numero1.TabIndex = 3;
            this.numero1.TextChanged += new System.EventHandler(this.numero1_TextChanged);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(364, 19);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 23);
            this.btnresta.TabIndex = 4;
            this.btnresta.Text = "resta";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(254, 19);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 5;
            this.btnsuma.Text = "suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(254, 68);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(75, 23);
            this.btnmulti.TabIndex = 6;
            this.btnmulti.Text = "multiplicar";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(364, 69);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(75, 23);
            this.btndivision.TabIndex = 7;
            this.btndivision.Text = "division";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(127, 123);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(100, 20);
            this.Resultado.TabIndex = 9;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 155);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

