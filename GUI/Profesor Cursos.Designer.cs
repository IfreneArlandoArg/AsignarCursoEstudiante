namespace GUI
{
    partial class Profesor_Cursos
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
            this.lblProfesorLogueado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProfesorLogueado
            // 
            this.lblProfesorLogueado.AutoSize = true;
            this.lblProfesorLogueado.Location = new System.Drawing.Point(539, 32);
            this.lblProfesorLogueado.Name = "lblProfesorLogueado";
            this.lblProfesorLogueado.Size = new System.Drawing.Size(44, 16);
            this.lblProfesorLogueado.TabIndex = 3;
            this.lblProfesorLogueado.Text = "label1";
            // 
            // Profesor_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProfesorLogueado);
            this.Name = "Profesor_Cursos";
            this.Text = "Profesor_Cursos";
            this.Load += new System.EventHandler(this.Profesor_Cursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesorLogueado;
    }
}