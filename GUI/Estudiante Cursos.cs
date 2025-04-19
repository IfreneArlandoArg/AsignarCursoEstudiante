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
using BLL;

namespace GUI
{
    public partial class Estudiante_Cursos : Form
    {
        public Estudiante_Cursos()
        {
            InitializeComponent();
        }

        BLLCurso bllcurso = new BLLCurso();
        BLLEstudiante bLLEstudiante  = new BLLEstudiante();

        

        void mostrarDTGV(DataGridView dtgv, object pO) 
        { 
           dtgv.DataSource = null;
           dtgv.DataSource = pO;
        }

        void mostrarDTGVCursosInscriptos(BEEstudiante pE) 
        {
            mostrarDTGV(dtgvCursosInscriptos, bLLEstudiante.ListarCursos(pE));
        }

        void mostrarDTGVCursosDisponibles() 
        {
            mostrarDTGV(dtgvCursosDisponibles, bllcurso.Listar());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Login frm = new Login();
                frm.ShowDialog();

                if (!LoginSession.Instancia.EstaLogueado())
                {
                    MessageBox.Show("¡Sesión no iniciada!");
                    this.Close();
                    return;
                }

                BEEstudiante estudianteLogeado = LoginSession.Instancia.UsuarioActual as BEEstudiante;

                MessageBox.Show($"¡Bienvenido {estudianteLogeado.Apellido}, {estudianteLogeado.Nombre}!");
                lblEstudianteLogeado.Text = $"Sesión : {estudianteLogeado.Apellido}, {estudianteLogeado.Nombre}";

                mostrarDTGVCursosInscriptos(estudianteLogeado);
                mostrarDTGVCursosDisponibles();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            try
            {
                var estudiante = LoginSession.Instancia.UsuarioActual as BEEstudiante;

                if (dtgvCursosDisponibles.SelectedRows.Count == 0)
                    throw new Exception("¡Para inscribirse, seleccioné uno de los cursos disponibles!");

                BECurso tmpCurso = dtgvCursosDisponibles.CurrentRow.DataBoundItem as BECurso;

                if(!bLLEstudiante.Inscripto(estudiante, tmpCurso))
                    throw new Exception($"El estudiante {estudiante.Apellido}, {estudiante.Nombre} ya está inscrito en el curso : {tmpCurso.Titulo}");

                bLLEstudiante.AltaCurso(estudiante,tmpCurso);
                mostrarDTGVCursosInscriptos(estudiante);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                LoginSession.Instancia.Logout(); 
                MessageBox.Show("Sesión cerrada.");
                

                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
