using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.Formularios.Usuarios;
using Clase12_Ejemplos_de_Programacion.Formularios.EstadosUsuarios;
using Clase12_Ejemplos_de_Programacion.Formularios.Sueldos;
using Clase12_Ejemplos_de_Programacion.Reportes.Usuarios;
using Clase12_Ejemplos_de_Programacion.Reportes.Sueldos;

namespace Clase12_Ejemplos_de_Programacion.inicio
{
    public partial class Frm_Escritorio : Form
    {
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            //Frm_Login login = new Frm_Login();
            //login.ShowDialog();
            //if (login.ValorEstado== Frm_Login.Estado.error)
            //{
            //    login.Dispose();
            //    this.Close();
            //    return;
            //}
            //MessageBox.Show("El usuario : " + login.Pp_usuario + "\n"+ "Está autorizado a ingresar al sistema"
            //                ,"Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //login.Dispose();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Usuarios ABM_Usuarios = new Frm_ABM_Usuarios();
            ABM_Usuarios.ShowDialog();
            ABM_Usuarios.Dispose();
        }

        private void estadosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_ABM_EstadosUsuarios ABM_EstadosUsuarios  = new  Frm_ABM_EstadosUsuarios();
           ABM_EstadosUsuarios.ShowDialog();
           ABM_EstadosUsuarios.Dispose();
        }

        private void liquidaciónDeSueldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SistemaSueldos Sueldos = new Frm_SistemaSueldos();
            Sueldos.ShowDialog();
            Sueldos.Dispose();
        }

        private void sueldosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Rpt_Sueldos Rpt_Sueldos = new Frm_Rpt_Sueldos();
            Rpt_Sueldos.ShowDialog();
            Rpt_Sueldos.Dispose();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_RptUsuarios Rpt_Usuarios = new Frm_RptUsuarios();
            Rpt_Usuarios.ShowDialog();
            Rpt_Usuarios.Dispose();
        }
    }
}
