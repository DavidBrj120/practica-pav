using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.Formularios
{
    public partial class Frm_EstadosUsuariosConsulta : Clase12_Ejemplos_de_Programacion.Formularios.EstadosUsuarios.Frm_EstadosUsuarios
    {
        public Frm_EstadosUsuariosConsulta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_EstadosUsuariosConsulta_Load(object sender, EventArgs e)
        {
            this.Location = new Point(673, 262);
            RecuperarEstadoUsuario();
        }
    }
}
