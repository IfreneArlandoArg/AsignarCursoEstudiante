﻿using BLL;
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
                if (LoginSession.Instancia.EstaLogueado())
                    throw new Exception($"El usuario {LoginSession.Instancia.UsuarioActual.Apellido}, {LoginSession.Instancia.UsuarioActual.Nombre} está conectado!\n¡Esperé qué se desconecté!");
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
