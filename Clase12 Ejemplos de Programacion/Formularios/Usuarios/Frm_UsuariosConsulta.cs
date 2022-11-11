using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.Formularios.Usuarios
{
    public partial class Frm_UsuariosConsulta : Frm_usuarios
    {
        public Frm_UsuariosConsulta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_UsuariosConsulta_Load(object sender, EventArgs e)
        {
            this.Location = new Point(701, 139);
            this.RecuperarUsuario();
        }
    }
}
