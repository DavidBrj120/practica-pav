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

namespace Clase12_Ejemplos_de_Programacion.inicio
{
    public partial class Frm_Login : Form
    {
        public enum Estado { correcto, error }

        public string Pp_usuario
        {
            get { return Txt_usuario.Text; }
            set { Txt_usuario.Text = value; }
        }
        public string Pp_password
        {
            get { return Txt_password.Text; }
            set { Txt_password.Text = value;}
        }
        public Estado ValorEstado { get; set; } = Estado.correcto;
        
            

       

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            if (Txt_usuario.Text == "")
            {
                MessageBox.Show("El usuario está vacío");
                Txt_usuario.Focus();
                return;
            }
            if (Txt_password.Text=="")
            {
                MessageBox.Show("El password está vacío");
                Txt_password.Focus();
                return;
            }
            Ne_Usuarios usu = new Ne_Usuarios();
            if (usu.ValidarLogin(Txt_usuario.Text, Txt_password.Text)
                == Ne_Usuarios.respuesta.autozado)
            {
                ValorEstado = Estado.correcto;
                this.Close();
                return;
            }
            else
            {
                ValorEstado = Estado.error;
                MessageBox.Show("Este usuario y password no existen");
            }


        }

    }
}
