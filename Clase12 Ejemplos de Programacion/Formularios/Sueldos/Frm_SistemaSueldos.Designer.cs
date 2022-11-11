namespace Clase12_Ejemplos_de_Programacion.Formularios.Sueldos
{
    partial class Frm_SistemaSueldos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SistemaSueldos));
            this.rb_Apellido = new System.Windows.Forms.RadioButton();
            this.rb_Perfil = new System.Windows.Forms.RadioButton();
            this.rb_id_usuario = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.rb_MesAnno = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.Selector = new Clase12_Ejemplos_de_Programacion.clases.Selector01();
            this.Txt_Apellido = new Clase12_Ejemplos_de_Programacion.clases.LabelText01();
            this.Txt_mes = new Clase12_Ejemplos_de_Programacion.clases.LabelText02();
            this.Txt_anno = new Clase12_Ejemplos_de_Programacion.clases.LabelText02();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Grid01 = new Clase12_Ejemplos_de_Programacion.clases.Grid01();
            this.lbl_titulo1 = new Clase12_Ejemplos_de_Programacion.clases.lbl_titulo();
            this.buttonModificar1 = new Clase12_Ejemplos_de_Programacion.clases.ButtonModificar();
            this.buttonNuevo1 = new Clase12_Ejemplos_de_Programacion.clases.ButtonNuevo();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid01)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_Apellido
            // 
            this.rb_Apellido.AutoSize = true;
            this.rb_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Apellido.Location = new System.Drawing.Point(50, 17);
            this.rb_Apellido.Name = "rb_Apellido";
            this.rb_Apellido.Size = new System.Drawing.Size(83, 24);
            this.rb_Apellido.TabIndex = 1;
            this.rb_Apellido.TabStop = true;
            this.rb_Apellido.Text = "Apellido";
            this.rb_Apellido.UseVisualStyleBackColor = true;
            this.rb_Apellido.CheckedChanged += new System.EventHandler(this.rb_id_usuario_CheckedChanged);
            // 
            // rb_Perfil
            // 
            this.rb_Perfil.AutoSize = true;
            this.rb_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Perfil.Location = new System.Drawing.Point(50, 47);
            this.rb_Perfil.Name = "rb_Perfil";
            this.rb_Perfil.Size = new System.Drawing.Size(62, 24);
            this.rb_Perfil.TabIndex = 1;
            this.rb_Perfil.TabStop = true;
            this.rb_Perfil.Text = "Perfil";
            this.rb_Perfil.UseVisualStyleBackColor = true;
            this.rb_Perfil.CheckedChanged += new System.EventHandler(this.rb_id_usuario_CheckedChanged);
            // 
            // rb_id_usuario
            // 
            this.rb_id_usuario.AutoSize = true;
            this.rb_id_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_id_usuario.Location = new System.Drawing.Point(50, 77);
            this.rb_id_usuario.Name = "rb_id_usuario";
            this.rb_id_usuario.Size = new System.Drawing.Size(102, 24);
            this.rb_id_usuario.TabIndex = 1;
            this.rb_id_usuario.TabStop = true;
            this.rb_id_usuario.Text = "Id_usuario";
            this.rb_id_usuario.UseVisualStyleBackColor = true;
            this.rb_id_usuario.CheckedChanged += new System.EventHandler(this.rb_id_usuario_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(559, 134);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(114, 31);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // rb_MesAnno
            // 
            this.rb_MesAnno.AutoSize = true;
            this.rb_MesAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_MesAnno.Location = new System.Drawing.Point(50, 107);
            this.rb_MesAnno.Name = "rb_MesAnno";
            this.rb_MesAnno.Size = new System.Drawing.Size(90, 24);
            this.rb_MesAnno.TabIndex = 1;
            this.rb_MesAnno.TabStop = true;
            this.rb_MesAnno.Text = "Mes/Año";
            this.rb_MesAnno.UseVisualStyleBackColor = true;
            this.rb_MesAnno.CheckedChanged += new System.EventHandler(this.rb_id_usuario_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.rb_todos);
            this.panel1.Controls.Add(this.rb_MesAnno);
            this.panel1.Controls.Add(this.rb_id_usuario);
            this.panel1.Controls.Add(this.rb_Perfil);
            this.panel1.Controls.Add(this.rb_Apellido);
            this.panel1.Controls.Add(this.Selector);
            this.panel1.Controls.Add(this.Txt_Apellido);
            this.panel1.Controls.Add(this.Txt_mes);
            this.panel1.Controls.Add(this.Txt_anno);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 178);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_todos.Location = new System.Drawing.Point(50, 137);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(71, 24);
            this.rb_todos.TabIndex = 1;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_id_usuario_CheckedChanged);
            // 
            // Selector
            // 
            this.Selector._columna = "id_usuario";
            this.Selector._descripcion = "descripcion";
            this.Selector._Etiqueta = "Usuarios";
            this.Selector._MensajeError = null;
            this.Selector._pk = "pk";
            this.Selector._tabla = null;
            this.Selector._Text = "";
            this.Selector._Validable = false;
            this.Selector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selector.Location = new System.Drawing.Point(183, 54);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(368, 29);
            this.Selector.TabIndex = 0;
            this.Selector.Visible = false;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido._columna = null;
            this.Txt_Apellido._Etiqueta = "Apellido";
            this.Txt_Apellido._Mask = "LLLLLLLLLLLLLLLL";
            this.Txt_Apellido._MensajeError = null;
            this.Txt_Apellido._ReadOnly = false;
            this.Txt_Apellido._Text = "";
            this.Txt_Apellido._Validable = false;
            this.Txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.Location = new System.Drawing.Point(115, 10);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(325, 34);
            this.Txt_Apellido.TabIndex = 2;
            this.Txt_Apellido.Visible = false;
            // 
            // Txt_mes
            // 
            this.Txt_mes._Ancho = 2;
            this.Txt_mes._columna = null;
            this.Txt_mes._Decimales = 0;
            this.Txt_mes._Etiqueta = "Mes";
            this.Txt_mes._Mask = "99";
            this.Txt_mes._MensajeError = null;
            this.Txt_mes._ReadOnly = false;
            this.Txt_mes._Text = "";
            this.Txt_mes._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Txt_mes._TipoDato = Clase12_Ejemplos_de_Programacion.clases.LabelText02.TipoDato.numero;
            this.Txt_mes._Validable = false;
            this.Txt_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_mes.Location = new System.Drawing.Point(115, 97);
            this.Txt_mes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_mes.Name = "Txt_mes";
            this.Txt_mes.Size = new System.Drawing.Size(194, 35);
            this.Txt_mes.TabIndex = 6;
            this.Txt_mes.Visible = false;
            // 
            // Txt_anno
            // 
            this.Txt_anno._Ancho = 4;
            this.Txt_anno._columna = null;
            this.Txt_anno._Decimales = 0;
            this.Txt_anno._Etiqueta = "Año";
            this.Txt_anno._Mask = "9999";
            this.Txt_anno._MensajeError = null;
            this.Txt_anno._ReadOnly = false;
            this.Txt_anno._Text = "";
            this.Txt_anno._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Txt_anno._TipoDato = Clase12_Ejemplos_de_Programacion.clases.LabelText02.TipoDato.numero;
            this.Txt_anno._Validable = false;
            this.Txt_anno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_anno.Location = new System.Drawing.Point(201, 97);
            this.Txt_anno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_anno.Name = "Txt_anno";
            this.Txt_anno.Size = new System.Drawing.Size(214, 35);
            this.Txt_anno.TabIndex = 6;
            this.Txt_anno.Visible = false;
            // 
            // Grid01
            // 
            this.Grid01._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.Grid01._tamannoLetraGrid = 10;
            this.Grid01._tamannoLetraHeader = 10;
            this.Grid01.AllowUserToAddRows = false;
            this.Grid01.AllowUserToDeleteRows = false;
            this.Grid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid01.Location = new System.Drawing.Point(12, 242);
            this.Grid01.Name = "Grid01";
            this.Grid01.ReadOnly = true;
            this.Grid01.Size = new System.Drawing.Size(694, 203);
            this.Grid01.TabIndex = 5;
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1._Tamaño = "20";
            this.lbl_titulo1._Titulo = "Sistema Sueldos";
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.Location = new System.Drawing.Point(12, 23);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(236, 32);
            this.lbl_titulo1.TabIndex = 4;
            this.lbl_titulo1.Text = "Sistema Sueldos";
            // 
            // buttonModificar1
            // 
            this.buttonModificar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModificar1.BackgroundImage")));
            this.buttonModificar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModificar1.Location = new System.Drawing.Point(85, 452);
            this.buttonModificar1.Name = "buttonModificar1";
            this.buttonModificar1.Size = new System.Drawing.Size(41, 41);
            this.buttonModificar1.TabIndex = 9;
            this.buttonModificar1.UseVisualStyleBackColor = true;
            this.buttonModificar1.Click += new System.EventHandler(this.buttonModificar1_Click);
            // 
            // buttonNuevo1
            // 
            this.buttonNuevo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNuevo1.BackgroundImage")));
            this.buttonNuevo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNuevo1.Location = new System.Drawing.Point(31, 452);
            this.buttonNuevo1.Name = "buttonNuevo1";
            this.buttonNuevo1.Size = new System.Drawing.Size(41, 41);
            this.buttonNuevo1.TabIndex = 10;
            this.buttonNuevo1.UseVisualStyleBackColor = true;
            this.buttonNuevo1.Click += new System.EventHandler(this.buttonNuevo1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Clase12_Ejemplos_de_Programacion.Properties.Resources.cancelar4;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(143, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 41);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_SistemaSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNuevo1);
            this.Controls.Add(this.buttonModificar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid01);
            this.Controls.Add(this.lbl_titulo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_SistemaSueldos";
            this.Load += new System.EventHandler(this.Frm_SistemaSueldos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private clases.Selector01 Selector;
        private System.Windows.Forms.RadioButton rb_Apellido;
        private System.Windows.Forms.RadioButton rb_Perfil;
        private System.Windows.Forms.RadioButton rb_id_usuario;
        private clases.LabelText01 Txt_Apellido;
        private System.Windows.Forms.Button btn_buscar;
        private clases.lbl_titulo lbl_titulo1;
        private clases.Grid01 Grid01;
        private System.Windows.Forms.RadioButton rb_MesAnno;
        private clases.LabelText02 Txt_mes;
        private clases.LabelText02 Txt_anno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.ToolTip toolTip1;
        private clases.ButtonModificar buttonModificar1;
        private clases.ButtonNuevo buttonNuevo1;
        private System.Windows.Forms.Button button1;
    }
}