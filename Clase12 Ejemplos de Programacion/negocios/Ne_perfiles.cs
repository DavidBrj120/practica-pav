using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;
using System.Data;

namespace Clase12_Ejemplos_de_Programacion.negocios
{
    public class Ne_perfiles
    {
        Conexion_BD _BD = new Conexion_BD();

        public CargaCombo DatosCombo()
        {
            CargaCombo Ec = new CargaCombo();
             Ec.sql = "";
            Ec.tabla = BuscarPerfiles();
            return Ec;
        }
        public DataTable BuscarPerfiles()
        {
            string sql = @"SELECT id_perfil as pk
                           , nombre as descripcion 
                           FROM perfiles";
            return _BD.EjecutarSelct(sql);
        }
    }
}
