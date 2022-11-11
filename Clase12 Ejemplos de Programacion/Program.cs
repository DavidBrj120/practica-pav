using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase12_Ejemplos_de_Programacion.Formularios;
using Clase12_Ejemplos_de_Programacion.Formularios.Usuarios;
using Clase12_Ejemplos_de_Programacion.Formularios.Sueldos;
using Clase12_Ejemplos_de_Programacion.Reportes.Usuarios;
using Clase12_Ejemplos_de_Programacion.Reportes.Sueldos;


namespace Clase12_Ejemplos_de_Programacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_Emplos_Programacion());
            //Application.Run(new Frm_Seleccionar());
            //Application.Run(new  Formularios.EstadosUsuarios.Frm_ABM_EstadosUsuarios());
            Application.Run(new inicio.Frm_Escritorio());
            //Application.Run(new Frm_Rpt_Sueldos() );

        }
    }
}
