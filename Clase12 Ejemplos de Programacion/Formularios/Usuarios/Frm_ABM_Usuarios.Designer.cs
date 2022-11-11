namespace Clase12_Ejemplos_de_Programacion.Formularios.Usuarios
{
    partial class Frm_ABM_Usuarios
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
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.MaskedTextBox();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.rb_n_usuario = new System.Windows.Forms.RadioButton();
            this.rb_apellido = new System.Windows.Forms.RadioButton();
            this.rb_nombre = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.Grid01 = new Clase12_Ejemplos_de_Programacion.clases.Grid01();
            ((System.ComponentModel.ISupportInitialize)(this.Grid01)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patron";
            // 
            // txt_patron
            // 
            this.txt_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.Location = new System.Drawing.Point(130, 63);
            this.txt_patron.Mask = "CCCCCCCCCCCCCCC";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(160, 26);
            this.txt_patron.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(130, 95);
            this.txt_id.Mask = "99999";
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(53, 26);
            this.txt_id.TabIndex = 2;
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_todos.Location = new System.Drawing.Point(130, 127);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(160, 24);
            this.chk_todos.TabIndex = 3;
            this.chk_todos.Text = "Todos los usuarios";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // rb_n_usuario
            // 
            this.rb_n_usuario.AutoSize = true;
            this.rb_n_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_n_usuario.Location = new System.Drawing.Point(384, 68);
            this.rb_n_usuario.Name = "rb_n_usuario";
            this.rb_n_usuario.Size = new System.Drawing.Size(97, 24);
            this.rb_n_usuario.TabIndex = 4;
            this.rb_n_usuario.TabStop = true;
            this.rb_n_usuario.Text = "n_usuario";
            this.rb_n_usuario.UseVisualStyleBackColor = true;
            // 
            // rb_apellido
            // 
            this.rb_apellido.AutoSize = true;
            this.rb_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_apellido.Location = new System.Drawing.Point(384, 98);
            this.rb_apellido.Name = "rb_apellido";
            this.rb_apellido.Size = new System.Drawing.Size(83, 24);
            this.rb_apellido.TabIndex = 4;
            this.rb_apellido.TabStop = true;
            this.rb_apellido.Text = "Apellido";
            this.rb_apellido.UseVisualStyleBackColor = true;
            // 
            // rb_nombre
            // 
            this.rb_nombre.AutoSize = true;
            this.rb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nombre.Location = new System.Drawing.Point(384, 127);
            this.rb_nombre.Name = "rb_nombre";
            this.rb_nombre.Size = new System.Drawing.Size(91, 24);
            this.rb_nombre.TabIndex = 4;
            this.rb_nombre.TabStop = true;
            this.rb_nombre.Text = "Nombres";
            this.rb_nombre.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(583, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "ABM Usuarios";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::Clase12_Ejemplos_de_Programacion.Properties.Resources.eliminar;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(130, 378);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(53, 46);
            this.btn_borrar.TabIndex = 0;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::Clase12_Ejemplos_de_Programacion.Properties.Resources.icono_modificar_png_3;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(71, 378);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(53, 46);
            this.btn_modificar.TabIndex = 0;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = global::Clase12_Ejemplos_de_Programacion.Properties.Resources.agregar;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 378);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(53, 46);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // Grid01
            // 
            this.Grid01._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.Grid01._tamannoLetraGrid = 10;
            this.Grid01._tamannoLetraHeader = 9;
            this.Grid01.AllowUserToAddRows = false;
            this.Grid01.AllowUserToDeleteRows = false;
            this.Grid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid01.Location = new System.Drawing.Point(12, 174);
            this.Grid01.Name = "Grid01";
            this.Grid01.ReadOnly = true;
            this.Grid01.Size = new System.Drawing.Size(686, 198);
            this.Grid01.TabIndex = 7;
            this.Grid01.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid01_CellDoubleClick);
            // 
            // Frm_ABM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 436);
            this.Controls.Add(this.Grid01);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_nombre);
            this.Controls.Add(this.rb_apellido);
            this.Controls.Add(this.rb_n_usuario);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_patron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_nuevo);
            this.Name = "Frm_ABM_Usuarios";
            this.Load += new System.EventHandler(this.Frm_ABM_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_id;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.RadioButton rb_n_usuario;
        private System.Windows.Forms.RadioButton rb_apellido;
        private System.Windows.Forms.RadioButton rb_nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private clases.Grid01 Grid01;
    }
}