namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    partial class Frm_SueldoAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SueldoAlta));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonGrabar2 = new Clase12_Ejemplos_de_Programacion.clases.ButtonGrabar();
            this.buttonNuevo21 = new Clase12_Ejemplos_de_Programacion.clases.ButtonNuevo2();
            this.chk_controlAsignaciones = new System.Windows.Forms.CheckBox();
            this.chk_controlDescuentos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmb_estados
            // 
            this.cmb_estados.DisplayMember = "Descripcion";
            this.cmb_estados.ValueMember = "Pk";
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.DisplayMember = "Descripcion";
            this.cmb_perfiles.ValueMember = "Pk";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1._Titulo = "Alta de Sueldo";
            this.lbl_titulo1.Size = new System.Drawing.Size(206, 32);
            this.lbl_titulo1.Text = "Alta de Sueldo";
            // 
            // buscar_asignacion
            // 
            this.buscar_asignacion._Etiqueta = "Asignación";
            this.buscar_asignacion.Location = new System.Drawing.Point(590, 22);
            this.buscar_asignacion.Size = new System.Drawing.Size(375, 31);
            // 
            // txt_cantidad_asignacion
            // 
            this.txt_cantidad_asignacion.Location = new System.Drawing.Point(539, 50);
            // 
            // txt_cantidad_descuentos
            // 
            this.txt_cantidad_descuentos.Location = new System.Drawing.Point(532, 281);
            // 
            // buscarDescuentos
            // 
            this.buscarDescuentos.Location = new System.Drawing.Point(590, 253);
            this.buscarDescuentos.Size = new System.Drawing.Size(375, 31);
            // 
            // buttonGrabar2
            // 
            this.buttonGrabar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGrabar2.BackgroundImage")));
            this.buttonGrabar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGrabar2.Location = new System.Drawing.Point(457, 485);
            this.buttonGrabar2.Name = "buttonGrabar2";
            this.buttonGrabar2.Size = new System.Drawing.Size(41, 41);
            this.buttonGrabar2.TabIndex = 48;
            this.toolTip1.SetToolTip(this.buttonGrabar2, "Graba Nueva Liquidación de Sueldos ");
            this.buttonGrabar2.UseVisualStyleBackColor = true;
            this.buttonGrabar2.Click += new System.EventHandler(this.buttonGrabar2_Click);
            // 
            // buttonNuevo21
            // 
            this.buttonNuevo21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNuevo21.BackgroundImage")));
            this.buttonNuevo21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNuevo21.Location = new System.Drawing.Point(412, 485);
            this.buttonNuevo21.Name = "buttonNuevo21";
            this.buttonNuevo21.Size = new System.Drawing.Size(41, 41);
            this.buttonNuevo21.TabIndex = 49;
            this.toolTip1.SetToolTip(this.buttonNuevo21, "Blanquea el Formulario par Nueva Carga");
            this.buttonNuevo21.UseVisualStyleBackColor = true;
            this.buttonNuevo21.Click += new System.EventHandler(this.buttonNuevo21_Click);
            // 
            // chk_controlAsignaciones
            // 
            this.chk_controlAsignaciones.AutoSize = true;
            this.chk_controlAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_controlAsignaciones.Location = new System.Drawing.Point(539, 12);
            this.chk_controlAsignaciones.Name = "chk_controlAsignaciones";
            this.chk_controlAsignaciones.Size = new System.Drawing.Size(94, 21);
            this.chk_controlAsignaciones.TabIndex = 50;
            this.chk_controlAsignaciones.Text = "Controlar";
            this.chk_controlAsignaciones.UseVisualStyleBackColor = true;
            // 
            // chk_controlDescuentos
            // 
            this.chk_controlDescuentos.AutoSize = true;
            this.chk_controlDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_controlDescuentos.Location = new System.Drawing.Point(539, 243);
            this.chk_controlDescuentos.Name = "chk_controlDescuentos";
            this.chk_controlDescuentos.Size = new System.Drawing.Size(94, 21);
            this.chk_controlDescuentos.TabIndex = 50;
            this.chk_controlDescuentos.Text = "Controlar";
            this.chk_controlDescuentos.UseVisualStyleBackColor = true;
            // 
            // Frm_SueldoAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(971, 528);
            this.Controls.Add(this.chk_controlDescuentos);
            this.Controls.Add(this.chk_controlAsignaciones);
            this.Controls.Add(this.buttonNuevo21);
            this.Controls.Add(this.buttonGrabar2);
            this.Name = "Frm_SueldoAlta";
            this.Load += new System.EventHandler(this.Frm_SueldoAlta_Load);
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
            this.Controls.SetChildIndex(this.buttonGrabar2, 0);
            this.Controls.SetChildIndex(this.buttonNuevo21, 0);
            this.Controls.SetChildIndex(this.chk_controlAsignaciones, 0);
            this.Controls.SetChildIndex(this.chk_controlDescuentos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private clases.ButtonGrabar buttonGrabar2;
        private clases.ButtonNuevo2 buttonNuevo21;
        private System.Windows.Forms.CheckBox chk_controlAsignaciones;
        private System.Windows.Forms.CheckBox chk_controlDescuentos;
    }
}
