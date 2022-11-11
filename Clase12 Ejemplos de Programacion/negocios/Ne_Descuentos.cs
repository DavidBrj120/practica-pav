using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;
using System.Data;
    
namespace Clase12_Ejemplos_de_Programacion.negocios
{
    class Ne_Descuentos
    {
        Conexion_BD _BD = new Conexion_BD();

        public string RecuperarValorDescuento(string id_descuento)
        {
            string sql = "SELECT monto FROM Descuentos WHERE id_descuento = " + id_descuento;
            return _BD.EjecutarSelct(sql).Rows[0][0].ToString();
        }
        public string RecuperarPorcentajeDescuento(string id_descuento)
        {
            string sql = "SELECT porcentaje/100.00 FROM Descuentos WHERE id_descuento = " + id_descuento;
            return _BD.EjecutarSelct(sql).Rows[0][0].ToString();
        }
        public DataTable Selector()
        {
            string sql = @"SELECT id_descuento as pk
                           , n_descuento as descripcion 
                           FROM Descuentos";
            return _BD.EjecutarSelct(sql);
        }
    }
}
