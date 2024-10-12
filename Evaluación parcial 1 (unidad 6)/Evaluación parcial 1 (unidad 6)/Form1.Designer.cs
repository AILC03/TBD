namespace Evaluación_parcial_1__unidad_6_
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
            this.BTN_REG = new System.Windows.Forms.Button();
            this.TB_CORREO = new System.Windows.Forms.TextBox();
            this.TB_CONTRA = new System.Windows.Forms.TextBox();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.L_alerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_REG
            // 
            this.BTN_REG.Location = new System.Drawing.Point(603, 48);
            this.BTN_REG.Name = "BTN_REG";
            this.BTN_REG.Size = new System.Drawing.Size(75, 23);
            this.BTN_REG.TabIndex = 0;
            this.BTN_REG.Text = "Registrarse";
            this.BTN_REG.UseVisualStyleBackColor = true;
            this.BTN_REG.Click += new System.EventHandler(this.BTN_REG_Click);
            // 
            // TB_CORREO
            // 
            this.TB_CORREO.Location = new System.Drawing.Point(260, 105);
            this.TB_CORREO.Name = "TB_CORREO";
            this.TB_CORREO.Size = new System.Drawing.Size(100, 26);
            this.TB_CORREO.TabIndex = 1;
            // 
            // TB_CONTRA
            // 
            this.TB_CONTRA.Location = new System.Drawing.Point(260, 177);
            this.TB_CONTRA.Name = "TB_CONTRA";
            this.TB_CONTRA.Size = new System.Drawing.Size(100, 26);
            this.TB_CONTRA.TabIndex = 2;
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(298, 305);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INGRESAR.TabIndex = 3;
            this.BTN_INGRESAR.Text = "Iniciar sesion";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // L_alerta
            // 
            this.L_alerta.AutoSize = true;
            this.L_alerta.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.L_alerta.Location = new System.Drawing.Point(289, 249);
            this.L_alerta.Name = "L_alerta";
            this.L_alerta.Size = new System.Drawing.Size(51, 20);
            this.L_alerta.TabIndex = 4;
            this.L_alerta.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_alerta);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.TB_CONTRA);
            this.Controls.Add(this.TB_CORREO);
            this.Controls.Add(this.BTN_REG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_REG;
        private System.Windows.Forms.TextBox TB_CORREO;
        private System.Windows.Forms.TextBox TB_CONTRA;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.Label L_alerta;
    }
}

