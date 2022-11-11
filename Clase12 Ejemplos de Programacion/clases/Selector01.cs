using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clase12_Ejemplos_de_Programacion.clases
{
    public partial class Selector01 : UserControl
    {
        public enum visible { combo, id, texto}
        public string _Etiqueta
        {
            get { return lbl_etiqueta.Text; }
            set { lbl_etiqueta.Text = value; }
        }
        public bool _Validable { get; set; }
        public string _columna { get; set; }
        public string _MensajeError { get; set; }
        //public bool _blanquear
        //{
        //    set
        //    {
        //        if (value == true)
        //        {
        //            txt_descripcion.Text = "";
        //            txt_id.Text = "";
        //        }
        //    }
        //}

        public string _Text
        {
            get { return txt_id.Text; }
            set
            {
                txt_id.Text = value;
            }
        }
        public string _descripcion { get; set; } = "descripcion";
        public string _pk { get; set; } = "pk";
        public DataTable _tabla { get; set; }

        public string _descriptor => txt_descripcion.Text;

        public Selector01()
        {
            InitializeComponent();
        }

        private void txt_id_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                BuscarXId(txt_id.Text);
            }
        }
        private void txt_descripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter || e.KeyValue == (char)Keys.Tab)
            {
                BuscarXDescripcion(txt_descripcion.Text);
            }
        }

        private void BuscarXDescripcion(string txt_buscar)
        {
            DataRow[] Resultado;
            Resultado = _tabla.Select(_descripcion + " like '%" + txt_buscar.Trim() + "%'", _descripcion);
            
            switch (Resultado.Length)
            {
                case 1:
                    txt_id.Text = Resultado[0][_pk].ToString();
                    txt_descripcion.Text = Resultado[0][_descripcion].ToString();
                    Visibilidad(visible.id);
                    break;
                case 0:
                    cmb_combo.Cargar(_tabla, _pk, _descripcion);
                    Visibilidad(visible.combo);
                    break;
                 default:
                    cmb_combo.Cargar(Resultado, _pk, _descripcion);
                    Visibilidad(visible.combo);
                    break;
            }
        }
        public void BuscarXId(string txt_id)
        {
            DataRow[] Resultado;
            Resultado = _tabla.Select(_pk + " = " + txt_id.Trim(), _descripcion);
            switch (Resultado.Length)
            {
                case 1:
                    this.txt_id.Text = Resultado[0][_pk].ToString();
                    txt_descripcion.Text = Resultado[0][_descripcion].ToString();
                    Visibilidad(visible.id);
                    break;
                case 0:
                    cmb_combo.Cargar(_tabla, _pk, _descripcion);
                    Visibilidad(visible.combo);
                    break;
                default:
                    cmb_combo.Cargar(Resultado, _pk, _descripcion);
                    Visibilidad(visible.combo);
                    break;
            }
        }
        private void Visibilidad(visible que_ver)
        {
            switch (que_ver)
            {
                case visible.combo:
                    cmb_combo.Visible = true;
                    txt_id.Visible = false;
                    txt_descripcion.Visible = false;
                    btn_buscar.Visible = false;
                    cmb_combo.DroppedDown = true;
                    Cursor.Position = PointToScreen(this.cmb_combo.Location);
                    cmb_combo.Cursor = Cursors.Hand;
                    break;
                case visible.id:
                    cmb_combo.Visible = false;
                    txt_id.Visible = true;
                    txt_descripcion.Visible = true;
                    btn_buscar.Visible = true;
                    txt_id.Width = 52;
                    break;
                case visible.texto:
                    cmb_combo.Visible = false;
                    txt_id.Visible = true;
                    txt_descripcion.Visible = false;
                    btn_buscar.Visible = true;
                    txt_id.Width = txt_id.Width + txt_descripcion.Width;
                    break;
                default:
                    break;
            }
        }

        private void cmb_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_combo.SelectedValue is null)
                return; 
            txt_id.Text = cmb_combo.SelectedValue.ToString();
            BuscarXId(txt_id.Text);
            Visibilidad(visible.id);
            txt_id.Focus();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cmb_combo.Cargar(_tabla, _pk, _descripcion);
            Visibilidad(visible.combo);
        }
        public void _Blanquear()
        {
            txt_descripcion.Text = "";
            txt_id.Text = "";
        }

 
    }
}
