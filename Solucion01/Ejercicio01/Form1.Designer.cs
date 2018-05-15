namespace Ejercicio01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiagonal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Figura Rectangular";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(111, 85);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Largo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ancho";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(347, 85);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 3;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(111, 210);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(100, 20);
            this.txtParametro.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Perimetro";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(111, 236);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area";
            // 
            // txtDiagonal
            // 
            this.txtDiagonal.Location = new System.Drawing.Point(111, 262);
            this.txtDiagonal.Name = "txtDiagonal";
            this.txtDiagonal.Size = new System.Drawing.Size(100, 20);
            this.txtDiagonal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Diagonal";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(89, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(284, 43);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 318);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiagonal);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiagonal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
    }
}

