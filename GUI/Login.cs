using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        public string Perfil { get; set; }

        BLLEstudiante bllEstudiante = new BLLEstudiante();
        BLLProfesor bLLProfesor = new BLLProfesor();
      


        private void chbUsuarioNoRegistrado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUsuarioNoRegistrado.Checked) 
            { 
              btnRegistrarUsuario.Visible = true;
            }
            else 
            {
              btnRegistrarUsuario.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == string.Empty)
                    throw new Exception("¡El campo Email tiene qué tener un valor!");

                if (txtPassword.Text == string.Empty)
                    throw new Exception("¡El campo Password tiene qué tener un valor!");

                bool Registrado = false;

                if (Perfil == "Estudiante")
                   Registrado = bllEstudiante.Registrado(txtEmail.Text, txtPassword.Text);

                if (Perfil == "Profesor")
                   Registrado = bLLProfesor.Registrado(txtEmail.Text, txtPassword.Text);



                if (!Registrado)
                    throw new Exception($"¡Usuario {txtEmail.Text}, no registrado!");



                this.Close();

                

                




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Registrar_Usuario frm = new Registrar_Usuario();

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
