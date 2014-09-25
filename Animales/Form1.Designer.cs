namespace Animales
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnio = new System.Windows.Forms.TextBox();
            this.BtnEdad = new System.Windows.Forms.Button();
            this.LblEdad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNro_Huesos = new System.Windows.Forms.TextBox();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtId_Vendedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(143, 38);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año Nacimiento: ";
            // 
            // TxtAnio
            // 
            this.TxtAnio.Location = new System.Drawing.Point(143, 83);
            this.TxtAnio.Name = "TxtAnio";
            this.TxtAnio.Size = new System.Drawing.Size(100, 20);
            this.TxtAnio.TabIndex = 3;
            // 
            // BtnEdad
            // 
            this.BtnEdad.Location = new System.Drawing.Point(300, 56);
            this.BtnEdad.Name = "BtnEdad";
            this.BtnEdad.Size = new System.Drawing.Size(110, 23);
            this.BtnEdad.TabIndex = 4;
            this.BtnEdad.Text = "Calcular Edad";
            this.BtnEdad.UseVisualStyleBackColor = true;
            this.BtnEdad.Click += new System.EventHandler(this.BtnEdad_Click);
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(325, 199);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(35, 13);
            this.LblEdad.TabIndex = 5;
            this.LblEdad.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro. Huesos";
            // 
            // TxtNro_Huesos
            // 
            this.TxtNro_Huesos.Location = new System.Drawing.Point(143, 123);
            this.TxtNro_Huesos.Name = "TxtNro_Huesos";
            this.TxtNro_Huesos.Size = new System.Drawing.Size(100, 20);
            this.TxtNro_Huesos.TabIndex = 7;
            // 
            // CbxTipo
            // 
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "Vertebrado",
            "Invertebrado"});
            this.CbxTipo.Location = new System.Drawing.Point(300, 148);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(121, 21);
            this.CbxTipo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id. Venta : ";
            // 
            // TxtIdVenta
            // 
            this.TxtIdVenta.Location = new System.Drawing.Point(143, 192);
            this.TxtIdVenta.Name = "TxtIdVenta";
            this.TxtIdVenta.Size = new System.Drawing.Size(100, 20);
            this.TxtIdVenta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id. Vendedor : ";
            // 
            // TxtId_Vendedor
            // 
            this.TxtId_Vendedor.Location = new System.Drawing.Point(143, 239);
            this.TxtId_Vendedor.Name = "TxtId_Vendedor";
            this.TxtId_Vendedor.Size = new System.Drawing.Size(100, 20);
            this.TxtId_Vendedor.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 393);
            this.Controls.Add(this.TxtId_Vendedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIdVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.TxtNro_Huesos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.BtnEdad);
            this.Controls.Add(this.TxtAnio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAnio;
        private System.Windows.Forms.Button BtnEdad;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNro_Huesos;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtId_Vendedor;
    }
}

