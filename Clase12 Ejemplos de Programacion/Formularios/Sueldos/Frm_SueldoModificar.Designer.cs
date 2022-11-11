namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    partial class Frm_SueldoModificar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SueldoModificar));
            this.buttonModificar1 = new Clase12_Ejemplos_de_Programacion.clases.ButtonModificar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chk_controlDescuentos = new System.Windows.Forms.CheckBox();
            this.chk_controlAsignaciones = new System.Windows.Forms.CheckBox();
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
            this.lbl_titulo1._Titulo = "Modificar Liquidación Sueldo";
            this.lbl_titulo1.Size = new System.Drawing.Size(400, 32);
            this.lbl_titulo1.Text = "Modificar Liquidación Sueldo";
            // 
            // btn_ok
            // 
            this.btn_ok.Visible = false;
            // 
            // txt_mes
            // 
            this.txt_mes.Enabled = false;
            // 
            // txt_anno
            // 
            this.txt_anno.Enabled = false;
            // 
            // buttonModificar1
            // 
            this.buttonModificar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModificar1.BackgroundImage")));
            this.buttonModificar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModificar1.Location = new System.Drawing.Point(457, 485);
            this.buttonModificar1.Name = "buttonModificar1";
            this.buttonModificar1.Size = new System.Drawing.Size(41, 41);
            this.buttonModificar1.TabIndex = 48;
            this.toolTip1.SetToolTip(this.buttonModificar1, "Si oprime el control se modifica los registros");
            this.buttonModificar1.UseVisualStyleBackColor = true;
            this.buttonModificar1.Click += new System.EventHandler(this.buttonModificar1_Click);
            // 
            // chk_controlDescuentos
            // 
            this.chk_controlDescuentos.AutoSize = true;
            this.chk_controlDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_controlDescuentos.Location = new System.Drawing.Point(531, 244);
            this.chk_controlDescuentos.Name = "chk_controlDescuentos";
            this.chk_controlDescuentos.Size = new System.Drawing.Size(94, 21);
            this.chk_controlDescuentos.TabIndex = 51;
            this.chk_controlDescuentos.Text = "Controlar";
            this.chk_controlDescuentos.UseVisualStyleBackColor = true;
            // 
            // chk_controlAsignaciones
            // 
            this.chk_controlAsignaciones.AutoSize = true;
            this.chk_controlAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_controlAsignaciones.Location = new System.Drawing.Point(531, 12);
            this.chk_controlAsignaciones.Name = "chk_controlAsignaciones";
            this.chk_controlAsignaciones.Size = new System.Drawing.Size(94, 21);
            this.chk_controlAsignaciones.TabIndex = 52;
            this.chk_controlAsignaciones.Text = "Controlar";
            this.chk_controlAsignaciones.UseVisualStyleBackColor = true;
            // 
            // Frm_SueldoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(971, 537);
            this.Controls.Add(this.chk_controlDescuentos);
            this.Controls.Add(this.chk_controlAsignaciones);
            this.Controls.Add(this.buttonModificar1);
            this.Name = "Frm_SueldoModificar";
            this.Load += new System.EventHandler(this.Frm_SueldoModificar_Load);
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
            this.Controls.SetChildIndex(this.buttonModificar1, 0);
            this.Controls.SetChildIndex(this.chk_controlAsignaciones, 0);
            this.Controls.SetChildIndex(this.chk_controlDescuentos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private clases.ButtonModificar buttonModificar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chk_controlDescuentos;
        private System.Windows.Forms.CheckBox chk_controlAsignaciones;
    }
}
