namespace GUI
{
    partial class Estudiante_Cursos
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
            this.lblEstudianteLogeado = new System.Windows.Forms.Label();
            this.dtgvCursosInscriptos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvCursosDisponibles = new System.Windows.Forms.DataGridView();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCursosInscriptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCursosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstudianteLogeado
            // 
            this.lblEstudianteLogeado.AutoSize = true;
            this.lblEstudianteLogeado.Location = new System.Drawing.Point(733, 29);
            this.lblEstudianteLogeado.Name = "lblEstudianteLogeado";
            this.lblEstudianteLogeado.Size = new System.Drawing.Size(44, 16);
            this.lblEstudianteLogeado.TabIndex = 2;
            this.lblEstudianteLogeado.Text = "label1";
            // 
            // dtgvCursosInscriptos
            // 
            this.dtgvCursosInscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCursosInscriptos.Location = new System.Drawing.Point(12, 83);
            this.dtgvCursosInscriptos.Name = "dtgvCursosInscriptos";
            this.dtgvCursosInscriptos.RowHeadersWidth = 51;
            this.dtgvCursosInscriptos.RowTemplate.Height = 24;
            this.dtgvCursosInscriptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCursosInscriptos.Size = new System.Drawing.Size(423, 205);
            this.dtgvCursosInscriptos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cursos Inscriptos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cursos Disponibles";
            // 
            // dtgvCursosDisponibles
            // 
            this.dtgvCursosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCursosDisponibles.Location = new System.Drawing.Point(519, 83);
            this.dtgvCursosDisponibles.Name = "dtgvCursosDisponibles";
            this.dtgvCursosDisponibles.RowHeadersWidth = 51;
            this.dtgvCursosDisponibles.RowTemplate.Height = 24;
            this.dtgvCursosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCursosDisponibles.Size = new System.Drawing.Size(423, 205);
            this.dtgvCursosDisponibles.TabIndex = 7;
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.Location = new System.Drawing.Point(828, 337);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(113, 35);
            this.btnInscribirse.TabIndex = 8;
            this.btnInscribirse.Text = "Inscribirse";
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(830, 432);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 35);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Estudiante_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 532);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnInscribirse);
            this.Controls.Add(this.dtgvCursosDisponibles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvCursosInscriptos);
            this.Controls.Add(this.lblEstudianteLogeado);
            this.Name = "Estudiante_Cursos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCursosInscriptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCursosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEstudianteLogeado;
        private System.Windows.Forms.DataGridView dtgvCursosInscriptos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvCursosDisponibles;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.Button btnLogout;
    }
}

