namespace Clase12_Ejemplos_de_Programacion.Formularios
{
    partial class Frm_Emplos_Programacion
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
            this.btn_cargar_combo1 = new System.Windows.Forms.Button();
            this.cmb_usuarios = new System.Windows.Forms.ComboBox();
            this.cmb_restrigido = new System.Windows.Forms.ComboBox();
            this.cargar_combo2 = new System.Windows.Forms.Button();
            this.cmb_usuarios2 = new System.Windows.Forms.ComboBox();
            this.cmb_barrios2 = new System.Windows.Forms.ComboBox();
            this.btn_cargar_usuario2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_cargar_usuario_02 = new System.Windows.Forms.Button();
            this.cmb_usuarios02 = new Clase12_Ejemplos_de_Programacion.clases.ComboBox01();
            this.cmb_barrios02 = new Clase12_Ejemplos_de_Programacion.clases.ComboBox01();
            this.btn_cargar_barrio_02 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_cargar_combo1
            // 
            this.btn_cargar_combo1.Location = new System.Drawing.Point(38, 88);
            this.btn_cargar_combo1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_cargar_combo1.Name = "btn_cargar_combo1";
            this.btn_cargar_combo1.Size = new System.Drawing.Size(298, 42);
            this.btn_cargar_combo1.TabIndex = 2;
            this.btn_cargar_combo1.Text = "Cargar usuarios (evento)";
            this.btn_cargar_combo1.UseVisualStyleBackColor = true;
            this.btn_cargar_combo1.Click += new System.EventHandler(this.btn_cargar_combo1_Click);
            // 
            // cmb_usuarios
            // 
            this.cmb_usuarios.FormattingEnabled = true;
            this.cmb_usuarios.Location = new System.Drawing.Point(358, 94);
            this.cmb_usuarios.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmb_usuarios.Name = "cmb_usuarios";
            this.cmb_usuarios.Size = new System.Drawing.Size(230, 32);
            this.cmb_usuarios.TabIndex = 3;
            // 
            // cmb_restrigido
            // 
            this.cmb_restrigido.FormattingEnabled = true;
            this.cmb_restrigido.Location = new System.Drawing.Point(358, 42);
            this.cmb_restrigido.Name = "cmb_restrigido";
            this.cmb_restrigido.Size = new System.Drawing.Size(230, 32);
            this.cmb_restrigido.TabIndex = 1;
            // 
            // cargar_combo2
            // 
            this.cargar_combo2.Location = new System.Drawing.Point(38, 36);
            this.cargar_combo2.Name = "cargar_combo2";
            this.cargar_combo2.Size = new System.Drawing.Size(298, 42);
            this.cargar_combo2.TabIndex = 0;
            this.cargar_combo2.Text = "Cargar barrios  (evento)";
            this.cargar_combo2.UseVisualStyleBackColor = true;
            this.cargar_combo2.Click += new System.EventHandler(this.cargar_combo2_Click);
            // 
            // cmb_usuarios2
            // 
            this.cmb_usuarios2.FormattingEnabled = true;
            this.cmb_usuarios2.Location = new System.Drawing.Point(358, 188);
            this.cmb_usuarios2.Name = "cmb_usuarios2";
            this.cmb_usuarios2.Size = new System.Drawing.Size(230, 32);
            this.cmb_usuarios2.TabIndex = 5;
            // 
            // cmb_barrios2
            // 
            this.cmb_barrios2.FormattingEnabled = true;
            this.cmb_barrios2.Location = new System.Drawing.Point(358, 237);
            this.cmb_barrios2.Name = "cmb_barrios2";
            this.cmb_barrios2.Size = new System.Drawing.Size(230, 32);
            this.cmb_barrios2.TabIndex = 7;
            // 
            // btn_cargar_usuario2
            // 
            this.btn_cargar_usuario2.Location = new System.Drawing.Point(38, 187);
            this.btn_cargar_usuario2.Name = "btn_cargar_usuario2";
            this.btn_cargar_usuario2.Size = new System.Drawing.Size(298, 32);
            this.btn_cargar_usuario2.TabIndex = 4;
            this.btn_cargar_usuario2.Text = "Cargar Usuarios (Procedural)";
            this.btn_cargar_usuario2.UseVisualStyleBackColor = true;
            this.btn_cargar_usuario2.Click += new System.EventHandler(this.btn_cargar_usuario2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cargar Barrios (Procedural)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cargar_usuario_02
            // 
            this.btn_cargar_usuario_02.Location = new System.Drawing.Point(38, 305);
            this.btn_cargar_usuario_02.Name = "btn_cargar_usuario_02";
            this.btn_cargar_usuario_02.Size = new System.Drawing.Size(298, 32);
            this.btn_cargar_usuario_02.TabIndex = 8;
            this.btn_cargar_usuario_02.Text = "Cargar Usuarios (clase)";
            this.btn_cargar_usuario_02.UseVisualStyleBackColor = true;
            this.btn_cargar_usuario_02.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_usuarios02
            // 
            this.cmb_usuarios02.FormattingEnabled = true;
            this.cmb_usuarios02.Location = new System.Drawing.Point(358, 306);
            this.cmb_usuarios02.Name = "cmb_usuarios02";
            this.cmb_usuarios02.Size = new System.Drawing.Size(230, 32);
            this.cmb_usuarios02.TabIndex = 9;
            // 
            // cmb_barrios02
            // 
            this.cmb_barrios02.FormattingEnabled = true;
            this.cmb_barrios02.Location = new System.Drawing.Point(358, 355);
            this.cmb_barrios02.Name = "cmb_barrios02";
            this.cmb_barrios02.Size = new System.Drawing.Size(230, 32);
            this.cmb_barrios02.TabIndex = 11;
            // 
            // btn_cargar_barrio_02
            // 
            this.btn_cargar_barrio_02.Location = new System.Drawing.Point(38, 355);
            this.btn_cargar_barrio_02.Name = "btn_cargar_barrio_02";
            this.btn_cargar_barrio_02.Size = new System.Drawing.Size(298, 32);
            this.btn_cargar_barrio_02.TabIndex = 10;
            this.btn_cargar_barrio_02.Text = "Cargar Barrios  (clase)";
            this.btn_cargar_barrio_02.UseVisualStyleBackColor = true;
            this.btn_cargar_barrio_02.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(591, 411);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 28);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Frm_Emplos_Programacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 474);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmb_barrios02);
            this.Controls.Add(this.btn_cargar_barrio_02);
            this.Controls.Add(this.btn_cargar_usuario_02);
            this.Controls.Add(this.cmb_usuarios02);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cargar_usuario2);
            this.Controls.Add(this.cmb_barrios2);
            this.Controls.Add(this.cmb_usuarios2);
            this.Controls.Add(this.cargar_combo2);
            this.Controls.Add(this.cmb_restrigido);
            this.Controls.Add(this.cmb_usuarios);
            this.Controls.Add(this.btn_cargar_combo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Frm_Emplos_Programacion";
            this.Text = "Ejemplo Programacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cargar_combo1;
        private System.Windows.Forms.ComboBox cmb_usuarios;
        private System.Windows.Forms.ComboBox cmb_restrigido;
        private System.Windows.Forms.Button cargar_combo2;
        private System.Windows.Forms.ComboBox cmb_usuarios2;
        private System.Windows.Forms.ComboBox cmb_barrios2;
        private System.Windows.Forms.Button btn_cargar_usuario2;
        private System.Windows.Forms.Button button2;
        private clases.ComboBox01 cmb_usuarios02;
        private System.Windows.Forms.Button btn_cargar_usuario_02;
        private clases.ComboBox01 cmb_barrios02;
        private System.Windows.Forms.Button btn_cargar_barrio_02;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

