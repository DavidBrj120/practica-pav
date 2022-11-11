using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.negocios;
using Clase12_Ejemplos_de_Programacion.clases;

namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    public partial class Frm_SueldoBase : Form
    {
        public string Id_usuario { get; set; }
        public string Mes { get; set; }
        public string Anno { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public Ne_Sueldos _sueldo = new Ne_Sueldos();
        Ne_SueldoPerfilHistorico _SPH = new Ne_SueldoPerfilHistorico();
        Ne_Usuarios _usuario = new Ne_Usuarios();

        public Frm_SueldoBase()
        {
            InitializeComponent();
        }

        public void btn_ok_Click(object sender, EventArgs e)
        {
            _TE.CargarFormulario(this.Controls, _usuario.RecuperarUsuarioXid(bus_usuario._Text));
            Txt_sueldo._Text = _SPH.RecuperarUltimoSueldo(_usuario.RecuperarPerfilXid(bus_usuario._Text));
        }

        private void Frm_LiquidacionSueldos_Load(object sender, EventArgs e)
        {
            cmb_estados.Cargar(new Ne_EstadosUsuarios().DatosCombo());
            cmb_perfiles.Cargar(new Ne_perfiles().DatosCombo());
            GridAsignaciones.Formatear("Cantidad, 70,D;Id,50,C;Descripcion, 180,I;Monto,70,D");
            GridDescuentos.Formatear("Cantidad, 70,D;Id,50,C;Descripcion, 180,I;Monto,70,D");
            buscar_asignacion._tabla = new Ne_Asignaciones().Selector();
            buscarDescuentos._tabla = new Ne_Descuentos().Selector();
            bus_usuario._tabla = _usuario.Selector();
        }

        private void btn_agreaga_asignacion_Click(object sender, EventArgs e)
        {
            if (Txt_sueldo._TextSM.Length==0)
            {
                MessageBox.Show("No se recuperó ningún sueldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (buscar_asignacion._Text =="")
            {
                MessageBox.Show("Falta buscar una asignación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buscar_asignacion.Focus();
                return;
            }
            if (txt_cantidad_asignacion._Text=="")
            {
                MessageBox.Show("Falta la cantidad de la asignación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad_asignacion.Focus();
                return;
            }
            //-----VERIFICO QUE NO ESTE CARGADO YA EN LA GRILLA
            if (_VerificarAsignacion(GridAsignaciones, buscar_asignacion._Text))
            {
                MessageBox.Show("Esta asignación ya está cargada en la grilla");
                return;
            }
            //-----

            GridAsignaciones.Rows.Add();
            int fila = GridAsignaciones.Rows.Count - 1;
            GridAsignaciones.Rows[fila].Cells[0].Value = txt_cantidad_asignacion._Text;
            GridAsignaciones.Rows[fila].Cells[1].Value = buscar_asignacion._Text;
            GridAsignaciones.Rows[fila].Cells[2].Value = buscar_asignacion._descriptor;
            GridAsignaciones.Rows[fila].Cells[3].Value = new Ne_Asignaciones().RecuperarValorAsignacion(buscar_asignacion._Text);
            txt_bruto._Text = _sueldo._CalculaSueldoBruto(Txt_sueldo._Text, GridAsignaciones);
        }
        private bool _VerificarAsignacion(Grid01 grilla, string valor)
        {
            for (int i = 0; i < grilla.Rows.Count; i++)
            {
                if (grilla.Rows[i].Cells[1].Value.ToString() == valor)
                    return true;
            }
            return false;
        }
        private void Btn_AgregarDEscuentos_Click(object sender, EventArgs e)
        {
            if (Txt_sueldo._TextSM.Length==0)
            {
                MessageBox.Show("No se recuperó ningún sueldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (buscarDescuentos._Text == "")
            {
                MessageBox.Show("Falta buscar una descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buscarDescuentos.Focus();
                return;
            }
            if (txt_cantidad_descuentos._Text == "")
            {
                MessageBox.Show("Falta la cantidad del descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad_descuentos.Focus();
                return;
            }
            //-----VERIFICO QUE NO ESTE CARGADO YA EN LA GRILLA
            if (_VerificarAsignacion(GridDescuentos, buscarDescuentos._Text))
            {
                MessageBox.Show("Este descuento ya está cargada en la grilla");
                return;
            }
            //-----
            Ne_Descuentos _Des = new Ne_Descuentos();
            GridDescuentos.Rows.Add();
            int fila = GridDescuentos.Rows.Count - 1;
            //--------------------
            GridDescuentos.Rows[fila].Cells[0].Value = txt_cantidad_descuentos._Text;
            // error manejado para ver en transaccion SE DEBE SUSTITUIR CON LA LINEA COMENTADA  
            // LA QUE ESTÁ POR ENCIMA DEL COMENTARIO
            //GridDescuentos.Rows[fila].Cells[0].Value = " ";
            //--------------------
            GridDescuentos.Rows[fila].Cells[1].Value = buscarDescuentos._Text;
            GridDescuentos.Rows[fila].Cells[2].Value = buscarDescuentos._descriptor;
            if(double.Parse(_Des.RecuperarValorDescuento(buscarDescuentos._Text))==0)
            {
                double CalculaDescuento = double.Parse(Txt_sueldo._Text.Replace(".",",")) *
                                          double.Parse(_Des.RecuperarPorcentajeDescuento(buscarDescuentos._Text));
                GridDescuentos.Rows[fila].Cells[3].Value = CalculaDescuento.ToString("#0.00");
            }
            else
            {
                GridDescuentos.Rows[fila].Cells[3].Value = _Des.RecuperarValorDescuento(buscarDescuentos._Text);
            }
            txt_neto._Text = _sueldo._CalculaSueldoNeto(Txt_sueldo._Text, GridAsignaciones, GridDescuentos);
        }

        private void GridAsignaciones_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Está seguro de borrar la asignación","Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                GridAsignaciones.Rows.Remove(GridAsignaciones.CurrentRow);

        }

        private void GridDescuentos_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de borrar el descuento", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                GridDescuentos.Rows.Remove(GridDescuentos.CurrentRow);

        }
        public void CargarFormulario()
        {
            _TE.CargarFormulario(this.Controls, _usuario.RecuperarUsuarioXid(Id_usuario));
            bus_usuario.BuscarXId(Id_usuario);
            DataTable Tabla = new DataTable();
            Tabla =  _sueldo.RecuperarLiquidacion(Id_usuario, Mes, Anno);
            Txt_sueldo._Text = Tabla.Rows[0][0].ToString();
            txt_fecha._Text = Tabla.Rows[0][1].ToString();
            txt_mes._Text = Tabla.Rows[0][2].ToString();
            txt_anno._Text = Tabla.Rows[0][3].ToString();
            GridAsignaciones.Cargar(new Ne_SueldoAsignacion().RecuperarAsinaciones(
                                    Id_usuario, Mes, Anno));
            txt_bruto._Text = _sueldo._CalculaSueldoBruto(Txt_sueldo._Text, GridAsignaciones);

            GridDescuentos.Cargar(new Ne_SueldoDescuento().RecuperarDescuentos(
                             Id_usuario, Mes, Anno));
            txt_neto._Text = _sueldo._CalculaSueldoNeto(Txt_sueldo._Text, GridAsignaciones, GridDescuentos);

        }

        private void label11_MouseMove(object sender, MouseEventArgs e)
        {
            label10.Text = this.Location.X.ToString() + ", " + this.Location.Y.ToString();
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void Frm_SueldoBase_Click(object sender, EventArgs e)
        {
            this.label10.Visible = true;

        }
    }
}
