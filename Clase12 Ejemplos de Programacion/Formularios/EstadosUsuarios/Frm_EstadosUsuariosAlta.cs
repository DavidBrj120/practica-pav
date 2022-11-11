using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.Formularios.EstadosUsuarios
{
    public partial class Frm_EstadosUsuariosAlta : Clase12_Ejemplos_de_Programacion.Formularios.EstadosUsuarios.Frm_EstadosUsuarios
    {
        public Frm_EstadosUsuariosAlta()
        {
            InitializeComponent();
        }

        private void Frm_EstadosUsuariosAlta_Load(object sender, EventArgs e)
        {
            this.Location = new Point(673, 262);
            this.txt_id_estado.Text = EstadosUsuarios.BuscarUltimo().Rows[0][0].ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A nivel de hijo");
            if (_TE.Validar(this.Controls)== clases.TratamientosEspeciales.RespustaValidacion.correcta)
            {
                if (EstadosUsuarios.ControlEstadoId(txt_id_estado.Text)== negocios.Ne_EstadosUsuarios.EstadoId.vacio)
                {
                    EstadosUsuarios.Insertar(txt_id_estado.Text, txt_n_estado.Text);
                }
                else
                {
                    MessageBox.Show("El valor de Id_Estado: " + txt_id_estado.Text + "\n"
                        + "Ya está utilizado en la Tabla EstadosUsuarios", "Importante"
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }
        }
    }
}
