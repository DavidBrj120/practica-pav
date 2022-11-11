using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;

namespace Clase12_Ejemplos_de_Programacion.negocios
{
    class Ne_SueldoPerfilHistorico
    {
        Conexion_BD _BD = new Conexion_BD();

        public string RecuperarUltimoSueldo (string id_perfil)
        {
            string sql = @"SELECT sueldo
                        FROM SueldoPerfilHistorico
                        WHERE fecha = (SELECT max(fecha) 
                                        from SueldoPerfilHistorico
                                       WHERE id_perfil = " + id_perfil
                        + ") AND id_perfil = " + id_perfil;
            return _BD.EjecutarSelct(sql).Rows[0][0].ToString();
        }
    }
}
