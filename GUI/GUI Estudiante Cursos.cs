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

        public BEEstudiante EstudianteLogeado { get; set; }

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


                if (!frm.EstudianteRegistrado) 
                { 
                    MessageBox.Show("¡Sessión No inicida!");
                    this.Close();
                }

                EstudianteLogeado = frm.EstudianteLogeado;

                MessageBox.Show($"¡Bienvenido {EstudianteLogeado.Apellido}, {EstudianteLogeado.Nombre}!");

                lblEstudianteLogeado.Text = $"Sessión : {EstudianteLogeado.Apellido}, {EstudianteLogeado.Nombre}";

                mostrarDTGVCursosInscriptos(EstudianteLogeado);
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
                if (dtgvCursosDisponibles.SelectedRows.Count == 0)
                    throw new Exception("¡Para inscribirse, seleccioné uno de los cursos disponibles!");

                BECurso tmpCurso = dtgvCursosDisponibles.CurrentRow.DataBoundItem as BECurso;

                if(!bLLEstudiante.Inscripto(EstudianteLogeado, tmpCurso))
                    throw new Exception($"El estudiante {EstudianteLogeado.Apellido}, {EstudianteLogeado.Nombre} ya está inscrito en el curso : {tmpCurso.Titulo}");

                bLLEstudiante.AltaCurso(EstudianteLogeado,tmpCurso);
                mostrarDTGVCursosInscriptos(EstudianteLogeado);

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
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
