namespace Evaluación_parcial_1__unidad_6_
{
    partial class REGISTRO
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
            this.BTN_REGIST = new System.Windows.Forms.Button();
            this.BTN_REGRESAR = new System.Windows.Forms.Button();
            this.TB_CORREO = new System.Windows.Forms.TextBox();
            this.TB_CONTRA = new System.Windows.Forms.TextBox();
            this.L_Alerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_REGIST
            // 
            this.BTN_REGIST.Location = new System.Drawing.Point(331, 290);
            this.BTN_REGIST.Name = "BTN_REGIST";
            this.BTN_REGIST.Size = new System.Drawing.Size(75, 23);
            this.BTN_REGIST.TabIndex = 0;
            this.BTN_REGIST.Text = "Registrarse";
            this.BTN_REGIST.UseVisualStyleBackColor = true;
            this.BTN_REGIST.Click += new System.EventHandler(this.BTN_REGIST_Click);
            // 
            // BTN_REGRESAR
            // 
            this.BTN_REGRESAR.Location = new System.Drawing.Point(48, 373);
            this.BTN_REGRESAR.Name = "BTN_REGRESAR";
            this.BTN_REGRESAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_REGRESAR.TabIndex = 1;
            this.BTN_REGRESAR.Text = "Regresar";
            this.BTN_REGRESAR.UseVisualStyleBackColor = true;
            this.BTN_REGRESAR.Click += new System.EventHandler(this.BTN_REGRESAR_Click);
            // 
            // TB_CORREO
            // 
            this.TB_CORREO.Location = new System.Drawing.Point(247, 103);
            this.TB_CORREO.Name = "TB_CORREO";
            this.TB_CORREO.Size = new System.Drawing.Size(203, 26);
            this.TB_CORREO.TabIndex = 2;
            // 
            // TB_CONTRA
            // 
            this.TB_CONTRA.Location = new System.Drawing.Point(221, 189);
            this.TB_CONTRA.Name = "TB_CONTRA";
            this.TB_CONTRA.Size = new System.Drawing.Size(251, 26);
            this.TB_CONTRA.TabIndex = 3;
            // 
            // L_Alerta
            // 
            this.L_Alerta.AutoSize = true;
            this.L_Alerta.Location = new System.Drawing.Point(327, 235);
            this.L_Alerta.Name = "L_Alerta";
            this.L_Alerta.Size = new System.Drawing.Size(51, 20);
            this.L_Alerta.TabIndex = 4;
            this.L_Alerta.Text = "label1";
            // 
            // REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_Alerta);
            this.Controls.Add(this.TB_CONTRA);
            this.Controls.Add(this.TB_CORREO);
            this.Controls.Add(this.BTN_REGRESAR);
            this.Controls.Add(this.BTN_REGIST);
            this.Name = "REGISTRO";
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.REGISTRO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_REGIST;
        private System.Windows.Forms.Button BTN_REGRESAR;
        private System.Windows.Forms.TextBox TB_CORREO;
        private System.Windows.Forms.TextBox TB_CONTRA;
        private System.Windows.Forms.Label L_Alerta;
    }
}