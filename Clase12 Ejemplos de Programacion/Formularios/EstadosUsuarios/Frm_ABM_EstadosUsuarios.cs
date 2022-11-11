using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.negocios;

namespace Clase12_Ejemplos_de_Programacion.Formularios.EstadosUsuarios
    {
    public partial class Frm_ABM_EstadosUsuarios : Form
    {
        public Frm_ABM_EstadosUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Usuarios_Load(object sender, EventArgs e)
        {
            this.Location = new Point(4, 57);
            Grid01._tamannoLetraGrid = 11;
            Grid01.Formatear("ID, 100, C; Descipción,500, I");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ne_EstadosUsuarios estadosUsuarios = new Ne_EstadosUsuarios();
            Grid01.Cargar(estadosUsuarios.RecuperaEstadoUsuario2(this.Controls));
            
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_EstadosUsuariosAlta AltaEstados = new Frm_EstadosUsuariosAlta();
            AltaEstados.ShowDialog();
            AltaEstados.Dispose();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (Grid01.Rows.Count == 0)
            {
                MessageBox.Show("La grilla está vacial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Frm_EstadosUsuariosModificacion ModifEstado = new Frm_EstadosUsuariosModificacion();
            ModifEstado._id_estado = Grid01.CurrentRow.Cells[0].Value.ToString();
            ModifEstado.ShowDialog();
            ModifEstado.Dispose();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (Grid01.Rows.Count == 0)
            {
                MessageBox.Show("La grilla está vacial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Frm_UsuariosBorrar BorrarUsuario = new Frm_UsuariosBorrar();
            //BorrarUsuario._id_usuario = Grid01.CurrentRow.Cells[0].Value.ToString();
            //BorrarUsuario.ShowDialog();
            //BorrarUsuario.Dispose();
        }

        private void Grid01_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_EstadosUsuariosConsulta ConsultaEstado = new Frm_EstadosUsuariosConsulta();
            ConsultaEstado._id_estado = Grid01.CurrentRow.Cells[0].Value.ToString();
            ConsultaEstado.ShowDialog();
            ConsultaEstado.Dispose();
        }
    }
}
