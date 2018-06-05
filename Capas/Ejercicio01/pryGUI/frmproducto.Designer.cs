namespace pryGUI
{
    partial class frmproducto
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
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.btncargarproductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(28, 73);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(553, 369);
            this.dgvproductos.TabIndex = 0;
            // 
            // btncargarproductos
            // 
            this.btncargarproductos.Location = new System.Drawing.Point(506, 44);
            this.btncargarproductos.Name = "btncargarproductos";
            this.btncargarproductos.Size = new System.Drawing.Size(75, 23);
            this.btncargarproductos.TabIndex = 1;
            this.btncargarproductos.Text = "Cargar Productos";
            this.btncargarproductos.UseVisualStyleBackColor = true;
            this.btncargarproductos.Click += new System.EventHandler(this.btncargarproductos_Click);
            // 
            // frmproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 454);
            this.Controls.Add(this.btncargarproductos);
            this.Controls.Add(this.dgvproductos);
            this.Name = "frmproducto";
            this.Text = "frmproducto";
            this.Load += new System.EventHandler(this.frmproducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Button btncargarproductos;
    }
}