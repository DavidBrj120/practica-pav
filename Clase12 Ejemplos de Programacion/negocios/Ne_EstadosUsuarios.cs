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
    public class Ne_EstadosUsuarios
    {
        Conexion_BD _BD = new Conexion_BD();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public enum EstadoId {vacio, usado }
        public CargaCombo DatosCombo()
        {
            CargaCombo Ec = new CargaCombo();
            Ec.sql = "";
            Ec.tabla = BuscarEstados();
            return Ec;
        }
        public DataTable BuscarEstados()
        {
            string sql = @"SELECT id_estado_usuario as pk
                            , n_estado_usuario as descripcion 
                            FROM EstadosUsuarios";
            return _BD.EjecutarSelct(sql);
        }
        public DataTable BuscarUltimo()
        {
            string sql = @"SELECT MAX(id_estado_usuario)+1 as valor
                           FROM EstadosUsuarios";
            return _BD.EjecutarSelct(sql);
        }
        public EstadoId ControlEstadoId (string id_estado)
        {
            string sql = @"SELECT * FROM EstadosUsuarios
                          WHERE id_estado_usuario = " + id_estado;
            return _BD.EjecutarSelct(sql).Rows.Count == 0 ? EstadoId.vacio : EstadoId.usado;
        }
        public DataTable RecuperarEstadoUsuarioXid (string id_estado)
        {
            string sql = @"SELECT * FROM EstadosUsuarios 
                        WHERE id_estado_usuario = " + id_estado;
            return _BD.EjecutarSelct(sql);
        }
        public DataTable RecuperarEstadoUsuarioXdescripcion(string descripcion)
        {
            string sql = @"SELECT * FROM EstadosUsuarios 
                            WHERE n_estado_usuario like '%" + descripcion.Trim() + "%'";
            return _BD.EjecutarSelct(sql);
        }
        public DataTable RecuperaEstadoUsuario2(Control.ControlCollection ctr)
        {
            DataTable tabla = new DataTable();
            string restriccion = "";
            string sql = "";

            var patron = ctr.Find("txt_patron", true);
            if (((MaskedTextBox)patron[0]).Text != "")
            {
                  restriccion =  " n_estado_usuario Like '%" + ((MaskedTextBox)patron[0]).Text + "%'";
                sql = @"SELECT id_estado_usuario, n_estado_usuario
                                       FROM EstadosUsuarios
                                       WHERE " + restriccion;
                return _BD.EjecutarSelct(sql);
            }

            object[] id = ctr.Find("txt_id", true);
            if (((MaskedTextBox)id[0]).Text != "")
            {
                restriccion = " id_estado_usuario = " + ((MaskedTextBox)id[0]).Text;
                sql = @"SELECT id_estado_usuario, n_estado_usuario
                                       FROM EstadosUsuarios
                                       WHERE " + restriccion;
                return _BD.EjecutarSelct(sql);
            }

            var chk = ctr.Find("chk_todos", true);
            if (((CheckBox)chk[0]).Checked == true)
            {
                sql = @"SELECT id_estado_usuario, n_estado_usuario
                                       FROM EstadosUsuarios";
                return _BD.EjecutarSelct(sql);
            }
            return tabla;
        }
        public void Insertar (string id_estado, string nombre)
        {
            string sqlInsert = @"INSERT INTO EstadosUsuarios
                               (id_estado_usuario, n_estado_usuario) VALUES
                               (" + id_estado.Trim() + ", " 
                               + _TE.DatosTexto(nombre) + ")";
           if(_BD.Insertar(sqlInsert)== Conexion_BD.TipoEstado.error)
            {
                MessageBox.Show("No se grabó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           else
            {
                MessageBox.Show("Se grabó correctamente");
            }

        }
        public void Modificar (string id_estado, string nombre)
        {
            string sqlModificar = @"UPDATE EstadosUsuarios 
                                    SET n_estado_usuario = " + _TE.DatosTexto(nombre)
                                    + " WHERE id_estado_usuario = " + id_estado.Trim();
            if(_BD.Modificar(sqlModificar)== Conexion_BD.TipoEstado.error)
            {
                MessageBox.Show("No se modificó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Se modificó correctamente");
            }
        }
    }
}
