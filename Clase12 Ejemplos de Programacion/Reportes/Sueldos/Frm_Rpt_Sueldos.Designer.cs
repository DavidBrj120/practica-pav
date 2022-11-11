namespace Clase12_Ejemplos_de_Programacion.Reportes.Sueldos
{
    partial class Frm_Rpt_Sueldos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Sueldos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sel_Usuario = new Clase12_Ejemplos_de_Programacion.clases.Selector01();
            this.btn_buscar = new Clase12_Ejemplos_de_Programacion.clases.ButtonBuscar();
            this.txt_periodo01 = new Clase12_Ejemplos_de_Programacion.clases.LabelText01();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar02 = new Clase12_Ejemplos_de_Programacion.clases.ButtonBuscar();
            this.txt_periodo02 = new Clase12_Ejemplos_de_Programacion.clases.LabelText01();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rv03 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rb_descuentos = new System.Windows.Forms.RadioButton();
            this.rb_asignaciones = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.btn_buscar03 = new Clase12_Ejemplos_de_Programacion.clases.ButtonBuscar();
            this.txt_inicial = new Clase12_Ejemplos_de_Programacion.clases.LabelText01();
            this.txt_final = new Clase12_Ejemplos_de_Programacion.clases.LabelText01();
            this.lbl_titulo1 = new Clase12_Ejemplos_de_Programacion.clases.lbl_titulo();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.Sel_Usuario);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.txt_periodo01);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Impresión de Sueldos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(6, 45);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(762, 354);
            this.rv01.TabIndex = 5;
            // 
            // Sel_Usuario
            // 
            this.Sel_Usuario._columna = null;
            this.Sel_Usuario._descripcion = "descripcion";
            this.Sel_Usuario._Etiqueta = "Usuarios";
            this.Sel_Usuario._MensajeError = null;
            this.Sel_Usuario._pk = "pk";
            this.Sel_Usuario._tabla = null;
            this.Sel_Usuario._Text = "";
            this.Sel_Usuario._Validable = false;
            this.Sel_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sel_Usuario.Location = new System.Drawing.Point(14, 8);
            this.Sel_Usuario.Name = "Sel_Usuario";
            this.Sel_Usuario.Size = new System.Drawing.Size(374, 31);
            this.Sel_Usuario.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(619, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(41, 41);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_periodo01
            // 
            this.txt_periodo01._columna = null;
            this.txt_periodo01._Etiqueta = "Periodo mes-año";
            this.txt_periodo01._Mask = "99-9999";
            this.txt_periodo01._MensajeError = null;
            this.txt_periodo01._ReadOnly = false;
            this.txt_periodo01._Text = "  -";
            this.txt_periodo01._Validable = false;
            this.txt_periodo01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_periodo01.Location = new System.Drawing.Point(355, 5);
            this.txt_periodo01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_periodo01.Name = "txt_periodo01";
            this.txt_periodo01.Size = new System.Drawing.Size(240, 35);
            this.txt_periodo01.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rv02);
            this.tabPage2.Controls.Add(this.btn_buscar02);
            this.tabPage2.Controls.Add(this.txt_periodo02);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Distribución de Asig / Desc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rv02
            // 
            this.rv02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv02.Location = new System.Drawing.Point(6, 48);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(763, 347);
            this.rv02.TabIndex = 2;
            // 
            // btn_buscar02
            // 
            this.btn_buscar02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar02.BackgroundImage")));
            this.btn_buscar02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar02.Location = new System.Drawing.Point(269, 3);
            this.btn_buscar02.Name = "btn_buscar02";
            this.btn_buscar02.Size = new System.Drawing.Size(41, 41);
            this.btn_buscar02.TabIndex = 1;
            this.btn_buscar02.UseVisualStyleBackColor = true;
            this.btn_buscar02.Click += new System.EventHandler(this.btn_buscar02_Click);
            // 
            // txt_periodo02
            // 
            this.txt_periodo02._columna = null;
            this.txt_periodo02._Etiqueta = "Periodo Liquidación";
            this.txt_periodo02._Mask = "99-9999";
            this.txt_periodo02._MensajeError = null;
            this.txt_periodo02._ReadOnly = false;
            this.txt_periodo02._Text = "  -";
            this.txt_periodo02._Validable = false;
            this.txt_periodo02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_periodo02.Location = new System.Drawing.Point(20, 5);
            this.txt_periodo02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_periodo02.Name = "txt_periodo02";
            this.txt_periodo02.Size = new System.Drawing.Size(243, 35);
            this.txt_periodo02.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rv03);
            this.tabPage3.Controls.Add(this.rb_descuentos);
            this.tabPage3.Controls.Add(this.rb_asignaciones);
            this.tabPage3.Controls.Add(this.rb_todos);
            this.tabPage3.Controls.Add(this.btn_buscar03);
            this.tabPage3.Controls.Add(this.txt_inicial);
            this.tabPage3.Controls.Add(this.txt_final);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(775, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Análisis en Rango de Períodos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rv03
            // 
            this.rv03.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv03.Location = new System.Drawing.Point(7, 55);
            this.rv03.Name = "rv03";
            this.rv03.ServerReport.BearerToken = null;
            this.rv03.Size = new System.Drawing.Size(762, 344);
            this.rv03.TabIndex = 7;
            // 
            // rb_descuentos
            // 
            this.rb_descuentos.AutoSize = true;
            this.rb_descuentos.Location = new System.Drawing.Point(577, 30);
            this.rb_descuentos.Name = "rb_descuentos";
            this.rb_descuentos.Size = new System.Drawing.Size(113, 24);
            this.rb_descuentos.TabIndex = 6;
            this.rb_descuentos.TabStop = true;
            this.rb_descuentos.Text = "Descuentos";
            this.rb_descuentos.UseVisualStyleBackColor = true;
            // 
            // rb_asignaciones
            // 
            this.rb_asignaciones.AutoSize = true;
            this.rb_asignaciones.Location = new System.Drawing.Point(454, 30);
            this.rb_asignaciones.Name = "rb_asignaciones";
            this.rb_asignaciones.Size = new System.Drawing.Size(122, 24);
            this.rb_asignaciones.TabIndex = 5;
            this.rb_asignaciones.TabStop = true;
            this.rb_asignaciones.Text = "Asignaciones";
            this.rb_asignaciones.UseVisualStyleBackColor = true;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(454, 8);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(223, 24);
            this.rb_todos.TabIndex = 4;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Asignaciones y Descuentos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // btn_buscar03
            // 
            this.btn_buscar03.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar03.BackgroundImage")));
            this.btn_buscar03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar03.Location = new System.Drawing.Point(721, 6);
            this.btn_buscar03.Name = "btn_buscar03";
            this.btn_buscar03.Size = new System.Drawing.Size(41, 41);
            this.btn_buscar03.TabIndex = 2;
            this.btn_buscar03.UseVisualStyleBackColor = true;
            this.btn_buscar03.Click += new System.EventHandler(this.btn_buscar03_Click);
            // 
            // txt_inicial
            // 
            this.txt_inicial._columna = null;
            this.txt_inicial._Etiqueta = "Periodo Inicial";
            this.txt_inicial._Mask = "99-9999";
            this.txt_inicial._MensajeError = null;
            this.txt_inicial._ReadOnly = false;
            this.txt_inicial._Text = "  -";
            this.txt_inicial._Validable = false;
            this.txt_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicial.Location = new System.Drawing.Point(7, 8);
            this.txt_inicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_inicial.Name = "txt_inicial";
            this.txt_inicial.Size = new System.Drawing.Size(240, 35);
            this.txt_inicial.TabIndex = 0;
            // 
            // txt_final
            // 
            this.txt_final._columna = null;
            this.txt_final._Etiqueta = "Periodo Final";
            this.txt_final._Mask = "99-9999";
            this.txt_final._MensajeError = null;
            this.txt_final._ReadOnly = false;
            this.txt_final._Text = "  -";
            this.txt_final._Validable = false;
            this.txt_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_final.Location = new System.Drawing.Point(192, 8);
            this.txt_final.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(241, 35);
            this.txt_final.TabIndex = 1;
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1._Tamaño = "18";
            this.lbl_titulo1._Titulo = "Resportes Sobre Sueldos";
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.Location = new System.Drawing.Point(13, 13);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(305, 29);
            this.lbl_titulo1.TabIndex = 1;
            this.lbl_titulo1.Text = "Resportes Sobre Sueldos";
            // 
            // Frm_Rpt_Sueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 478);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Rpt_Sueldos";
            this.Text = "Frm_Rpt_Sueldos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Sueldos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private clases.lbl_titulo lbl_titulo1;
        private clases.ButtonBuscar btn_buscar02;
        private clases.LabelText01 txt_periodo02;
        private System.Windows.Forms.TabPage tabPage3;
        private clases.ButtonBuscar btn_buscar03;
        private clases.LabelText01 txt_inicial;
        private clases.LabelText01 txt_final;
        private System.Windows.Forms.RadioButton rb_descuentos;
        private System.Windows.Forms.RadioButton rb_asignaciones;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.TabPage tabPage1;
        private clases.Selector01 Sel_Usuario;
        private clases.ButtonBuscar btn_buscar;
        private clases.LabelText01 txt_periodo01;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
        private Microsoft.Reporting.WinForms.ReportViewer rv03;
    }
}