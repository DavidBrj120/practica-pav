using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.Formularios.Usuarios
{
    public partial class Frm_UsuariosBorrar : Frm_usuarios
    {
        public Frm_UsuariosBorrar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Está seguro de borrar este registro"
                    , "Importaten", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Usu.Borrar(id: _id_usuario);
            }
        }

        private void Frm_UsuariosBorrar_Load(object sender, EventArgs e)
        {
            this.Location = new Point(701, 139);
            this.RecuperarUsuario();
        }
    }
}
