using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.Formularios.EstadosUsuarios
{
    public partial class Frm_EstadosUsuariosModificacion : Clase12_Ejemplos_de_Programacion.Formularios.EstadosUsuarios.Frm_EstadosUsuarios
    {
        public Frm_EstadosUsuariosModificacion()
        {
            InitializeComponent();
        }

        private void Frm_EstadosUsuariosModificacion_Load(object sender, EventArgs e)
        {
            this.Location = new Point(673,262);
            RecuperarEstadoUsuario();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == clases.TratamientosEspeciales.RespustaValidacion.correcta)
            {
                 EstadosUsuarios.Modificar(txt_id_estado.Text, txt_n_estado.Text);
            }
        }
    }
}
