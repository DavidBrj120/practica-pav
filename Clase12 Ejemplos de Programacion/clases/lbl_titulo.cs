using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Clase12_Ejemplos_de_Programacion.clases
{
    public class lbl_titulo : Label
    {
        public string _Titulo
        {
            get { return this.Text; }
            set
            {
                this.Text = value;
            }
        }
        public string _Tamaño
        {
            get { return this.Font.Size.ToString(); }
            set
            {
                this.Font = new Font("Arial", float.Parse(value), FontStyle.Bold);
            }
        }
        

        

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
