using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.Formularios.Usuarios
{
    public partial class Frm_UsuariosModificacion : Frm_usuarios
    {
        public Frm_UsuariosModificacion()
        {
            InitializeComponent();
        }

        private void Frm_UsuariosModificacion_Load(object sender, EventArgs e)
        {
            this.Location = new Point(701, 139);
            this.RecuperarUsuario();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == clases.TratamientosEspeciales.RespustaValidacion.correcta)
            {
                Usu.apellido = this.txt_apellido.Text;
                Usu.nombres = this.txt_nombre.Text;
                Usu.n_usuario = this.txt_n_usuario.Text;
                Usu.email = this.txt_email.Text;
                Usu.id_perfil = this.cmb_perfiles.SelectedValue.ToString();
                Usu.id_estado = this.cmb_estados.SelectedValue.ToString();
                Usu.cuil = this.txt_cuil.Text;
                Usu.password = this.txt_password.Text;
                Usu.id_usuario = this.txt_id_usuario.Text;

                Usu.Modificar();
            }
        }
    }
}
