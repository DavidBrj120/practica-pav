using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Clase12_Ejemplos_de_Programacion.clases
{
    public class Conexion_BD
    {
        //string cadena = "Data Source=LUIS-E\\SQLEXPRESS;Initial Catalog=TRATAMIENTO_ERRORES;Integrated Security=True";
        string cadena = "Data Source=LUISDELL\\SQLEXPRESS;Initial Catalog=TRATAMIENTO_ERRORES;Integrated Security=True";

        //ENUMERACION PARA DISTINGUIR EL TIPO DE CONEXION QUE SE REALIZARÁ
        public enum TipoConexion { simple, transaccion }
        //ENUMERACION PARA ESTABLECER ES STATUS DE UNA CONEXION TRANSACCIONAL
        public enum TipoEstado { correcto, error }

        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        //VARIABLE PARA CONTROLAR EL TIPO DE CONEXION ESTABLECIDA
        TipoConexion ControlTipoConexion = TipoConexion.simple;
        //VARIABLE PARA CONTROLAR EL ESTADO DE LA TRANSACCION
        TipoEstado ControlTransaccion = TipoEstado.correcto;
        SqlTransaction transaccion;

 
        /// <summary>
        /// Procedimiento público para establecer el inicio de una transacción, este 
        /// procedimiento debe ser citado via programación
        /// </summary>
        public void IniciarTransaccion()
        {
            ControlTipoConexion = TipoConexion.transaccion;
            ControlTransaccion = TipoEstado.correcto;
        }
        /// <summary>
        /// Función que permite finalizar una transacción previamente iniciada.Donde
        /// se analizar el ControlTransaccion para determinar se se finaliza por
        /// COMMIT o ROLLBACK
        /// </summary>
        /// <returns></returns>
        public TipoEstado FinalizarTransaccion()
        {
            // valida si la conexión es simple, al no ser una conexión transaccional
            // no se debiera haber activado esta función, por lo que se devuelve
            // un valor de correcto para finalizar la ejecución.
            if (ControlTipoConexion == TipoConexion.simple)
                return TipoEstado.correcto;
            // se valida el status del Control de Transacción. Si es correcto se termina
            // la transacción por COMMIT, en caso contrario finaliza por ROLLBACK
            if (ControlTransaccion == TipoEstado.correcto)
            {
                // termina transacción por commit
                transaccion.Commit();
            }
            else
            {
                // termina transaccion por rollback
                transaccion.Rollback();
            }
            // al finalizar la transacción se cambio es status del control de conexión a
            // conexion del tipo simple para poder desconectar 
            ControlTipoConexion = TipoConexion.simple;
            // desconecta 
            Desconectar();
            // devuelve via la función el estado con el que finalizó la transacción para
            // conocimiento de la programación donde fue invocada la transacción
            return ControlTransaccion;
        }

        /// <summary>
        /// PROCEDIMIENTO QUE ESTABLECE LA CONEXION CON LA BASE DE DATOS TANTO PARA UNA
        /// CONEXION SIMPLE COMO PARA UNA TRANSACCIONAL
        /// </summary>
        private void Conectar()
        {
            // valida en estado de la conexion, inicia una conexión solo en el caso de
            // que la conexión este cerrada
            if (conexion.State == ConnectionState.Closed)
            {
                // asigna cadena de conexión
                conexion.ConnectionString = cadena;
                try
                {
                    // abre la conexión col na base de datos
                    conexion.Open();
                }
                catch (Exception e)
                {
                    // mensaje de error que se emite cuando se produjo un error en el
                    // comando de apertura de la conexión
                    MessageBox.Show("Hubo un error en la Base de Datos\n"
                    + "Con el comando: \n"
                    + "conexion.Open()" + "\n"
                    + "El error en la base de datos:\n"
                    + e.Message);
                    // cambio de estado del control de transacción
                    ControlTransaccion = TipoEstado.error;
                    return;
                }
                // asigna al comando cmd quien es la conexión sobre la que debe trabajar
                cmd.Connection = conexion;
                // establece en el comando el tipo que tendrá
                cmd.CommandType = CommandType.Text;
                // valida si la conexión actual es del tipo transaccional
                if (ControlTipoConexion == TipoConexion.transaccion)
                {
                    // crea el objeto administrador de la transacción que se
                    // genera a partir de la conexión actual abierta.
                    // IsolationLever: Especifica el comportamiento de bloqueo 
                    // de transacción para la conexión.
                    // ReadCommitted: Los bloqueos compartidos se mantienen
                    // mientras se están leyendo los datos para evitar lecturas erróneas. 
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    // también se informa al comando quien es el administrador de la
                    // transacción
                    cmd.Transaction = transaccion;
                }
            }

        }
        private void Desconectar()
        {
            // valida que tipo de conexión esta vigente. Solo se puede
            // desconectar mientra la conexión es simple
            if (ControlTipoConexion == TipoConexion.simple)
            {
                conexion.Close();
            }
        }
        /// <summary>
        /// FUNCION QUE PERMITE RECUPERAR DATOS DE LA BASE DE DATO CON LA EJECUCION
        /// DE UN COMANDO SELECT DEL SQL
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public DataTable EjecutarSelct(string comando)
        {
            // conecta con la base de datos
            Conectar();
            // se asigna el comando SELECT a ejecutar
            cmd.CommandText = comando;
            // se crea una tabla donde recibir los datos calculado por el SELECT
            DataTable tabla = new DataTable();
            try
            {
                // dos tareas en simultaneo, se dispara la consulta con el comando
                // cmd.ExecuteReader(). Se carga la tabla (tabla.Load) con los valores 
                // calculados por el comando SELECT en la base de datos 
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                // mensaje de error que se emite cuando se produjo un error en el
                // comando ejecutado anteriormente por cmd.ExecuteReader
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                    + "Con el comando: \n"
                    + comando + "\n"
                    + "El error en la base de datos:\n"
                    + e.Message);
                // cambia el control de trasacción por el error detectado
                ControlTransaccion = TipoEstado.error;
                Desconectar();
                return tabla;
            }
            Desconectar();
            return tabla;
        }
        // "SELECT SCOPE_IDENTITY()"
        /// <summary>
        /// FUNCION QUE PERMITE EJECUTAR UN COMANDO INSERT DEL SQL PARA TABLAS
        /// QUE TIENEN GENERACIÓN AUTOMÁTICA DE LA PK, QUE DEVUELVE LA PK GENERADA
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public string InsertarRecuperandoPk(string comando)
        {
            DataTable Tabla = new DataTable();
            // conecta con la base de datos
            Conectar();
            // asigna el comando INSERT del SQL que debe ejecultarse
            cmd.CommandText = comando;
            try
            {
                // ejecutal el INSERT  
                cmd.ExecuteNonQuery();

                // comando especifico para SQL SERVER PARA RECUPERAR LA ULTIMA 
                //GENERACIÓN DE PK AUTOMATICA 
                cmd.CommandText = "SELECT SCOPE_IDENTITY()";
                Tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                // mensaje de error que se emite cuando se produjo un error en el
                // comando ejecutado anteriormente por cmd.ExecuteReader
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                                + "Con el comando: \n"
                                + comando + "\n"
                                + "El error en la base de datos:\n"
                                + e.Message);
                // cambia el estado del Control de Transaccion por el error detectado
                ControlTransaccion = TipoEstado.error;
                Desconectar();
                return "";
            }
            Desconectar();
            // devuelve el valor de la PK automática que se recuperó
            return Tabla.Rows[0][0].ToString();
        }
        /// <summary>
        /// PROCEDIMIENTO PARA EJECUTAR COMANDO INSERT DEL SQL
        /// </summary>
        /// <param name="comando"></param>
        public TipoEstado Insertar(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }
        /// <summary>
        /// PROCEDIMIENTO PARA EJECUTAR COMANDO UPDATE DEL SQL
        /// </summary>
        /// <param name="comando"></param>
        public TipoEstado Modificar(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }
        /// <summary>
        /// PROCEDMIMIENTO PARA EJECUTAR COMANDO DELETE DEL SQL
        /// </summary>
        /// <param name="comando"></param>
        public TipoEstado Borrar(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }
        /// <summary>
        /// PROCEDIMIENTO QUE PERMITE EJECUTAR INSERT, UPDATE Y DELETE DEL SQL
        /// </summary>
        /// <param name="comando"></param>
        private TipoEstado EjecutarIns_Upd_Del(string comando)
        {
            Conectar();
            cmd.CommandText = comando;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                + "Con el comando: \n"
                + comando + "\n"
                + "El error en la base de datos:\n"
                + e.Message);
                ControlTransaccion = TipoEstado.error;
                return ControlTransaccion;
            }
            Desconectar();
            return ControlTransaccion;
        }
    }
 
}
