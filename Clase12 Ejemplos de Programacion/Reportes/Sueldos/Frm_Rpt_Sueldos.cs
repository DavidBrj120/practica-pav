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
using Microsoft.Reporting.WinForms;

namespace Clase12_Ejemplos_de_Programacion.Reportes.Sueldos
{
    public partial class Frm_Rpt_Sueldos : Form
    {
        Ne_Sueldos Sueldo = new Ne_Sueldos();

        public Frm_Rpt_Sueldos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Sueldos_Load(object sender, EventArgs e)
        {

            //this.rv01.RefreshReport();
            //this.rv01.RefreshReport();
            //this.rv02.RefreshReport();
            //this.rv03.RefreshReport();
            Sel_Usuario._tabla = new Ne_Usuarios().BucarUsuarios2();
            this.rv01.RefreshReport();
            this.rv02.RefreshReport();
            this.rv03.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_periodo01._TextSM.Length == 0)
            {
                MessageBox.Show("No designó perido");
                txt_periodo01.Focus();
                return;
            }
            if (Sel_Usuario._Text == "")
            {
                MessageBox.Show("No designó el usuario");
                Sel_Usuario.Focus();
                return;
            }

            ReportDataSource Datos = new ReportDataSource("DataSet1", Sueldo.LiquidacionImpresion(txt_periodo01._Text, Sel_Usuario._Text));
            rv01.LocalReport.ReportEmbeddedResource = "Clase12_Ejemplos_de_Programacion.Reportes.Sueldos.Rpt_LiquidacionSueldo.rdlc";
            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("PR01", );
            //rv01.LocalReport.SetParameters(parametros);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();

        }

        private void btn_buscar02_Click(object sender, EventArgs e)
        {
            if (txt_periodo02._TextSM.Length == 0)
            {
                MessageBox.Show("No cargó el período");
                txt_periodo02.Focus();
                return;
            }
            //rv02._Datos = sueldo.AsignacionesDescuntos(txt_periodo02._Text);
            //rv02._Reporte = "Sueldos.Rpt_Asig_DescXPeriodo.rdlc";
            //rv02._Parametros = new string[1] { "Período de cálculo: " + txt_periodo02._Text };
            //rv02.CargarReporte();

            ReportDataSource Datos = new ReportDataSource("DataSet1", Sueldo.AsignacionesDescuntos(txt_periodo02._Text));
            rv02.LocalReport.ReportEmbeddedResource = "Clase12_Ejemplos_de_Programacion.Reportes.Sueldos.Rpt_Asig_DescXPeriodo.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", "Período de cálculo: " + txt_periodo02._Text);
            rv02.LocalReport.SetParameters(parametros);
            rv02.LocalReport.DataSources.Clear();
            rv02.LocalReport.DataSources.Add(Datos);
            rv02.RefreshReport();

        }

        private void btn_buscar03_Click(object sender, EventArgs e)
        {
            if (txt_inicial._TextSM.Length == 0)
            {
                MessageBox.Show("No desginó el período inicial");
                txt_inicial.Focus();
                return;
            }
            if (txt_final._TextSM.Length == 0)
            {
                MessageBox.Show("No deginó el período final ");
                txt_final.Focus();
                return;
            }

            ReportDataSource Datos = new ReportDataSource();
            rv03.LocalReport.ReportEmbeddedResource = "Clase12_Ejemplos_de_Programacion.Reportes.Sueldos.Rpt_Asig_DescXRangoPeriodo.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];

            if (rb_todos.Checked == true)
            {
                Datos = new ReportDataSource("DataSet1", Sueldo.AnalisisRangosPeriodos(txt_inicial._Text, txt_final._Text));
                parametros[0] = new ReportParameter("PR01", "Cálcula Asignaciones y Descuentos - "
                                        + "Rango de Períodos inicial: " + txt_inicial._Text
                                        + " final: " + txt_final._Text);
            }
            if (rb_asignaciones.Checked == true)
            {
                Datos = new ReportDataSource("DataSet1", Sueldo.AnalisisAsignacionesPeriodos(txt_inicial._Text, txt_final._Text));
                parametros[0] = new ReportParameter("PR01", "Cálcula solo Asignaciones - " 
                                                        + "Rango de Períodos inicial: " +txt_inicial._Text 
                                                        +" final: "+txt_final._Text);
            }
              
            
           
            rv03.LocalReport.SetParameters(parametros);
            rv03.LocalReport.DataSources.Clear();
            rv03.LocalReport.DataSources.Add(Datos);
            rv03.RefreshReport();
        }
    }
}
