namespace Clase12_Ejemplos_de_Programacion.Formularios
{
    partial class Frm_Seleccionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_usuario = new System.Windows.Forms.TextBox();
            this.txt_n_usuario = new System.Windows.Forms.TextBox();
            this.btn_buscar_usuarios = new System.Windows.Forms.Button();
            this.SelCuil = new Clase12_Ejemplos_de_Programacion.clases.SelecCuil();
            this.Sel_ApeNom = new Clase12_Ejemplos_de_Programacion.clases.Selector01();
            this.Sel_estados = new Clase12_Ejemplos_de_Programacion.clases.Selector01();
            this.Sel_usuarios = new Clase12_Ejemplos_de_Programacion.clases.Selector01();
            this.btn_agregar_cuil = new System.Windows.Forms.Button();
            this.labelText011 = new Clase12_Ejemplos_de_Programacion.clases.LabelText01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Usuario";
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Location = new System.Drawing.Point(225, 55);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(45, 29);
            this.txt_id_usuario.TabIndex = 1;
            this.txt_id_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_usuario_KeyDown);
            // 
            // txt_n_usuario
            // 
            this.txt_n_usuario.Location = new System.Drawing.Point(276, 55);
            this.txt_n_usuario.Name = "txt_n_usuario";
            this.txt_n_usuario.Size = new System.Drawing.Size(217, 29);
            this.txt_n_usuario.TabIndex = 1;
            this.txt_n_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_n_usuario_KeyDown);
            // 
            // btn_buscar_usuarios
            // 
            this.btn_buscar_usuarios.BackgroundImage = global::Clase12_Ejemplos_de_Programacion.Properties.Resources._3puntos;
            this.btn_buscar_usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_usuarios.Location = new System.Drawing.Point(499, 55);
            this.btn_buscar_usuarios.Name = "btn_buscar_usuarios";
            this.btn_buscar_usuarios.Size = new System.Drawing.Size(41, 29);
            this.btn_buscar_usuarios.TabIndex = 2;
            this.btn_buscar_usuarios.UseVisualStyleBackColor = true;
            this.btn_buscar_usuarios.Click += new System.EventHandler(this.btn_buscar_usuarios_Click);
            // 
            // SelCuil
            // 
            this.SelCuil._columna = null;
            this.SelCuil._cuil = "cuil";
            this.SelCuil._descripcion = "descripcion";
            this.SelCuil._etiqueta = "Cargar Cuil";
            this.SelCuil._MensajeError = null;
            this.SelCuil._pk = "pk";
            this.SelCuil._tabla = null;
            this.SelCuil._Text = "  -        -";
            this.SelCuil._Validable = false;
            this.SelCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelCuil.Location = new System.Drawing.Point(91, 203);
            this.SelCuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelCuil.Name = "SelCuil";
            this.SelCuil.Size = new System.Drawing.Size(507, 35);
            this.SelCuil.TabIndex = 6;
            // 
            // Sel_ApeNom
            // 
            this.Sel_ApeNom._columna = null;
            this.Sel_ApeNom._descripcion = "descripcion";
            this.Sel_ApeNom._Etiqueta = "Selec. Usuario";
            this.Sel_ApeNom._MensajeError = null;
            this.Sel_ApeNom._pk = "pk";
            this.Sel_ApeNom._tabla = null;
            this.Sel_ApeNom._Text = "";
            this.Sel_ApeNom._Validable = false;
            this.Sel_ApeNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sel_ApeNom.Location = new System.Drawing.Point(91, 127);
            this.Sel_ApeNom.Name = "Sel_ApeNom";
            this.Sel_ApeNom.Size = new System.Drawing.Size(374, 31);
            this.Sel_ApeNom.TabIndex = 5;
            // 
            // Sel_estados
            // 
            this.Sel_estados._columna = null;
            this.Sel_estados._descripcion = "descripcion";
            this.Sel_estados._Etiqueta = "Selec.Estado";
            this.Sel_estados._MensajeError = null;
            this.Sel_estados._pk = "pk";
            this.Sel_estados._tabla = null;
            this.Sel_estados._Text = "";
            this.Sel_estados._Validable = false;
            this.Sel_estados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sel_estados.Location = new System.Drawing.Point(91, 164);
            this.Sel_estados.Name = "Sel_estados";
            this.Sel_estados.Size = new System.Drawing.Size(374, 31);
            this.Sel_estados.TabIndex = 4;
            // 
            // Sel_usuarios
            // 
            this.Sel_usuarios._columna = null;
            this.Sel_usuarios._descripcion = "descripcion";
            this.Sel_usuarios._Etiqueta = "Selec. Usuario";
            this.Sel_usuarios._MensajeError = null;
            this.Sel_usuarios._pk = "pk";
            this.Sel_usuarios._tabla = null;
            this.Sel_usuarios._Text = "";
            this.Sel_usuarios._Validable = false;
            this.Sel_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sel_usuarios.Location = new System.Drawing.Point(91, 90);
            this.Sel_usuarios.Name = "Sel_usuarios";
            this.Sel_usuarios.Size = new System.Drawing.Size(374, 31);
            this.Sel_usuarios.TabIndex = 3;
            // 
            // btn_agregar_cuil
            // 
            this.btn_agregar_cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_cuil.Location = new System.Drawing.Point(12, 246);
            this.btn_agregar_cuil.Name = "btn_agregar_cuil";
            this.btn_agregar_cuil.Size = new System.Drawing.Size(151, 33);
            this.btn_agregar_cuil.TabIndex = 7;
            this.btn_agregar_cuil.Text = "Agregar Cuil";
            this.btn_agregar_cuil.UseVisualStyleBackColor = true;
            this.btn_agregar_cuil.Click += new System.EventHandler(this.btn_agregar_cuil_Click);
            // 
            // labelText011
            // 
            this.labelText011._columna = null;
            this.labelText011._Etiqueta = "label1";
            this.labelText011._Mask = "LLLLLLLLLL";
            this.labelText011._MensajeError = null;
            this.labelText011._ReadOnly = false;
            this.labelText011._Text = "";
            this.labelText011._Validable = false;
            this.labelText011.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText011.Location = new System.Drawing.Point(342, 261);
            this.labelText011.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelText011.Name = "labelText011";
            this.labelText011.Size = new System.Drawing.Size(256, 35);
            this.labelText011.TabIndex = 8;
            // 
            // Frm_Seleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 320);
            this.Controls.Add(this.labelText011);
            this.Controls.Add(this.btn_agregar_cuil);
            this.Controls.Add(this.SelCuil);
            this.Controls.Add(this.Sel_ApeNom);
            this.Controls.Add(this.Sel_estados);
            this.Controls.Add(this.Sel_usuarios);
            this.Controls.Add(this.btn_buscar_usuarios);
            this.Controls.Add(this.txt_n_usuario);
            this.Controls.Add(this.txt_id_usuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Seleccionar";
            this.Text = "Frm_Seleccionar";
            this.Load += new System.EventHandler(this.Frm_Seleccionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_usuario;
        private System.Windows.Forms.TextBox txt_n_usuario;
        private System.Windows.Forms.Button btn_buscar_usuarios;
        private clases.Selector01 Sel_usuarios;
        private clases.Selector01 Sel_estados;
        private clases.Selector01 Sel_ApeNom;
        private clases.SelecCuil SelCuil;
        private System.Windows.Forms.Button btn_agregar_cuil;
        private clases.LabelText01 labelText011;
    }
}