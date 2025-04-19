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
    public partial class Profesor_Cursos : Form
    {
        public Profesor_Cursos()
        {
            InitializeComponent();
        }

        private void Profesor_Cursos_Load(object sender, EventArgs e)
        {
            try
            {
                lblProfesorLogueado.Text = $"Sessión : {LoginSession.Instancia.UsuarioActual.Apellido}, {LoginSession.Instancia.UsuarioActual.Apellido}";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
