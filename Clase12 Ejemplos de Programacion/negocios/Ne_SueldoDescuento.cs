using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;



namespace Clase12_Ejemplos_de_Programacion.negocios
{
    class Ne_SueldoDescuento
    {
        Conexion_BD _BD = new Conexion_BD();

        public string AltaDescuento(string id_usuario, string mes
                               , string anno, int fila, Grid01 Descuento)
        {
            string InsertarSueldoDescuento = @"INSERT INTO SueldosDescuentos (
                                              id_usuario, mes, anno, id_descuento
                                              , cantidad, monto) VALUES (";
            InsertarSueldoDescuento += id_usuario;
            InsertarSueldoDescuento += ", " + mes;
            InsertarSueldoDescuento += ", " + anno;
            InsertarSueldoDescuento += ", " + Descuento.Rows[fila].Cells[1].Value.ToString();
            InsertarSueldoDescuento += ", " + Descuento.Rows[fila].Cells[0].Value.ToString().Replace(",", ".");
            InsertarSueldoDescuento += ", " + Descuento.Rows[fila].Cells[3].Value.ToString().Replace(",", ".") + ")";

            return InsertarSueldoDescuento;

        }
        public string AltaDescuento(string id_usuario, string mes
                        , string anno,  Grid01 Descuento)
        {
            string InsertarSueldoDescuento = @"INSERT INTO SueldosDescuentos (
                                              id_usuario, mes, anno, id_descuento
                                              , cantidad, monto) VALUES ";
            for (int i = 0; i < Descuento.Rows.Count; i++)
            {
                if (i==0)
                    InsertarSueldoDescuento += "("+ id_usuario;
                else
                    InsertarSueldoDescuento += ", (" + id_usuario;

                InsertarSueldoDescuento += ", " + mes;
                InsertarSueldoDescuento += ", " + anno;
                InsertarSueldoDescuento += ", " + Descuento.Rows[i].Cells[1].Value.ToString();
                InsertarSueldoDescuento += ", " + Descuento.Rows[i].Cells[0].Value.ToString().Replace(",", ".");
                InsertarSueldoDescuento += ", " + Descuento.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + ")";
            }
             return InsertarSueldoDescuento;
        }
        public DataTable RecuperarDescuentos(string id_usuario, string mes, string anno)
        {

            string sql = @"SELECT sd.cantidad, sd.id_descuento, 
                         a.n_descuento, sd.monto 
                         FROM SueldosDescuentos sd JOIN descuentos a 
                         ON sd.id_descuento = a.id_descuento
                         WHERE sd.id_usuario = " + id_usuario
                         + " AND mes = " + mes
                         + " AND anno = " + anno;
            return _BD.EjecutarSelct(sql);
        }
        public string BorrarDescuentosLiquidacion(string id_usuario, string mes
                              , string anno)
        {
            string SQLDelete = @"DELETE FROM SueldosDescuentos 
                                WHERE id_usuario = " + id_usuario
                                + " AND mes = " + mes
                                + " AND anno = " + anno;
            return SQLDelete;
        }
    }
}
