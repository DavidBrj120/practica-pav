namespace Clase12_Ejemplos_de_Programacion.clases
{
    partial class SelecCuil
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_etiqueta = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.MaskedTextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_combo = new Clase12_Ejemplos_de_Programacion.clases.ComboBox01();
            this.SuspendLayout();
            // 
            // lbl_etiqueta
            // 
            this.lbl_etiqueta.Location = new System.Drawing.Point(4, 8);
            this.lbl_etiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_etiqueta.Name = "lbl_etiqueta";
            this.lbl_etiqueta.Size = new System.Drawing.Size(122, 20);
            this.lbl_etiqueta.TabIndex = 0;
            this.lbl_etiqueta.Text = "label1";
            this.lbl_etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(134, 5);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_clave.Mask = "99-99999999-9";
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(121, 26);
            this.txt_clave.TabIndex = 1;
            this.txt_clave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clave_KeyDown);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(263, 5);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(195, 26);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descripcion_KeyDown);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::Clase12_Ejemplos_de_Programacion.Properties.Resources.buscar1;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(466, 1);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(35, 30);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cmb_combo
            // 
            this.cmb_combo._columna = null;
            this.cmb_combo._MensajeError = null;
            this.cmb_combo._Validable = false;
            this.cmb_combo.FormattingEnabled = true;
            this.cmb_combo.Location = new System.Drawing.Point(134, 4);
            this.cmb_combo.Name = "cmb_combo";
            this.cmb_combo.Size = new System.Drawing.Size(325, 28);
            this.cmb_combo.TabIndex = 4;
            this.cmb_combo.Visible = false;
            this.cmb_combo.SelectionChangeCommitted += new System.EventHandler(this.cmb_combo_SelectionChangeCommitted);
            // 
            // SelecCuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.lbl_etiqueta);
            this.Controls.Add(this.cmb_combo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelecCuil";
            this.Size = new System.Drawing.Size(507, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_etiqueta;
        private System.Windows.Forms.MaskedTextBox txt_clave;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_buscar;
        private ComboBox01 cmb_combo;
    }
}
