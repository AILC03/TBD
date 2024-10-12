namespace Evaluación_parcial_1__unidad_6_
{
    partial class VPrincipal
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
            this.B_REGRESAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_REGRESAR
            // 
            this.B_REGRESAR.Location = new System.Drawing.Point(184, 97);
            this.B_REGRESAR.Name = "B_REGRESAR";
            this.B_REGRESAR.Size = new System.Drawing.Size(75, 23);
            this.B_REGRESAR.TabIndex = 0;
            this.B_REGRESAR.Text = "Regresar";
            this.B_REGRESAR.UseVisualStyleBackColor = true;
            this.B_REGRESAR.Click += new System.EventHandler(this.B_REGRESAR_Click);
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_REGRESAR);
            this.Name = "VPrincipal";
            this.Text = "VPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_REGRESAR;
    }
}