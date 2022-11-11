using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.clases
{
    class ReportViewer01 : ReportViewer 
    {
        public DataTable _Datos { get; set; }
        public string _Reporte
        {
            set
            {
                    this.LocalReport.ReportEmbeddedResource = "Clase12_Ejemplos_de_Programacion.Reportes." + value;
            }
        }
        public string[] _Parametros { get; set; } = new string[0];
    
        public void CargarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", _Datos);
            if (_Parametros != null)
            {
                if (_Parametros.Length > 0)
                {
                    ReportParameter[] Parametros = new ReportParameter[_Parametros.Length];
                    for (int i = 0; i < _Parametros.Length; i++)
                    {
                        Parametros[i] = new ReportParameter("PR" + (i + 1).ToString("00"), _Parametros[i]);
                    }
                    this.LocalReport.SetParameters(Parametros);
                }
            }
            this.LocalReport.DataSources.Clear();
            this.LocalReport.DataSources.Add(Datos);
            this.RefreshReport();
        }
    }
}
