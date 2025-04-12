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
using BE;

namespace GUI
{
    public partial class Registrar_Usuario : Form
    {
        public Registrar_Usuario()
        {
            InitializeComponent();
        }

        BLLEstudiante bLLEstudiante = new BLLEstudiante();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty)
                    throw new Exception("¡El campo Nombre tiene qué tener un valor!");

                if (txtApellido.Text == string.Empty)
                    throw new Exception("¡El campo Apellido tiene qué tener un valor!");
                if (txtEmail.Text == string.Empty)
                    throw new Exception("¡El campo Email tiene qué tener un valor!");

                if (txtPassword.Text == string.Empty)
                    throw new Exception("¡El campo Password tiene qué tener un valor!");

                BEEstudiante tmp = new BEEstudiante(txtNombre.Text, txtApellido.Text, txtEmail.Text, txtPassword.Text);

                bLLEstudiante.Alta(tmp);

                MessageBox.Show($"¡Usuario {tmp.Apellido}, {tmp.Nombre} registrado con exito!");
                this.Close();

            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
