using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;
using System.Data;


namespace Clase12_Ejemplos_de_Programacion.negocios
{
    public class Ne_SueldoAsignacion
    {
        Conexion_BD _BD = new Conexion_BD();

        public string AltaAsignacion (string id_usuario, string mes
                                      , string anno, int fila, Grid01 Asignaciones )
        {
            string InsertarSueldoAsignacion = @"INSERT INTO SueldosAsignaciones (
                                              id_usuario, mes, anno, id_asignacion
                                              , cantidad, monto) VALUES (";

            InsertarSueldoAsignacion += id_usuario;
            InsertarSueldoAsignacion += ", " + mes;
            InsertarSueldoAsignacion += ", " + anno;
            InsertarSueldoAsignacion += ", " + Asignaciones.Rows[fila].Cells[1].Value.ToString();
            InsertarSueldoAsignacion += ", " + Asignaciones.Rows[fila].Cells[0].Value.ToString().Replace(",", ".");
            InsertarSueldoAsignacion += ", " + Asignaciones.Rows[fila].Cells[3].Value.ToString().Replace(",", ".")+")";

            return InsertarSueldoAsignacion;

        }
        public string AltaAsignacion(string id_usuario, string mes
                                      , string anno, Grid01 Asignaciones)
        {
            string InsertarSueldoAsignacion = @"INSERT INTO SueldosAsignaciones (
                                              id_usuario, mes, anno, id_asignacion
                                              , cantidad, monto) VALUES ";

            for (int i = 0; i < Asignaciones.Rows.Count; i++)
            {
                if (i==0)
                    InsertarSueldoAsignacion += "("+id_usuario;
                else
                    InsertarSueldoAsignacion += ", (" + id_usuario;

                InsertarSueldoAsignacion += ", " + mes;
                InsertarSueldoAsignacion += ", " + anno;
                InsertarSueldoAsignacion += ", " + Asignaciones.Rows[i].Cells[1].Value.ToString();
                InsertarSueldoAsignacion += ", " + Asignaciones.Rows[i].Cells[0].Value.ToString().Replace(",", ".");
                InsertarSueldoAsignacion += ", " + Asignaciones.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + ") ";
            }

            return InsertarSueldoAsignacion;
        }
        public DataTable RecuperarAsinaciones (string id_usuario, string mes, string anno)
        {
            string sql = @"SELECT sa.cantidad, sa.id_asignacion, 
                         a.n_asignacion, sa.monto 
                         FROM SueldosAsignaciones sa JOIN asignaciones a 
                         ON sa.id_asignacion = a.id_asignacion
                         WHERE sa.id_usuario = " + id_usuario
                         + " AND mes = " + mes
                         + " AND anno = " + anno;
            return _BD.EjecutarSelct(sql);
        }
        public string BorrarAsisgancionesLiquidacion (string id_usuario, string mes
                                      , string anno)
        {
            string SQLDelete = @"DELETE FROM SueldosAsignaciones 
                                WHERE id_usuario = " + id_usuario
                                + " AND mes = " + mes
                                + " AND anno = " + anno;
            return SQLDelete;
        }
    }
}
