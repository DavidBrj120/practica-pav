using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.clases;

namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    public partial class Frm_SueldoAlta : Clase12_Ejemplos_de_Programacion.Formularios.Sueldos.Frm_SueldoBase
    {
        public Frm_SueldoAlta()
        {
            InitializeComponent();
        }

        private void Frm_SueldoAlta_Load(object sender, EventArgs e)
        {
            this.Location = new Point(227, 107);
            chk_controlAsignaciones.Checked = true;
            chk_controlDescuentos.Checked = true;
        }

        private void buttonGrabar2_Click(object sender, EventArgs e)
        {
            if (bus_usuario._Text == "")
            {
                MessageBox.Show("No cargó el usuario");
                bus_usuario.Focus();
                return;
            }
            if (txt_anno._Text == "")
            {
                MessageBox.Show("Falta el año de la liquidación");
                txt_anno.Focus();
                return;
            }
            if (txt_mes._Text == "")
            {
                MessageBox.Show("No cargó el mes de liquidación");
                txt_mes.Focus();
                return; 
            }
            if (txt_fecha._TextSM.Length==0)
            {
                MessageBox.Show("Falta la fecha de liquidación");
                txt_fecha.Focus();
                return;
            }
            if (chk_controlAsignaciones.Checked == true)
            {
                if (GridAsignaciones.Rows.Count==0)
                {
                    MessageBox.Show("Falta cargar los datos de asignaciones");
                    buscar_asignacion.Focus();
                    return;
                }
            }
            if (chk_controlDescuentos.Checked == true)
            {
                if(GridDescuentos.Rows.Count == 0)
                {
                    MessageBox.Show("Falta carga descuentos");
                    buscarDescuentos.Focus();
                    return;
                }
            }

            //MessageBox.Show(" La transacción finalizó: "+ 
            //                  _sueldo.AltaSueldo_v1(bus_usuario._Text, Txt_sueldo._Text
            //                     , txt_mes._Text
            //                     , txt_anno._Text, txt_fecha._Text
            //                     , GridAsignaciones, GridDescuentos).ToString());

            MessageBox.Show(" La transacción finalizó: " +
                                _sueldo.AltaSueldo_v2(bus_usuario._Text, Txt_sueldo._Text
                                   , txt_mes._Text
                                   , txt_anno._Text, txt_fecha._Text
                                   , GridAsignaciones, GridDescuentos).ToString());
            

        }

        private void buttonNuevo21_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                string NombreControl = item.GetType().Name;
                switch (NombreControl)
                {
                    case "LabelText01":
                        ((LabelText01)item)._Blanquear();
                        break;

                    case "LabelText02":
                        ((LabelText02)item)._Blanquear();
                        break;
                    case "Selector01":
                        ((Selector01)item)._Blanquear();
                        break;
                    case "Grid01":
                        ((Grid01)item)._Blanquear();
                        break;
                    case "TextBox01":
                        ((TextBox01)item).Text = "";
                        break;
                default:
                        break;
                }
               
            }
        }
    }
}
