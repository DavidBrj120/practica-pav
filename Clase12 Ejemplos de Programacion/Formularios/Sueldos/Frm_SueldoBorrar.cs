using Clase12_Ejemplos_de_Programacion.negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    public partial class Frm_SueldoBorrar : Clase12_Ejemplos_de_Programacion.Formularios.Sueldos.Frm_SueldoBase
    {
        public Frm_SueldoBorrar()
        {
            InitializeComponent();
        }

        private void Frm_SueldoBorrar_Load(object sender, EventArgs e)
        {
            this.CargarFormulario();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de borrar la liquidación actual"
                , "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    MessageBox.Show("La transaccion termino por: " +
                        new Ne_Sueldos().BorrarSueldo(Id_usuario, Mes, Anno));
        }
    }
}
