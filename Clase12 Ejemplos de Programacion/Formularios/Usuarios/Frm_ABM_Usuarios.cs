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

namespace Clase12_Ejemplos_de_Programacion.Formularios.Usuarios
{
    public partial class Frm_ABM_Usuarios : Form
    {
        public Frm_ABM_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Usuarios_Load(object sender, EventArgs e)
        {
            this.Location = new Point(4, 57);
            Grid01._tamannoLetraGrid = 9;
            Grid01.Formatear("ID, 50, C;Usuario,150, I;Apellido, 200,I;Nombre, 200,I");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ne_Usuarios usuario = new Ne_Usuarios();

            //Grid01.Cargar(usuario.RecuperaUsuarios1(this.Controls));
            Grid01.Cargar(usuario.RecuperaUsuarios2(this.Controls));
            
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_UsuariosAltas AltaUsuario = new Frm_UsuariosAltas();
            AltaUsuario.ShowDialog();
            AltaUsuario.Dispose();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (Grid01.Rows.Count == 0)
            {
                MessageBox.Show("La grilla está vacial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Frm_UsuariosModificacion ModifUsuario = new Frm_UsuariosModificacion();
            ModifUsuario._id_usuario = Grid01.CurrentRow.Cells[0].Value.ToString();
            ModifUsuario.ShowDialog();
            ModifUsuario.Dispose();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (Grid01.Rows.Count == 0)
            {
                MessageBox.Show("La grilla está vacial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Frm_UsuariosBorrar BorrarUsuario = new Frm_UsuariosBorrar();
            BorrarUsuario._id_usuario = Grid01.CurrentRow.Cells[0].Value.ToString();
            BorrarUsuario.ShowDialog();
            BorrarUsuario.Dispose();
        }

        private void Grid01_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_UsuariosConsulta ConsultaUsuario = new Frm_UsuariosConsulta();
            ConsultaUsuario._id_usuario = Grid01.CurrentRow.Cells[0].Value.ToString();
            ConsultaUsuario.ShowDialog();
            ConsultaUsuario.Dispose();
        }
    }
}
