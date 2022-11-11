using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Clase12_Ejemplos_de_Programacion.clases
{
    public class TratamientosEspeciales
    {
        public enum RespustaValidacion { error, correcta}
        Conexion_BD _BD = new Conexion_BD();

        public object exit { get; private set; }
        /// <summary>
        /// HERRAMIENTA DE VALIDACION AUTOMATICA QUE BUSCAR VACIOS EN CAJA DE TEXTBOX01 Y SIN SELECCION EN COMBOBOX01
        /// </summary>
        /// <param name="controles"></param>
        /// <returns></returns>
        public RespustaValidacion Validar (Control.ControlCollection controles)
        {
            //bucle que recorre todos los controles de un contenedor (formulario)
            foreach (var item in controles)
            {
                //carga en TipoControl el nombre del tipo de control actual en "item"
                string TipoControl = item.GetType().Name;
                //pregunta si el tipo de control es un TextBox01
                if (TipoControl=="TextBox01")
                {
                    //pregunta si el control es validable==true, en este caso es un control para validar
                    if (((TextBox01)item)._Validable== true)
                    {
                        //como el control es un TextBox01 pregunta si esta vacio 
                        if (((TextBox01)item).Text=="")
                        {
                            //emite un mensaje tomado desde la propiedad _MensajeError del mismo control
                            MessageBox.Show(((TextBox01)item)._MensajeError);
                            //enfoca el control dentro del formulario, queda el cursor dentro del control
                            ((TextBox01)item).Focus();
                            //retorna a través de la función un mensaje de validación erronea
                            return RespustaValidacion.error;
                        }
                    }
                }
                //pregunta si el control es del tipo ComboBox01
                if (TipoControl == "ComboBox01")
                {
                    //pregunta si el control es validable
                    if (((ComboBox01)item)._Validable == true)
                    {
                        //pregunta si el control esta sin seleccionar, esto es cuando SelectedIndex = -1
                        if (((ComboBox01)item).SelectedIndex == -1)
                        {
                            //emite un mensaje tomado desde la propiedad _MensajeError del mismo control
                            MessageBox.Show(((ComboBox01)item)._MensajeError);
                            //enfoca el control dentro del formulario, queda el cursor dentro del control
                            ((ComboBox01)item).Focus();
                            //retorna a través de la función un mensaje de validación erronea
                            return RespustaValidacion.error;
                        }
                    }
                }
            }
            // cuando recorre todos los controles del formulario y no encuentra ninguno con error, recien 
            // sale por el final del bucle foreach por unica vez, y por este caso retorna a travéz de la función
            // validacion correcta
            return RespustaValidacion.correcta;
        }
        /// <summary>
        /// Esta herramienta es para formatear textos para sql
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public string DatosTexto(string dato)
        {
            return "'" + dato.Trim() + "'";
        }
        /// <summary>
        /// Esta herramienta es para convertir una fecha al formato que entiende 
        /// el motor SqlServer
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public string DatoFecha(string dato)
        {
            return "CONVERT(date, '" + dato.Trim() + "', 103)";
        }
        // * * * * * *I M P O R T A N T E * * * * *
        // ---------------------------comando para insertar datos en una tabla via SQL
        //
        // INSERT INTO usuarios (n_usuario, apellido, nombres) VALUES ('MALVARES','ALVAREZ','MARTA') 
        //
        //----------------------(      seccion columnas      ) -------(        seccion datos       )--
        /// <summary>
        /// ESTA HERRAMIENTA ES UN AUTOMATIZADOR DE COMANDO INSERT DE SQL, QUE REQUIERE QUE EL FORMULARIO SE HAYA
        /// CREADO CON LOS CONTROLES TextBox01 y ComboBox01
        /// </summary>
        /// <param name="controles"></param>
        /// <param name="NombreTabla"></param>
        /// <returns></returns>
        public string InsertaA (Control.ControlCollection controles, string NombreTabla)
        {
            //encabezado del comando INSERT
            string sqlInsert = "INSERT INTO " + NombreTabla + "(";
            // variable donde se construirá la seccion columnas del comando INSERT
            string Columnas = "";
            // variable donde se construirá la seccion datos del comando INSERT
            string Datos = "";

            //bucle que recorre todos los controles de un contenedor (formulario)
            foreach (var item in controles)
            {
                // variable para guardar el tipo de control que se encuentra en item actualmente
                string TipoContro = item.GetType().Name;
                
                //pregunta si el tipo de control es un TextBox01
                if (TipoContro == "TextBox01")
                {
                    //pregunta si el control es validable==true, en este caso es un control para incluir en el INSERT
                    if (((TextBox01)item)._Validable == true)
                    {
                        // dispara una validación del nombre de columna para ver si existe o no, en caso de no existir
                        // respuesta false, no continúa con la carga de esta columna de este control, sigue con el siguiente
                        if (ValidarColumna(NombreTabla, ((TextBox01)item)._columna) == false)
                            continue;
                        // pregunta si la variable Columnas está vacia, para agregar dentro de Columnas la que corresponde
                        // sin poner una coma (,) por delaten, en el caso contrario agrega la columna con una coma (,) por
                        // delante
                        if (Columnas=="")
                        {
                            // agrega una columna a la seccion columnas
                            Columnas += ((TextBox01)item)._columna;
                            // agregar un dato a la sección datos
                            Datos += FormateaDato(NombreTabla, ((TextBox01)item)._columna,((TextBox01)item).Text);
                        }
                        else
                        {
                            // agrega una columna a la seccion columnas
                            Columnas += ","+ ((TextBox01)item)._columna;
                            // agregar un dato a la sección datos
                            Datos += "," + FormateaDato(NombreTabla, ((TextBox01)item)._columna, ((TextBox01)item).Text); 
                        }
                    }
                }
                //pregunta si el tipo de control es un ComboBox01
                if (TipoContro == "ComboBox01")
                {
                    //pregunta si el control es validable==true, en este caso es un control para incluir en el INSERT
                    if (((ComboBox01)item)._Validable == true)
                    {
                        // dispara una validación del nombre de columna para ver si existe o no, en caso de no existir
                        // respuesta false, no continúa con la carga de esta columna de este control, sigue con el siguiente
                        if (ValidarColumna(NombreTabla, ((ComboBox01)item)._columna) == false)
                            continue;
                        // pregunta si la variable Columnas está vacia, para agregar dentro de Columnas la que corresponde
                        // sin poner una coma (,) por delaten, en el caso contrario agrega la columna con una coma (,) por
                        // delante
                        if (Columnas == "")
                        {
                            // agrega una columna a la seccion columnas
                            Columnas += ((ComboBox01)item)._columna;
                            // agregar un dato a la sección datos
                            Datos += FormateaDato(NombreTabla, ((ComboBox01)item)._columna, ((ComboBox01)item).SelectedValue.ToString());
                        }
                        else
                        {
                            // agrega una columna a la seccion columnas
                            Columnas += "," + ((ComboBox01)item)._columna;
                            // agregar un dato a la sección datos
                            Datos += "," + FormateaDato(NombreTabla, ((ComboBox01)item)._columna, ((ComboBox01)item).SelectedValue.ToString());
                        }
                    }
                }
            }
            // con las secciones construida termina de armar el comando INSERT dentro de la variable sqlInsert
            sqlInsert += Columnas + ") VALUES (" + Datos + ")";
            //MessageBox.Show(sqlInsert);
            return sqlInsert;
        }
        /// <summary>
        /// PERMITE VALIDAR SI UN NOMBRE PASADO EN EL PARAMETRO Columna ES UN NOMBRE DE COLUMNA
        /// VALIDO DENTRO DE LA TABLA PASADA EN PARAMETRO Tabla. EN CASO DE SERLO DEVUELVE true
        /// POR LO CONTRARIO false
        /// </summary>
        /// <param name="Tabla"></param>
        /// <param name="Columna"></param>
        /// <returns></returns>
        private bool ValidarColumna (string Tabla, string Columna)
        {
            DataTable Estructura = new DataTable();
            // recupera una fila de la tabla en cuestion para analizar los nombres de columnas
            Estructura = EstructuraTabla(Tabla);
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                // empareja de ambos lados la presentación de los datos, sacando blancos y poniendo a
                // mayusculas las expresiones
                if (Columna.Trim().ToUpper() == Estructura.Columns[i].Caption.Trim().ToUpper())
                    return true;
            }
            return false;
        }
        /// <summary>
        /// ANALIZADOR DEL TIPO DE DATOS DE UNA COLUMNA DETERMINADA
        /// </summary>
        /// <param name="Tabla"></param>
        /// <param name="Columna"></param>
        /// <param name="Datos"></param>
        /// <returns></returns>
        private string FormateaDato (string Tabla, string Columna, string Datos)
        {
            DataTable Estructura = new DataTable();
            // recupera una fila de la tabla en cuestion para analizar los nombres de columnas
            Estructura = EstructuraTabla(Tabla);
            // recorre las columnas de la tabla 
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                // pregunta si la columna actual se llama igual a la columna de parámetro
                if (Estructura.Columns[i].Caption.Trim().ToUpper() == Columna.Trim().ToUpper())
                {
                    // analiza el nombre del tipo de datos para formatear
                    switch (Estructura.Columns[i].DataType.Name)
                    {
                        // para estos tres tipos de datos devuelve el mismo datos sin cambios
                        case "Int32":
                        case "Int64":
                        case "Int16":
                            return Datos;
                          
                        // para el tipo string devuelve el dato con los delimitadores (comilla simple) agregados
                        case "String":
                            return "'" + Datos + "'";
                        // para el tipo fecha utiliza la función CONVERT del SQL para que el motor adapte la fecha
                        // al formato que corresponda, desde el formato argentino que es dd/mm/yyyy, el parámetro
                        // 103 es el que le dice al CONVERT que formato es el que tiene el dato con la fecha
                        case "Date":
                        case "DateTime":
                            return "CONVERT(date, '" + Datos + "',103) ";
                    }
                }
            }
            return Datos;
        }
        /// <summary>
        /// FUNCION QUE RECUPERA UNA FILA DE LA TABLA EN CUESTIÓN CON EL FIN DE PODER ANALIZAR NOMBRE DE COLUMNAS
        /// Y TIPO DE DATO DE UNA COLUMNA
        /// </summary>
        /// <param name="NombreTabla"></param>
        /// <returns></returns>
        private DataTable EstructuraTabla (string NombreTabla)
        {
            string sql = "SELECT TOP 1 * FROM " + NombreTabla;
            return _BD.EjecutarSelct(sql);
        }
        /// <summary>
        /// ESTE PROCEDIMIENTO PERMITE LA CARGA AUTOMÁTICA DE UN FORMULARIO, SI TRABAJA CON LOS
        /// CONTROLES DISEÑADOS POR EL PROGRAMADOR (TextoBox01 y ComboBox01)
        /// </summary>
        /// <param name="Controles"></param>
        /// <param name="Tabla"></param>
        public void CargarFormulario(Control.ControlCollection Controles, DataTable Tabla)
        {
            // Recorre los controles de un formulario o contenedor de controles
            foreach (var item in Controles)
            {
                // obtiene el nombre del control procesado actualmente
                string TipoControl = item.GetType().Name;
                // pregunta si el control es del tipo TextBox01
                if (TipoControl == "TextBox01")
                {
                    // transfiere al txt el contenido de item. txt se encuentra definido como 
                    // TextBox01, ya habiamos determinado que item cotenía un control de 
                    // este tipo, esto se hace para poder aplicar programación especifica sobre
                    // el control con el formato ya dado.
                    TextBox01 txt = item as TextBox01;
                    // se pregunta si txt es validable, si es validable es un control de interes
                    // para dato de la base de datos
                    if (txt._Validable == true)
                        // se asigna el dato que corresponde de la tabla, segun el nombre de 
                        // columna almacenada en el control
                        txt.Text = BuscarDato(Tabla, txt._columna);
                }
                // igual que en la pregunta anterior para TextBox01 se aplica el mismo razonamiento
                // para ComboBox01
                if (TipoControl == "ComboBox01")
                {
                    ComboBox01 cmb = item as ComboBox01;
                    if (cmb._Validable == true)
                        cmb.SelectedValue = int.Parse(BuscarDato(Tabla, cmb._columna));
                }
            }
        }
        private string BuscarDato(DataTable Tabla, String Columna)
        {
            // busca en la tabla que contiene los datos para cargar los controles
            // una columna determinada para así devolver el valor de dato que
            // le corresponde a ese control
            for (int i = 0; i < Tabla.Columns.Count; i++)
            {
                if (Tabla.Columns[i].Caption.ToUpper() == Columna.Trim().ToUpper())
                {
                    return Tabla.Rows[0][i].ToString();
                }
            }
            return "";
        }


    }
}
