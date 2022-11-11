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

namespace Clase12_Ejemplos_de_Programacion.Formularios
{
    public partial class Frm_Seleccionar : Form
    {
        public Frm_Seleccionar()
        {
            InitializeComponent();
        }
        private void buscar_todos()
        {
            Frm_Base_Selector sel = new Frm_Base_Selector();
            sel._DatosCombo = new negocios.Ne_Usuarios().ComboUsuarios();
            sel._titulo = "Lista de Usuarios";
            sel.ShowDialog();
            txt_id_usuario.Text = sel._Id;
            txt_n_usuario.Text = sel._Descripcion;
        }
        private void btn_buscar_usuarios_Click(object sender, EventArgs e)
        {
            buscar_todos();            
        }

        private void txt_n_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Frm_Base_Selector sel = new Frm_Base_Selector();
                Ne_Usuarios usu = new Ne_Usuarios();
                sel._DatosCombo = usu.ComboUsuario1(txt_n_usuario.Text);
                sel._titulo = "Lista de Usuarios";
                sel.ShowDialog();
                txt_id_usuario.Text = sel._Id;
                txt_n_usuario.Text = sel._Descripcion;
            }
        }

        private void txt_id_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Ne_Usuarios usu = new Ne_Usuarios();
                DataTable tabla = new DataTable();
                tabla = usu.BuscarUsuario_x_Id(txt_id_usuario.Text);
                if (tabla.Rows.Count>0)
                {
                    txt_id_usuario.Text = tabla.Rows[0][0].ToString();
                    txt_n_usuario.Text = tabla.Rows[0][1].ToString();
                }
                else
                {
                    buscar_todos();
                }
            }
        }

        private void Frm_Seleccionar_Load(object sender, EventArgs e)
        {
            Sel_usuarios._tabla = new Ne_Usuarios().BucarUsuarios();
            Sel_estados._tabla = new Ne_estados().BuscarEstados();
            Sel_ApeNom._tabla = new Ne_Usuarios().BucarUsuarios2();
            SelCuil._tabla = new Ne_Usuarios().RecuperarXTodos();
        }

        private void btn_agregar_cuil_Click(object sender, EventArgs e)
        {
            SelCuil._Buscar("27251472586");
        }
    }
}
