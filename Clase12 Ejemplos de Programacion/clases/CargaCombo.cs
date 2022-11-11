using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Clase12_Ejemplos_de_Programacion.clases
{
    public class CargaCombo
    {
        public string Pk { get; set; } = "Pk";
        public string descipcion { get; set; } = "Descripcion";
        public string sql { get; set; }
        public DataTable tabla = new DataTable();
    }
}
