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
    public partial class Form_de_inicio : Form
    {
        public Form_de_inicio()
        {
            InitializeComponent();
        }

  

        private void estudianteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form frmstd = new Estudiante_Cursos();
                frmstd.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
