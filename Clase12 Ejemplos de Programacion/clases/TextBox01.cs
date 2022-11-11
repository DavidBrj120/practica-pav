using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase12_Ejemplos_de_Programacion.clases
{
    public class TextBox01 : MaskedTextBox
    {
        public enum TipoDato { texto, numero, fecha }

        public string _columna { get; set; }
        public string _MensajeError { get; set; }
        public bool _Validable { get; set; }
  
    }
     
}
