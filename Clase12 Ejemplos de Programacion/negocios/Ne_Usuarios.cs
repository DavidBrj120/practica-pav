using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12_Ejemplos_de_Programacion.clases;
using System.Data;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.negocios
{
    public class Ne_Usuarios
    {
        public string id_usuario { get; set; }
        public string n_usuario { get; set; }
        public string password { get; set; }
        public string id_perfil { get; set; }
        public string email { get; set; }
        public string apellido { get; set; }
        public string nombres { get; set; }
        public string id_estado { get; set; }
        public string cuil { get; set; }

        public enum respuesta { autozado, dengado }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Conexion_BD _BD = new Conexion_BD();

        public CargaCombo ComboUsuarios()
        {
            CargaCombo cc = new CargaCombo();
            cc.sql = "";
            cc.tabla = BucarUsuarios();
            return cc;    
        }
        /// <summary>
        /// Devuelve tabla apta para un selector con descripción n_usuario
        /// </summary>
        /// <returns></returns>
        public DataTable BucarUsuarios()
        {
            string sql = @"SELECT id_usuario as Pk
                        , n_usuario as Descripcion
                       FROM usuarios";
            return _BD.EjecutarSelct(sql);
        }
        /// <summary>
        /// Devuelve tabla apta para un selector con descripción n_usuario
        /// </summary>
        /// <returns></returns>
        public DataTable Selector()
        {
            string sql = @"SELECT id_usuario as Pk
                        , n_usuario as Descripcion
                       FROM usuarios";
            return _BD.EjecutarSelct(sql);
        }
        /// <summary>
        /// Devuelve tabla apta para selector con descripcion 'apellido, nombre'
        /// </summary>
        /// <returns></returns>
        public DataTable BucarUsuarios2()
        {
            string sql = @"SELECT id_usuario as Pk
                        , apellido+', '+nombres as Descripcion
                       FROM usuarios";
            return _BD.EjecutarSelct(sql);
        }
        public DataTable BuscarUsuario_x_Id (string id)
        {
            string sql = @"SELECT id_usuario as Pk
                        , n_usuario as Descripcion FROM usuarios 
                           WHERE id_usuario = " + id;
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelct(sql);
            return tabla;
        }

        public DataTable BuscarUsuario_x_Descripcion(string descripcion)
        {
            string sql = @"SELECT id_usuario as Pk
                        , n_usuario as Descripcion FROM usuarios 
                           WHERE n_usuario like '%" + descripcion+"%'";
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelct(sql);
            return tabla;
        }
        public CargaCombo ComboUsuario1(string descripcion)
        {
            CargaCombo cc = new CargaCombo();
            cc.tabla = BuscarUsuario_x_Descripcion(descripcion);
            return cc;
        }
        public CargaCombo ComboUsuario2(string id)
        {
            CargaCombo cc = new CargaCombo();
            cc.tabla = BuscarUsuario_x_Id(id);
            return cc;
        }

        public respuesta ValidarLogin(string usuario, string pssw)
        {
            string sql = @"SELECT * FROM usuarios 
                         WHERE n_usuario = '" + usuario.Trim() + "'"
                        + " AND password = '" + pssw.Trim() + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelct(sql);
            if (tabla.Rows.Count == 0)
                return respuesta.dengado;
            else
                return respuesta.autozado;
        }
        public DataTable RecuperaUsuarios1(Control.ControlCollection ctr)
        {
            DataTable tabla = new DataTable();
            string restriccion = "";
            string sql = "";

            foreach (var item in ctr)
            {
                switch (item.GetType().Name)
                {
                    case "MaskedTextBox":
                        if (((MaskedTextBox)item).Name == "txt_patron")
                        {
                            if (((MaskedTextBox)item).Text != "")
                            {
                                string columna = SelecColumna(ctr);
                                if (columna == "")
                                    continue;
                                restriccion = columna + " Like '%" + ((MaskedTextBox)item).Text + "%'";
                                sql = @"SELECT id_usuario, n_usuario, apellido, nombres
                                       FROM usuarios
                                       WHERE " + restriccion;
                                return _BD.EjecutarSelct(sql);
                            }
                        }
                        if (((MaskedTextBox)item).Name == "txt_id")
                        {
                            if (((MaskedTextBox)item).Text != "")
                                restriccion = " id_usuario = " + ((MaskedTextBox)item).Text;
                            sql = @"SELECT id_usuario, n_usuario, apellido, nombres
                                       FROM usuarios
                                       WHERE " + restriccion;
                            return _BD.EjecutarSelct(sql);
                        }
                        break;
                    case "CheckBox":
                        if (((CheckBox)item).Checked == true)
                        {
                            sql = @"SELECT id_usuario, n_usuario, apellido, nombres
                                       FROM usuarios";
                            return _BD.EjecutarSelct(sql);
                        }
                        break;
                }
            }
            return tabla;
        }
        private string SelecColumna(Control.ControlCollection rb)
        {
            foreach (var item in rb)
            {
                if (item.GetType().Name == "RadioButton")
                {
                    if (((RadioButton)item).Checked == true)
                    {
                        return ((RadioButton)item).Text;
                    }
                }
            }
            return "";
        }
        // ==============================================
        //  RECUPERACION DE USUARIO DE DIVERSOS FORMAS
        public DataTable RecuperarXTodos()
        {

            string sql = @"SELECT cuil,  apellido+', '+ nombres as descripcion, id_usuario pk
                                       FROM usuarios ";
            return _BD.EjecutarSelct(sql);
        }

        public DataTable RecuperaUsuarios2(Control.ControlCollection ctr)
        {
            DataTable tabla = new DataTable();
            string restriccion = "";
            string sql = "";

            var patron = ctr.Find("txt_patron", true);
            if (((MaskedTextBox)patron[0]).Text != "")
            {
                string columna = SelecColumna(ctr);
                if (columna == "")
                    return tabla;
                restriccion = columna + " Like '%" + ((MaskedTextBox)patron[0]).Text + "%'";
                sql = @"SELECT id_usuario, n_usuario, apellido, nombres
                                       FROM usuarios
                                       WHERE " + restriccion;
                return _BD.EjecutarSelct(sql);
            }

            object[] id = ctr.Find("txt_id", true);
            if (((MaskedTextBox)id[0]).Text != "")
            {
                restriccion = " id_usuario = " + ((MaskedTextBox)id[0]).Text;
                sql = @"SELECT id_usuario, n_usuario, apellido, nombres
                                       FROM usuarios
                                       WHERE " + restriccion;
                return _BD.EjecutarSelct(sql);
            }

            var chk = ctr.Find("chk_todos", true);
            if (((CheckBox)chk[0]).Checked == true)
            {
                sql = @"SELECT id_usuario, n_usuario, apellido, nombres
                                       FROM usuarios";
                return _BD.EjecutarSelct(sql);
            }
            return tabla;
        }
        public DataTable RecuperarUsuarioXid(string id_usuario)
        {
            string sql = "SELECT * FROM usuarios WHERE id_usuario = " + id_usuario;
            return _BD.EjecutarSelct(sql);
        }
        public string Insertar()
        {
            string SqlInsertar = @"INSERT INTO usuarios (
                           id_perfil, n_usuario, password, email, 
                           apellido, nombres, cuil, id_estado) VALUES (";

            SqlInsertar += this.id_perfil;
            SqlInsertar += ", " + _TE.DatosTexto(this.n_usuario);
            SqlInsertar += ", " + _TE.DatosTexto(this.password);
            SqlInsertar += ", " + _TE.DatosTexto(this.email);
            SqlInsertar += ", " + _TE.DatosTexto(this.apellido);
            SqlInsertar += ", " + _TE.DatosTexto(this.nombres);
            SqlInsertar += ", " + _TE.DatosTexto(this.cuil);
            SqlInsertar += ", " + this.id_estado + ")";
            return _BD.InsertarRecuperandoPk(SqlInsertar);
        }

        public void Insertar(Control.ControlCollection controles)
        {
            string id_usuario = _BD.InsertarRecuperandoPk(_TE.InsertaA(controles, "usuarios"));
            var patron = controles.Find("txt_id_usuario", true);
            patron[0].Text = id_usuario;
            MessageBox.Show("Se grabó correctamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Modificar()
        {
            string SqlModificar = "UPDATE usuarios SET ";
            SqlModificar += "id_perfil = " + this.id_perfil;
            SqlModificar += ", n_usuario =" + _TE.DatosTexto(this.n_usuario);
            SqlModificar += ", password = " + _TE.DatosTexto(this.password);
            SqlModificar += ", email = " + _TE.DatosTexto(this.email);
            SqlModificar += ", apellido = " + _TE.DatosTexto(this.apellido);
            SqlModificar += ", nombres =" + _TE.DatosTexto(this.nombres);
            SqlModificar += ", cuil =" + _TE.DatosTexto(this.cuil);
            SqlModificar += ", id_estado =" + this.id_estado;
            SqlModificar += " WHERE id_usuario = " + this.id_usuario;

            if (_BD.Modificar(SqlModificar) == Conexion_BD.TipoEstado.correcto)
                MessageBox.Show("Se modificó correctamente");
            else
                MessageBox.Show("No se modificó, hubo error");

        }
        public void Borrar (string id)
        {
            string sql = "DELETE FROM usuarios WHERE id_usuario = " + id;
            if (_BD.Borrar(sql) == Conexion_BD.TipoEstado.correcto)
                MessageBox.Show("Se borró correctamente");
            else
                MessageBox.Show("No se borró, hubo error");
        }
        public string RecuperarPerfilXid(string id_usuario)
        {
            string sql = "SELECT id_perfil FROM usuarios WHERE id_usuario = " + id_usuario;
            return _BD.EjecutarSelct(sql).Rows[0][0].ToString();
        }
        //
        //============================== ZONA DE REPORTES ===========================
        //

        public DataTable _Rpt_usuarios01()
        {
            string sql = "SELECT id_usuario, n_usuario, apellido, nombres FROM usuarios";
            return _BD.EjecutarSelct(sql);
        }
        public DataTable _Rpt_usuarios01(string letra)
        {
            string sql = @"SELECT id_usuario, n_usuario, apellido, nombres 
                         FROM usuarios WHERE apellido like '" + letra.Trim() + "%'";
            return _BD.EjecutarSelct(sql);
        }
        public DataTable _Rpt_usuarios01(string inicio, string final)
        {
            string sql = @"SELECT id_usuario, n_usuario, apellido, nombres 
                         FROM usuarios WHERE id_usuario between " + inicio + " AND " + final;
            return _BD.EjecutarSelct(sql);
        }


    }
}
