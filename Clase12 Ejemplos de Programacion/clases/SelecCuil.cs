using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.negocios;

namespace Clase12_Ejemplos_de_Programacion.clases
{
    public partial class SelecCuil : UserControl
    {
        public enum ControlesInternos { combo, otros}
        public string _etiqueta
        {
            get { return lbl_etiqueta.Text; }
            set { lbl_etiqueta.Text = value; }
        }
        public bool _Validable { get; set; }
        public string _columna { get; set; }
        public string _MensajeError { get; set; }
        public bool _blanquear
        {
            set
            {
                if (value == true)
                {
                    txt_descripcion.Text = "";
                    txt_clave.Text = "";
                }
            }
        }
        // Punto de entrada y salida del dato principal del
        // control
        public string _Text
        {
            get { return txt_clave.Text; }
            set
            {
                txt_clave.Text = value;
            }
        }
        // Definición de la columnas de la tabla de entrada,
        // para este caso se asigna un valor por defecto que puede
        // ser cambiado externamente
        public string _descripcion { get; set; } = "descripcion";
        public string _pk { get; set; } = "pk";
        public string _cuil { get; set; } = "cuil";

        public DataTable _tabla { get; set; }

        public string _descriptor => txt_descripcion.Text;
        public SelecCuil()
        {
            InitializeComponent();
        }

        private void txt_clave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter || e.KeyValue == (char)Keys.Tab)
            {
                _Buscar(txt_clave.Text);
            }
        }
        // Permite la búsqueda de un dato externo ingresado en el 
        // parámetro del procedimiento 
        public void _Buscar(string cuil)
        {
            txt_clave.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txt_clave.Text == "")
                txt_clave.Text = cuil;

            txt_clave.Text = cuil;
            DataRow[] Resultado;
            Resultado = _tabla.Select(_cuil + " = " + cuil , _descripcion);
            switch (Resultado.Length)
            {
                case 0:
                    MessageBox.Show("No hay usuario con ese cuil");
                    break;
                case 1:
                    txt_descripcion.Text = Resultado[0][_descripcion].ToString();
                    break;
            }
        }
        private void txt_descripcion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.Enter || e.KeyValue == (char)Keys.Tab)
            {
                //txt_clave.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                DataRow[] Resultado;
                Resultado = _tabla.Select(_descripcion + " like " + "'%" + txt_descripcion.Text.Trim() + "%'", _descripcion);

                switch (Resultado.Length)
                {
                    case 1:
                        txt_clave.Text = Resultado[0]["cuil"].ToString();
                        txt_descripcion.Text = Resultado[0]["descripcion"].ToString();
                        break;
                    case 0:
                        MessageBox.Show("No hay usuarios con ese apellido");
                        break;
                    
                    default:
                        CambioEstado(ControlesInternos.combo);
                        cmb_combo.Cargar(Resultado, _pk, _descripcion);

                        break;
                }
                  
            }
        }
        private void CambioEstado(ControlesInternos _cont)
        {
            switch (_cont)
            {
                case ControlesInternos.combo:
                    txt_clave.Visible = false;
                    txt_descripcion.Visible = false;
                    btn_buscar.Visible = false;
                    cmb_combo.Visible = true;
                    cmb_combo.DroppedDown = true;
                    Cursor.Position = PointToScreen(this.cmb_combo.Location);
                    cmb_combo.Cursor = Cursors.Hand;
                    break;
                case ControlesInternos.otros:
                    txt_clave.Visible = true;
                    txt_descripcion.Visible = true;
                    btn_buscar.Visible = true;
                    cmb_combo.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void cmb_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] Resultado;
             Resultado = _tabla.Select(_pk+" = "+cmb_combo.SelectedValue.ToString());
            txt_clave.Text = Resultado[0]["cuil"].ToString();
            txt_descripcion.Text = Resultado[0]["descripcion"].ToString();
            CambioEstado(ControlesInternos.otros);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //DataTable tabla = new DataTable();
            cmb_combo.Cargar(_tabla, _pk, _descripcion);
            CambioEstado(ControlesInternos.combo);
        }
    }
 }

