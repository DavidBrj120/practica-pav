using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.negocios;
// permite tener acceso a las herramientas de reportes
using Microsoft.Reporting.WinForms;
using Clase12_Ejemplos_de_Programacion.clases;

namespace Clase12_Ejemplos_de_Programacion.Reportes.Usuarios
{
    public partial class Frm_RptUsuarios : Form
    {
        Ne_Usuarios _Usuarios = new Ne_Usuarios();
        DataTable Tabla = new DataTable();
        string alcance = "";


        public Frm_RptUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_ReportesUsuarios_Load(object sender, EventArgs e)
        {


        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_todos.Checked==true)
            {
                txt_restriccion._Text = "";
                txt_restriccion.Visible = false;
            }
        }
        private void rb_x_letra_CheckedChanged(object sender, EventArgs e)
        {
            txt_restriccion._Etiqueta = "Ingrese letra";
            txt_restriccion._Mask = "L";
            txt_restriccion.Visible = true;
        }

        private void rb_rango_id_CheckedChanged(object sender, EventArgs e)
        {
            txt_restriccion._Etiqueta = "Ingrese rango";
            txt_restriccion._Mask = "99-99";
            txt_restriccion.Visible = true;
        }
        private void Restriccion()
        {
            if (rb_todos.Checked == true)
            {
                //todos
                alcance = "Todos los usuarios";
                Tabla = _Usuarios._Rpt_usuarios01();
            }
            if (rb_rango_id.Checked == true)
            {
                //rango
                string[] datos = txt_restriccion._Text.Split('-');
                alcance = "Rango de id del usuario, inicio: " + datos[0].ToString() + " final: " + datos[1].ToString();
                Tabla = _Usuarios._Rpt_usuarios01(datos[0].ToString(), datos[1].ToString());
            }
            if (rb_x_letra.Checked == true)
            {
                //letra
                alcance = "Apellidos que inicien con la letra: " + txt_restriccion._Text;
                Tabla = _Usuarios._Rpt_usuarios01(txt_restriccion._Text);
            }
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            Restriccion();

            ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);
            rv01.LocalReport.ReportEmbeddedResource = "Clase12_Ejemplos_de_Programacion.Reportes.Usuarios.Rpt_Usuarios01.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", alcance);
            rv01.LocalReport.SetParameters(parametros);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();
        }

        private void btn_buscar02_Click_1(object sender, EventArgs e)
        {
            Restriccion();
            rv._Datos = Tabla;
            rv._Reporte = "Usuarios.Rpt_Usuarios01.rdlc";
            rv._Parametros = new string[1] {alcance};
            rv.CargarReporte();
        }
    }
}
