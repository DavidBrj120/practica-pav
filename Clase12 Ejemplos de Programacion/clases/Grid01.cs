using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;


namespace Clase12_Ejemplos_de_Programacion.clases
{
    public class Grid01 : DataGridView
    {
        public int _tamannoLetraHeader { get { return tamLetHeader; } set { tamLetHeader = value; } }
        public FontStyle _formatoLetraHeader { get { return forLet; } set { forLet = value; } }
        public int _tamannoLetraGrid { get { return tamLetGrid; } set { tamLetGrid = value; } }
        int tamLetGrid = 10;
        int tamLetHeader = 9;
        FontStyle forLet = FontStyle.Bold;

        // Nombre_cabecera, ancho, centrado;...
        public void Formatear(string formato)
        {
            // Saco del string de entrada <<formato>> las columnas con las que formateo la grilla
            string[] columnas = formato.Split(';');

            //Formatos de las letras de la grilla
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(Font.FontFamily, tamLetHeader, forLet);
            this.Font = new Font(Font.FontFamily, tamLetGrid);

            for (int i = 0; i < columnas.Length; i++)
            {
                string[] datos = columnas[i].Split(',');
                this.Columns.Add("columna" + i.ToString(), datos[0]);
                this.Columns[i].Width = int.Parse(datos[1]);
                if (datos.Length == 3)
                {
                    switch (datos[2].Trim())
                    {
                        case "I":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            break;
                        case "D":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "C":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        default:
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            break;
                    }
                }
            }
        }
        public void Cargar(DataTable tabla)
        {
            this.Rows.Clear();
            for (int fila = 0; fila < tabla.Rows.Count; fila++)
            {
                this.Rows.Add();
                for (int columna = 0; columna < tabla.Columns.Count; columna++)
                {
                    this.Rows[fila].Cells[columna].Value = tabla.Rows[fila][columna];
                }
            }
        }
        public void _Blanquear()
        {
            this.Rows.Clear();
        }
    }
}
