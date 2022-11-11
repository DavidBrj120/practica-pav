using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Clase12_Ejemplos_de_Programacion.Formularios
{
    public partial class Frm_Emplos_Programacion : Form
    {
        string cadena_conexion = "Data Source=LUISDELL\\SQLEXPRESS;Initial Catalog=TRATAMIENTO_ERRORES;Integrated Security=True";
        public Frm_Emplos_Programacion()
        {
            InitializeComponent();
        }

        private void btn_cargar_combo1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT id_usuario as pk,  
                              n_usuario as descripcion 
                               FROM usuarios";
            tabla.Load(cmd.ExecuteReader());

            cmb_usuarios.DisplayMember = "descripcion";
            cmb_usuarios.ValueMember = "pk";
            cmb_usuarios.DataSource = tabla;

        }

        private void cargar_combo2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT id_barrio as pk,  
                              nombre as descripcion 
                               FROM barrios";
            tabla.Load(cmd.ExecuteReader());

            cmb_restrigido.DisplayMember = "descripcion";
            cmb_restrigido.ValueMember = "pk";
            cmb_restrigido.DataSource = tabla;

        }
        /// <summary>
        /// Procemidimiento que realiza la tarea de cargar un compo que recibe
        /// por parámetro de entrada 
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="pk"></param>
        /// <param name="descripcion"></param>
        /// <param name="sql"></param>
        private void CargarCombo (ComboBox combo
                                  , string pk
                                  , string descripcion
                                  , string sql)
        {
            // crea el objeto  de nombre conexion del tipo de la clase SqlConnection para establecer
            // conexion con la base de datos
            SqlConnection conexion = new SqlConnection();
            // crea el objeto de nombre cmd del tipo de la clase SqlCommand para ejecutar
            // comando sql en la base de datos
            SqlCommand cmd = new SqlCommand();
            // crea el objeto de nombre tabla de tipo de la clase DataTable de trabajará
            // como receptor de los datos traidos desde la base de datos
            DataTable tabla = new DataTable();

            // le asigna la cadena de conexión al objeto de nombre conexion
            conexion.ConnectionString = cadena_conexion;
            // abre la conexion
            conexion.Open();
            // configura dentro del objeto cmd cual es la conexion con la que trabajará
            cmd.Connection = conexion;
            // configura el tipo de comando que se ejecutará, en este caso un comando 
            // de texto que se suministrará desde la aplicación
            cmd.CommandType = CommandType.Text;
            // se le asigna el comando de texto que debe ejecutar
            cmd.CommandText = sql;
            // carga el DataTable de nombre tabla con el resultado de la ejecución del comando
            // dentro de la base de datos
            tabla.Load(cmd.ExecuteReader());
            // establece como se llama la columna de tabla con la que se cargará la lista de 
            // despliegue
            combo.DisplayMember = descripcion;
            // establece como se llama la columna de la tabla que contiene el valor asociado
            // a cada componente de la lista de despliegue
            combo.ValueMember = pk;
            // se asigna la tabla al recurso de datos del combo
            combo.DataSource = tabla;
        }

        private void btn_cargar_usuario2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id_usuario as pk, n_usuario as descripcion FROM usuarios";
            CargarCombo(cmb_usuarios2, "pk"
                        , "descripcion"
                        , sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT id_barrio as pk,  
                              nombre as descripcion 
                               FROM barrios";
            CargarCombo(cmb_barrios2, "pk", "descripcion", sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id_usuario as pk, n_usuario as descripcion FROM usuarios";
            //cmb_usuarios02 de tipo de la clase ComboBox01 que hereda de la clase ComboBox
            //cmb_usuarios02.Cargar(sql, "pk", "descripcion");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT id_barrio as pk,  
                              nombre as descripcion 
                               FROM barrios";
            //cmb_barrios02 de tipo de la clase ComboBox01 que hereda de la clase ComboBox
            //cmb_barrios02.Cargar(sql, "pk", "descripcion");
        }
    }
}
