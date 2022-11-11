using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    public partial class Frm_SueldoModificar : Clase12_Ejemplos_de_Programacion.Formularios.Sueldos.Frm_SueldoBase
    {
        public Frm_SueldoModificar()
        {
            InitializeComponent();
        }

        private void Frm_SueldoModificar_Load(object sender, EventArgs e)
        {
            this.Location = new Point(227, 107);
            this.CargarFormulario();
            this.chk_controlAsignaciones.Checked = true;
            this.chk_controlDescuentos.Checked = true;
        }

        private void buttonModificar1_Click(object sender, EventArgs e)
        {
            if (txt_fecha._TextSM.Length == 0)
            {
                MessageBox.Show("Falta la fecha de liquidación");
                txt_fecha.Focus();
                return;
            }
            if (chk_controlAsignaciones.Checked == true)
            {
                if (GridAsignaciones.Rows.Count == 0)
                {
                    MessageBox.Show("Falta cargar los datos de asignaciones");
                    buscar_asignacion.Focus();
                    return;
                }
            }
            if (chk_controlDescuentos.Checked == true)
            {
                if (GridDescuentos.Rows.Count == 0)
                {
                    MessageBox.Show("Falta carga descuentos");
                    buscarDescuentos.Focus();
                    return;
                }
            }
            // accion de modificar

            MessageBox.Show("El resultado de la transaccion es: "
                            +_sueldo.ModificacionSueldo(
                            Id_usuario, Mes, Anno, txt_fecha._Text
                            , GridAsignaciones, GridDescuentos).ToString());

        }
    }
}
