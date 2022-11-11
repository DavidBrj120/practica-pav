namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    partial class Frm_SueldoBorrar
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SueldoBorrar));
            this.btn_borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_estados
            // 
            this.cmb_estados.DisplayMember = "n_estado_usuario";
            this.cmb_estados.ValueMember = "id_estado_usuario";
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.DisplayMember = "nombre";
            this.cmb_perfiles.ValueMember = "id_perfil";
            // 
            // bus_usuario
            // 
            this.bus_usuario.Enabled = false;
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1._Titulo = "Borrar Liquidación Sueldo";
            this.lbl_titulo1.Size = new System.Drawing.Size(364, 32);
            this.lbl_titulo1.Text = "Borrar Liquidación Sueldo";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            // 
            // txt_mes
            // 
            this.txt_mes.Enabled = false;
            // 
            // txt_anno
            // 
            this.txt_anno.Enabled = false;
            // 
            // buscar_asignacion
            // 
            this.buscar_asignacion.Enabled = false;
            // 
            // txt_cantidad_asignacion
            // 
            this.txt_cantidad_asignacion.Enabled = false;
            // 
            // btn_agreaga_asignacion
            // 
            this.btn_agreaga_asignacion.Enabled = false;
            // 
            // Btn_AgregarDEscuentos
            // 
            this.Btn_AgregarDEscuentos.Enabled = false;
            // 
            // txt_cantidad_descuentos
            // 
            this.txt_cantidad_descuentos.Enabled = false;
            // 
            // buscarDescuentos
            // 
            this.buscarDescuentos.Enabled = false;
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Visible = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::Clase12_Ejemplos_de_Programacion.Properties.Resources.eliminar;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(459, 485);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(49, 33);
            this.btn_borrar.TabIndex = 48;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // Frm_SueldoBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(971, 530);
            this.Controls.Add(this.btn_borrar);
            this.Name = "Frm_SueldoBorrar";
            this.Load += new System.EventHandler(this.Frm_SueldoBorrar_Load);
            this.Controls.SetChildIndex(this.txt_neto, 0);
            this.Controls.SetChildIndex(this.txt_bruto, 0);
            this.Controls.SetChildIndex(this.txt_n_usuario, 0);
            this.Controls.SetChildIndex(this.txt_password, 0);
            this.Controls.SetChildIndex(this.txt_email, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.txt_cuil, 0);
            this.Controls.SetChildIndex(this.cmb_perfiles, 0);
            this.Controls.SetChildIndex(this.cmb_estados, 0);
            this.Controls.SetChildIndex(this.bus_usuario, 0);
            this.Controls.SetChildIndex(this.lbl_titulo1, 0);
            this.Controls.SetChildIndex(this.btn_ok, 0);
            this.Controls.SetChildIndex(this.txt_fecha, 0);
            this.Controls.SetChildIndex(this.txt_mes, 0);
            this.Controls.SetChildIndex(this.txt_anno, 0);
            this.Controls.SetChildIndex(this.Txt_sueldo, 0);
            this.Controls.SetChildIndex(this.buscar_asignacion, 0);
            this.Controls.SetChildIndex(this.txt_cantidad_asignacion, 0);
            this.Controls.SetChildIndex(this.btn_agreaga_asignacion, 0);
            this.Controls.SetChildIndex(this.buscarDescuentos, 0);
            this.Controls.SetChildIndex(this.txt_cantidad_descuentos, 0);
            this.Controls.SetChildIndex(this.Btn_AgregarDEscuentos, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrar;
    }
}
