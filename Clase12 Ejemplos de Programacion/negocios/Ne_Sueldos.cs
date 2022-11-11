using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;
using System.Data;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.negocios;

namespace Clase12_Ejemplos_de_Programacion.negocios
{
    public class Ne_Sueldos
    {
        Conexion_BD _BD = new Conexion_BD();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public DataTable _BuscarSueldosCosulta (string restriccion)
        {
            string sql = @"SELECT u.id_usuario, u.apellido+', '+u.nombres
                        , sl.anno, sl.mes, sl.sueldo_basico
                        FROM SueldosLiquidacion sl join 
                        Usuarios u on u.id_usuario = sl.id_usuario";
            if (restriccion=="Todos")
            {
                return _BD.EjecutarSelct(sql);
            }
            return new DataTable();
        }
        public DataTable _BuscarSueldosCosulta (string restriccion, string valor)
        {
            string sql = @"SELECT u.id_usuario, u.apellido+', '+u.nombres
                        , sl.anno, sl.mes, sl.sueldo_basico
                        FROM SueldosLiquidacion sl join 
                        Usuarios u on u.id_usuario = sl.id_usuario
                        WHERE 1 = 1 ";
            switch (restriccion)
            {
                case "Apellido":
                    sql += "AND u.apellido = " + _TE.DatosTexto(valor).Trim();
                    break;
                case "Id_usuario":
                    sql += "AND u.id_usuario = " + valor;
                    break;
                case "Perfil":
                    sql += "AND u.id_perfil = " + valor;
                    break;
               
            }
            return _BD.EjecutarSelct(sql);
        }
        public DataTable _BuscarSueldosConsulta (string restriccion, string mes, string anno)
        {
            string sql = @"SELECT u.id_usuario, u.apellido+', '+u.nombres
                        , sl.anno, sl.mes, sl.sueldo_basico
                        FROM SueldosLiquidacion sl join 
                        Usuarios u on u.id_usuario = sl.id_usuario
                        WHERE anno = " + anno + " AND mes = " + mes;
            return _BD.EjecutarSelct(sql);
        }
        public string _CalculaSueldoBruto (string basico, Grid01 asig)
        {
            double TotalAsignaciones = 0;
            for (int i = 0; i < asig.Rows.Count; i++)
            {
                TotalAsignaciones += double.Parse(asig.Rows[i].Cells[0].Value.ToString().Replace(".", ",")) * double.Parse(asig.Rows[i].Cells[3].Value.ToString().Replace(".", ",")); 
            }
            return (double.Parse(basico.Replace(".", ",")) + TotalAsignaciones).ToString();
        }
        public string _CalculaSueldoNeto(string basico, Grid01 asig, Grid01 desc)
        {
            double TotalAsignaciones = 0;
            for (int i = 0; i < asig.Rows.Count; i++)
            {
                TotalAsignaciones += double.Parse(asig.Rows[i].Cells[0].Value.ToString().Replace(".", ",")) * double.Parse(asig.Rows[i].Cells[3].Value.ToString().Replace(".", ","));
            }
            double TotalDescuento = 0;
            for (int i = 0; i < desc.Rows.Count; i++)
            {
                TotalDescuento += double.Parse(desc.Rows[i].Cells[0].Value.ToString().Replace(".", ",")) * double.Parse(desc.Rows[i].Cells[3].Value.ToString().Replace(".", ","));
            }

            return (double.Parse(basico.Replace(".", ",")) + TotalAsignaciones-TotalDescuento).ToString();
        }
        public DataTable RecuperarLiquidacion(string Id_usuario, string Mes, string anno)
        {
            string sql = @"SELECT sl.sueldo_basico, 
                         convert(char(10), fecha, 103) as fecha, mes, anno
                        FROM SueldosLiquidacion sl
                        WHERE sl.id_usuario=" + Id_usuario
                        + " AND sl.mes = " + Mes
                        + " AND sl.anno = " + anno;
            return _BD.EjecutarSelct(sql);
        }
        public Conexion_BD.TipoEstado AltaSueldo_v1 (string id_usuario, string sueldoBasico
                                                    , string mes
                                                    , string anno, string fechaLiquidacion
                                                    , Grid01 Asignacion, Grid01 Descuento)
        {
            string InsertSueldoLiquidacion = @"INSERT INTO SueldosLiquidacion 
                                               (id_usuario, mes, anno, fecha, sueldo_basico) 
                                               VALUES (";
            InsertSueldoLiquidacion += id_usuario;
            InsertSueldoLiquidacion += ", " + mes;
            InsertSueldoLiquidacion += ", " + anno;
            InsertSueldoLiquidacion += ", " + _TE.DatoFecha(fechaLiquidacion);
            InsertSueldoLiquidacion += ", " + sueldoBasico.Replace(",",".") +")";

            //MessageBox.Show(InsertSueldoLiquidacion);

            _BD.IniciarTransaccion();
            _BD.Insertar(InsertSueldoLiquidacion);
            Ne_SueldoAsignacion SueldoA = new Ne_SueldoAsignacion();

            for (int i = 0; i < Asignacion.Rows.Count; i++)
            {
                _BD.Insertar(SueldoA.AltaAsignacion(id_usuario, mes, anno, i, Asignacion));
            }
            Ne_SueldoDescuento SueldoD = new Ne_SueldoDescuento();
            for (int i = 0; i < Descuento.Rows.Count; i++)
            {
                _BD.Insertar(SueldoD.AltaDescuento(id_usuario, mes, anno, i, Descuento));
            }

            return _BD.FinalizarTransaccion();

        }
        public Conexion_BD.TipoEstado AltaSueldo_v2(string id_usuario, string sueldoBasico
                                            , string mes
                                            , string anno, string fechaLiquidacion
                                            , Grid01 Asignacion, Grid01 Descuento)
        {
            string InsertSueldoLiq = @"INSERT INTO SueldosLiquidacion 
                                      (id_usuario, mes, anno, fecha, sueldo_basico) 
                                      VALUES ("
                                      + id_usuario
                                      + ", " + mes
                                      + ", " + anno
                                      + ", " + _TE.DatoFecha(fechaLiquidacion)
                                      + ", " + sueldoBasico.Replace(",", ".") + ")";

            //MessageBox.Show(InsertSueldoLiqu);
            //----
            // INICIO DE LA TRANSACCIÓN CON FORMATO DE INSERT INTEGRADO EN UN SOLO
            // COMANDO 
            _BD.IniciarTransaccion();
            _BD.Insertar(InsertSueldoLiq);
            _BD.Insertar(new Ne_SueldoAsignacion().AltaAsignacion(id_usuario, mes, anno, Asignacion));
            _BD.Insertar(new Ne_SueldoDescuento().AltaDescuento(id_usuario, mes, anno, Descuento));
            return _BD.FinalizarTransaccion();
            // FINAL DE LA TRANSACCION
            //-----
        }
        public Conexion_BD.TipoEstado ModificacionSueldo(string id_usuario 
                                     , string mes
                                     , string anno, string fechaLiquidacion
                                     , Grid01 Asignacion, Grid01 Descuento)
        {
            string ModificarSueldoLiquidacion = @"UPDATE SueldosLiquidacion
                                         SET fecha = " + _TE.DatoFecha(fechaLiquidacion)
                                         + " WHERE id_usuario = " + id_usuario
                                         + " AND mes = " + mes
                                         + " AND anno = " + anno;


            _BD.IniciarTransaccion();
            _BD.Modificar(ModificarSueldoLiquidacion);
            _BD.Borrar(new Ne_SueldoAsignacion().BorrarAsisgancionesLiquidacion(
                       id_usuario, mes, anno));
            _BD.Borrar(new Ne_SueldoDescuento().BorrarDescuentosLiquidacion(
                        id_usuario, mes, anno));
            if (Asignacion.Rows.Count>0)
                _BD.Insertar(new Ne_SueldoAsignacion().AltaAsignacion(
                             id_usuario, mes, anno, Asignacion));
            if (Descuento.Rows.Count >0)
                 _BD.Insertar(new Ne_SueldoDescuento().AltaDescuento(
                        id_usuario, mes, anno, Descuento));
            return _BD.FinalizarTransaccion();
        }
        public Conexion_BD.TipoEstado BorrarSueldo(string id_usuario
                                     , string mes
                                     , string anno)
        {
            string BorrarSueldoLiquidacion = @"DELETE FROM SueldosLiquidacion"
                                         + " WHERE id_usuario = " + id_usuario
                                         + " AND mes = " + mes
                                         + " AND anno = " + anno;

            _BD.IniciarTransaccion();
            _BD.Borrar(new Ne_SueldoAsignacion().BorrarAsisgancionesLiquidacion(
            id_usuario, mes, anno));
            _BD.Borrar(new Ne_SueldoDescuento().BorrarDescuentosLiquidacion(
                        id_usuario, mes, anno));
            _BD.Borrar(BorrarSueldoLiquidacion);
            return _BD.FinalizarTransaccion();
        }
        public DataTable LiquidacionImpresion(string periodo, string id_usuario)
        {
            string[] dato = periodo.Split('-');

            string sql = "";
            sql = @"SELECT convert(char(10),s.fecha, 103) fecha
                , s.id_usuario 
                , u.apellido+', '+u.nombres as usuario
                , u.cuil cuil
                , s.sueldo_basico
                , 1 orden
                , sa.cantidad cantidad
                , asi.n_asignacion designacion
                , sa.monto*sa.cantidad as asignaciones
                , 0 as descuentos
                    FROM SueldosLiquidacion s JOIN SueldosAsignaciones                        sa
                        ON s.id_usuario = sa.id_usuario
                        AND s.mes = sa.mes
                        AND s.anno = sa.anno
                    JOIN usuarios u
		                ON u.id_usuario = s.id_usuario
                    JOIN Asignaciones asi 
                        ON asi.id_asignacion = sa.id_asignacion
                WHERE month(s.fecha) = " + dato[0].ToString()
              + " AND year(s.fecha) = " + dato[1].ToString()
              + " AND s.id_usuario = " + id_usuario
              + @"UNION
                SELECT convert(char(10),s.fecha, 103) fecha
                , s.id_usuario 
                , u.apellido+', '+u.nombres as usuario
                , u.cuil cuil
                , s.sueldo_basico
                , 2 orden
                , sd.cantidad cantidad
                , des.n_descuento designacion
                , 0 as asignaciones
                , sd.monto*sd.cantidad as descuentos
                    FROM SueldosLiquidacion s JOIN SueldosDescuentos sd
		                ON s.id_usuario = sd.id_usuario
                        AND s.mes = sd.mes
                        AND s.anno = sd.anno
                    JOIN usuarios u
		                ON u.id_usuario = s.id_usuario
                    JOIN Descuentos des
                        ON des.id_descuento = sd.id_descuento
                WHERE month(s.fecha) = " + dato[0].ToString()
              + " AND year(s.fecha) = " + dato[1].ToString()
              + " AND s.id_usuario = " + id_usuario
              + " ORDER BY 5 asc";

            return _BD.EjecutarSelct(sql);
        }
        /// <summary>
        /// Cálculo de la distribución de asignaciones y descuentos para un periodo de liquidacion
        /// </summary>
        /// <param name="periodo"></param>
        /// <returns></returns>
        public DataTable AsignacionesDescuntos(string periodo)
        {
            string[] datos = periodo.Split('-');
            string sql = @"select 'Asignaciones' as denominacion
                            , sum (a.cantidad * a.monto) as valor
                          from SueldosAsignaciones a
                          where a.anno =" + datos[1]
                          + " and a.mes = " + datos[0]
                          + @" union
                          select 'Descuentos' as denominacion
                            , sum(d.cantidad * d.monto) as valor
                          from SueldosDescuentos d
                          where d.anno = " + datos[1]
                          + " and d.mes = " + datos[0];
            return _BD.EjecutarSelct(sql);
        }
        public DataTable AnalisisRangosPeriodos(string inicial, string final)
        {
            string[] DatosInicial = inicial.Split('-');
            string[] DatosFinal = final.Split('-');
            string sql = @"select 'Asignaciones' as denominacion
                            , sum (a.cantidad * a.monto) as valor
                          from SueldosAsignaciones a
                          where a.mes between " + DatosInicial[0] + " and " + DatosFinal[0]
                          + " and a.anno = " + DatosInicial[1]
                          + @" union
                          select 'Descuentos' as denominacion
                            , sum(d.cantidad * d.monto) as valor
                          from SueldosDescuentos d
                           where d.mes between " + DatosInicial[0] + " and " + DatosFinal[0]
                          + " and d.anno = " + DatosInicial[1];

            return _BD.EjecutarSelct(sql);
        }
        public DataTable AnalisisAsignacionesPeriodos(string inicial, string final)
        {
            string[] DatosInicial = inicial.Split('-');
            string[] DatosFinal = final.Split('-');
            string sql = @"select a.n_asignacion as denominacion
                            , sum (sa.cantidad * sa.monto) as valor
                          from SueldosAsignaciones sa join asignaciones a
                                        on a.id_asignacion = sa.id_asignacion
                          where sa.mes between " + DatosInicial[0] + " and " + DatosFinal[0]
                          + " and sa.anno = " + DatosInicial[1]
                          + " group by a.n_asignacion";

            return _BD.EjecutarSelct(sql);
        }
    }
}
