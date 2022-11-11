using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Clase12_Ejemplos_de_Programacion.clases
{
    public class ComboBox01 : ComboBox
    {
        public string _columna { get; set; }
        public string _MensajeError { get; set; }
        public bool _Validable { get; set; }

        public void Cargar (DataTable Datos, string pk, string descripcion)
        {
            this.DisplayMember = descripcion;
            this.ValueMember = pk;
            this.DataSource = Datos;
         }
        public void Cargar(CargaCombo Datos)
        {
            this.DataSource = Datos.tabla;
            this.DisplayMember = Datos.descipcion;
            this.ValueMember = Datos.Pk;
        }
        public void Cargar(DataRow[] Datos, string pk, string descripcion)
        {
            this.DisplayMember = descripcion;
            this.ValueMember = pk;
            this.DataSource = Datos.CopyToDataTable();
        }
     
    }
}
