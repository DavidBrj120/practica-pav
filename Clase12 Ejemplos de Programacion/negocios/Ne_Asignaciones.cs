using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;
using System.Data;

namespace Clase12_Ejemplos_de_Programacion.negocios
{
    class Ne_Asignaciones
    {
        Conexion_BD _BD = new Conexion_BD();

        public string RecuperarValorAsignacion (string id_asignacion)
        {
            string sql = "SELECT monto FROM Asignaciones WHERE id_asignacion = " + id_asignacion;
            return _BD.EjecutarSelct(sql).Rows[0][0].ToString();
        }
        public DataTable Selector()
        {
            string sql = @"SELECT id_asignacion as pk
                           , n_asignacion as descripcion 
                           FROM Asignaciones";
            return _BD.EjecutarSelct(sql);
        }
    }
}
