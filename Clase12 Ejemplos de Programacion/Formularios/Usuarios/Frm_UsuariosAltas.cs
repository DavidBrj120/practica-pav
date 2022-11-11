using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.clases;
using Clase12_Ejemplos_de_Programacion.negocios;


namespace Clase12_Ejemplos_de_Programacion.Formularios.Usuarios
{
    public partial class Frm_UsuariosAltas : Frm_usuarios
    {
       
        public Frm_UsuariosAltas()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespustaValidacion.correcta)
            {
                Usu.Insertar(this.Controls);

                //Usu.apellido = this.txt_apellido.Text;
                //Usu.nombres = this.txt_nombre.Text;
                //Usu.n_usuario = this.txt_n_usuario.Text;
                //Usu.email = this.txt_email.Text;
                //Usu.id_perfil = this.cmb_perfiles.SelectedValue.ToString();
                //Usu.id_estado = this.cmb_estados.SelectedValue.ToString();
                //Usu.cuil = this.txt_cuil.Text;
                //Usu.password = this.txt_password.Text;
                //    this.txt_id_usuario.Text = Usu.Insertar();
                //    MessageBox.Show("Se grabó correctamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Frm_UsuariosAltas_Load(object sender, EventArgs e)
        {
            this.Location = new Point(701, 139);
        }
    }
}
