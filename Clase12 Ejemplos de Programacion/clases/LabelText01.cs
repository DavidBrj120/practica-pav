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
    public partial class LabelText01 : UserControl
    {
     
        public string _Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public string _columna { get; set; }
        public string _MensajeError { get; set; }
        public bool _Validable { get; set; }
		
        public string _Mask 
       {
            get { return TxtDato.Mask; }
            set { TxtDato.Mask = value; }
        }
        public string _TextSM
        {
            get
            {
                TxtDato.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                return TxtDato.Text;
            }

        }
        public string _Text
        {
            get
            {
                TxtDato.TextMaskFormat = MaskFormat.IncludeLiterals;
                return TxtDato.Text;
            }
            set { TxtDato.Text = value; }
        }

        public bool _ReadOnly
        {
            get => TxtDato.ReadOnly;
            set => TxtDato.ReadOnly = value;
        }

        ContextMenuStrip _contextual = new ContextMenuStrip();


        public LabelText01()
        {
            InitializeComponent();
            this.TxtDato.ContextMenuStrip = _contextual;
          
            _contextual.Items.Add("Borrar",null, ClicBorrar);
            _contextual.Items.Add("FechaHoy",null, FechaHoy);
        }
        private void ClicBorrar(object sender, EventArgs e)
        {
            this.TxtDato.Text = "";
        }
        private void FechaHoy(object sender, EventArgs e)
        {
            this._Mask = "99/99/9999";
            this.TxtDato.Text = DateTime.Now.ToString();
        }
        public void _Blanquear()
        {
            this.TxtDato.Text = "";
        }
 
    }
}
