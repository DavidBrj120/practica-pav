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
using Clase12_Ejemplos_de_Programacion.clases;

namespace Clase12_Ejemplos_de_Programacion.Formularios.EstadosUsuarios
{
    public partial class Frm_EstadosUsuarios : Form
    {
        public string _titulo { get { return lbl_titulo.Text; } set { lbl_titulo.Text = value; } }
        public string _id_estado { get; set; }
        public TratamientosEspeciales _TE = new TratamientosEspeciales();
        public Ne_EstadosUsuarios EstadosUsuarios = new Ne_EstadosUsuarios();

        public Frm_EstadosUsuarios()
        {
            InitializeComponent();
            
        }

        private void Frm_usuarios_Load(object sender, EventArgs e)
        {
     
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A niviel de padre");
        }
        public void RecuperarEstadoUsuario()
        {
            DataTable Tabla = new DataTable();
            Tabla = EstadosUsuarios.RecuperarEstadoUsuarioXid(_id_estado);
            _TE.CargarFormulario(this.Controls, Tabla);

            //this.txt_id_estado.Text = Tabla.Rows[0]["id_estado_usuario"].ToString();
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            label10.Text = this.Location.X.ToString() + ", " + this.Location.Y.ToString();

        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;

        }

        private void Frm_usuarios_Click(object sender, EventArgs e)
        {
            this.label10.Visible = true;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
