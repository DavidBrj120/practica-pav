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

namespace Clase12_Ejemplos_de_Programacion.Formularios
{
    public partial class Frm_Base_Selector : Form
    {
        public string _titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }
        public string _Id { get; set; }
        public string _Descripcion { get; set; }
        public CargaCombo _DatosCombo { get; set; }

        public Frm_Base_Selector()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmb_usuarios.Cargar(usuario.ComboUsuarios());
            cmb_.Cargar(_DatosCombo);
        }

        private void cmb__SelectionChangeCommitted(object sender, EventArgs e)
        {
            _Id = cmb_.SelectedValue.ToString();
            _Descripcion = cmb_.Text;
            this.Close();
        }
    }
}
