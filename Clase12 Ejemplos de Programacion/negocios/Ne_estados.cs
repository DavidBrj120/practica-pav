using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;
using System.Data;

namespace Clase12_Ejemplos_de_Programacion.negocios
{
    public class Ne_estados
    {
        Conexion_BD _BD = new Conexion_BD();
        public CargaCombo ComboEstados()
        {
            CargaCombo cc = new CargaCombo();
            cc.sql = "";
            cc.tabla = BuscarEstados();
            return cc;
        }
        public DataTable BuscarEstados()
        {
            string sql = @"SELECT id_estado as Pk
                        , nombre as Descripcion
                       FROM estados";
            return _BD.EjecutarSelct(sql);
        }
    }
}
