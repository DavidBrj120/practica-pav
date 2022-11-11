namespace Clase12_Ejemplos_de_Programacion.clases
{
    partial class Selector01
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
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_combo = new Clase12_Ejemplos_de_Programacion.clases.ComboBox01();
            this.txt_id = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_etiqueta
            // 
            this.lbl_etiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etiqueta.Location = new System.Drawing.Point(4, 7);
            this.lbl_etiqueta.Name = "lbl_etiqueta";
            this.lbl_etiqueta.Size = new System.Drawing.Size(123, 18);
            this.lbl_etiqueta.TabIndex = 0;
            this.lbl_etiqueta.Text = "label1";
            this.lbl_etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(189, 2);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(150, 26);
            this.txt_descripcion.TabIndex = 3;
            this.txt_descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descripcion_KeyDown);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackgroundImage = global::Clase12_Ejemplos_de_Programacion.Properties.Resources.buscar1;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(341, 1);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(30, 27);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cmb_combo
            // 
            this.cmb_combo._columna = null;
            this.cmb_combo._MensajeError = null;
            this.cmb_combo._Validable = false;
            this.cmb_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_combo.FormattingEnabled = true;
            this.cmb_combo.Location = new System.Drawing.Point(134, 2);
            this.cmb_combo.Name = "cmb_combo";
            this.cmb_combo.Size = new System.Drawing.Size(237, 28);
            this.cmb_combo.TabIndex = 5;
            this.cmb_combo.Visible = false;
            this.cmb_combo.SelectionChangeCommitted += new System.EventHandler(this.cmb_combo_SelectionChangeCommitted);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(134, 2);
            this.txt_id.Mask = "9999";
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(49, 26);
            this.txt_id.TabIndex = 6;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress_1);
            // 
            // Selector01
            // 
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_etiqueta);
            this.Controls.Add(this.cmb_combo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Selector01";
            this.Size = new System.Drawing.Size(374, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label lbl_etiqueta;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_buscar;
        private Clase12_Ejemplos_de_Programacion.clases.ComboBox01 cmb_combo;
        private System.Windows.Forms.MaskedTextBox txt_id;
    }
}
