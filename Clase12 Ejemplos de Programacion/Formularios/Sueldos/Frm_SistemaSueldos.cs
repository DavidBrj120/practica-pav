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

namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    public partial class Frm_SistemaSueldos : Form
    {

        public Frm_SistemaSueldos()
        {
            InitializeComponent();
        }

        private void rb_id_usuario_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            Accion(rb.Text);
        }
        private void Accion(string seleccion)
        {
            Selector._Blanquear();
            switch (seleccion)
            {
                case "Id_usuario":
                    Selector._Etiqueta = "Usuarios";
                    this.Txt_Apellido.Visible = false;
                    this.Txt_anno.Visible = false;
                    this.Txt_mes.Visible = false;
                    this.Selector.Visible = true;
                    this.Selector.Focus();
                    break;
                case "Perfil":
                    Selector._Etiqueta = "Perfil";
                    this.Txt_Apellido.Visible = false;
                    this.Txt_anno.Visible = false;
                    this.Txt_mes.Visible = false;
                    this.Selector.Visible = true;
                    this.Selector.Focus();
                    break;
                case "Apellido":
                    this.Selector.Visible = false;
                    this.Txt_anno.Visible = false;
                    this.Txt_mes.Visible = false;
                    this.Txt_Apellido.Visible = true;
                    this.Txt_Apellido.Focus();
                    break;
                case "Mes/Año":
                    this.Selector.Visible = false;
                    this.Txt_Apellido.Visible = false;
                    this.Txt_anno.Visible = true;
                    this.Txt_mes.Visible = true;
                    this.Txt_mes.Focus();
                    break;
                case "Todos":
                    this.Selector.Visible = false;
                    this.Txt_Apellido.Visible = false;
                    this.Txt_anno.Visible = false;
                    this.Txt_mes.Visible = false;
                    break;
            }
        }

        private void Frm_SistemaSueldos_Load(object sender, EventArgs e)
        {
            this.Location = new Point(4, 57);
            Grid01.Formatear("Id Usuario,100,C; Apellido y Nombre, 300,I; Año, 70,C; Mes, 50,C; Montro, 100, D");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private string Seleccionado ()
        {
            foreach (var item in panel1.Controls)
            {
                string tipoControl = item.GetType().Name;
                if(tipoControl=="RadioButton")
                {
                    RadioButton rb = item as RadioButton;
                    if (rb.Checked == true)
                        return rb.Text;
                }
            }
            return "";
        }
        private void Buscar()
        {
            Ne_Sueldos Sueldo = new Ne_Sueldos();
            DataTable Tabla = new DataTable();
            string seleccion = Seleccionado();
            switch (seleccion)
            {
                case "Id_usuario":
                    Tabla = Sueldo._BuscarSueldosCosulta("Id_usuario", this.Selector._Text);
                    break;
                case "Perfil":
                    Tabla = Sueldo._BuscarSueldosCosulta("Perfil", this.Selector._Text);
                    break;
                case "Apellido":
                    Tabla = Sueldo._BuscarSueldosCosulta("Apellido", this.Txt_Apellido._Text);
                    break;
                case "Todos":
                    Tabla = Sueldo._BuscarSueldosCosulta("Todos");
                    break;
                case "Mes/Año":
                    Tabla = Sueldo._BuscarSueldosConsulta("Mes/Año", Txt_mes._Text, Txt_anno._Text);
                    break;
                case "":
                    break;
            }

            Grid01.Cargar(Tabla);
            if (Tabla.Rows.Count == 0)
                MessageBox.Show("No hay registro para mostrar");
        }
        private void buttonModificar1_Click(object sender, EventArgs e)
        {
            Frm_SueldoModificar Modificar = new Frm_SueldoModificar();

            if (Grid01.Rows.Count==0)
            {
                MessageBox.Show("No seleccionó registro en la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Modificar.Id_usuario = Grid01.CurrentRow.Cells[0].Value.ToString();
            Modificar.Mes = Grid01.CurrentRow.Cells[3].Value.ToString();
            Modificar.Anno = Grid01.CurrentRow.Cells[2].Value.ToString();
            Modificar.ShowDialog();
        }

        private void buttonNuevo1_Click(object sender, EventArgs e)
        {
            Frm_SueldoAlta SueldoAlta = new Frm_SueldoAlta();
            SueldoAlta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_SueldoBorrar Borrar = new Frm_SueldoBorrar();

            if (Grid01.Rows.Count == 0)
            {
                MessageBox.Show("No seleccionó registro en la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Borrar.Id_usuario = Grid01.CurrentRow.Cells[0].Value.ToString();
            Borrar.Mes = Grid01.CurrentRow.Cells[3].Value.ToString();
            Borrar.Anno = Grid01.CurrentRow.Cells[2].Value.ToString();
            Borrar.ShowDialog();
            Buscar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
