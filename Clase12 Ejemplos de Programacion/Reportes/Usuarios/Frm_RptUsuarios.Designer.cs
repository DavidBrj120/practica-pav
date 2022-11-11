namespace Clase12_Ejemplos_de_Programacion.Reportes.Usuarios
{
    partial class Frm_RptUsuarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_buscar02 = new System.Windows.Forms.Button();
            this.rv = new Clase12_Ejemplos_de_Programacion.clases.ReportViewer01();
            this.rb_rango_id = new System.Windows.Forms.RadioButton();
            this.rb_x_letra = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.txt_restriccion = new Clase12_Ejemplos_de_Programacion.clases.LabelText01();
            this.lbl_titulo1 = new Clase12_Ejemplos_de_Programacion.clases.lbl_titulo();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_buscar01);
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte Simple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar01.Location = new System.Drawing.Point(684, 3);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(75, 26);
            this.btn_buscar01.TabIndex = 3;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = true;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(6, 35);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(765, 298);
            this.rv01.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_buscar02);
            this.tabPage2.Controls.Add(this.rv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mismo Reporte con Clase ReportViewer01";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_buscar02
            // 
            this.btn_buscar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar02.Location = new System.Drawing.Point(684, 3);
            this.btn_buscar02.Name = "btn_buscar02";
            this.btn_buscar02.Size = new System.Drawing.Size(75, 26);
            this.btn_buscar02.TabIndex = 12;
            this.btn_buscar02.Text = "Buscar";
            this.btn_buscar02.UseVisualStyleBackColor = true;
            this.btn_buscar02.Click += new System.EventHandler(this.btn_buscar02_Click_1);
            // 
            // rv
            // 
            this.rv._Datos = null;
            this.rv._Parametros = null;
            this.rv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv.Location = new System.Drawing.Point(7, 35);
            this.rv.Name = "rv";
            this.rv.ServerReport.BearerToken = null;
            this.rv.Size = new System.Drawing.Size(764, 305);
            this.rv.TabIndex = 11;
            // 
            // rb_rango_id
            // 
            this.rb_rango_id.AutoSize = true;
            this.rb_rango_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_rango_id.Location = new System.Drawing.Point(181, 38);
            this.rb_rango_id.Name = "rb_rango_id";
            this.rb_rango_id.Size = new System.Drawing.Size(199, 21);
            this.rb_rango_id.TabIndex = 3;
            this.rb_rango_id.TabStop = true;
            this.rb_rango_id.Text = "Restringido por rango de id\r\n";
            this.rb_rango_id.UseVisualStyleBackColor = true;
            this.rb_rango_id.CheckedChanged += new System.EventHandler(this.rb_rango_id_CheckedChanged);
            // 
            // rb_x_letra
            // 
            this.rb_x_letra.AutoSize = true;
            this.rb_x_letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_x_letra.Location = new System.Drawing.Point(20, 61);
            this.rb_x_letra.Name = "rb_x_letra";
            this.rb_x_letra.Size = new System.Drawing.Size(218, 21);
            this.rb_x_letra.TabIndex = 3;
            this.rb_x_letra.TabStop = true;
            this.rb_x_letra.Text = "Restringido por letra (apellido)\r\n";
            this.rb_x_letra.UseVisualStyleBackColor = true;
            this.rb_x_letra.CheckedChanged += new System.EventHandler(this.rb_x_letra_CheckedChanged);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_todos.Location = new System.Drawing.Point(20, 38);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(146, 21);
            this.rb_todos.TabIndex = 3;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos los usuarios";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // txt_restriccion
            // 
            this.txt_restriccion._columna = null;
            this.txt_restriccion._Etiqueta = "label1";
            this.txt_restriccion._Mask = "LLLLLLLLLL";
            this.txt_restriccion._MensajeError = null;
            this.txt_restriccion._ReadOnly = false;
            this.txt_restriccion._Text = "";
            this.txt_restriccion._Validable = false;
            this.txt_restriccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_restriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_restriccion.Location = new System.Drawing.Point(403, 50);
            this.txt_restriccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_restriccion.Name = "txt_restriccion";
            this.txt_restriccion.Size = new System.Drawing.Size(256, 35);
            this.txt_restriccion.TabIndex = 4;
            this.txt_restriccion.Visible = false;
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1._Tamaño = "16";
            this.lbl_titulo1._Titulo = "Reportes de Usuarios";
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.Location = new System.Drawing.Point(14, 9);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(233, 26);
            this.lbl_titulo1.TabIndex = 1;
            this.lbl_titulo1.Text = "Reportes de Usuarios";
            // 
            // Frm_RptUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.rb_rango_id);
            this.Controls.Add(this.rb_x_letra);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.txt_restriccion);
            this.Name = "Frm_RptUsuarios";
            this.Text = "Frm_ReportesUsuarios";
            this.Load += new System.EventHandler(this.Frm_ReportesUsuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private clases.lbl_titulo lbl_titulo1;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.RadioButton rb_rango_id;
        private System.Windows.Forms.RadioButton rb_x_letra;
        private System.Windows.Forms.RadioButton rb_todos;
        private clases.LabelText01 txt_restriccion;
        private clases.ReportViewer01 rv;
        private System.Windows.Forms.Button btn_buscar01;
        private System.Windows.Forms.Button btn_buscar02;
    }
}