namespace Clase12_Ejemplos_de_Programacion.Formularios.Usuarios
{
    partial class Frm_UsuariosBorrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UsuariosBorrar));
            this.SuspendLayout();
            // 
            // txt_n_usuario
            // 
            this.txt_n_usuario.Enabled = false;
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.DisplayMember = "Descripcion";
            this.cmb_perfiles.Enabled = false;
            this.cmb_perfiles.ValueMember = "Pk";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            // 
            // txt_cuil
            // 
            this.txt_cuil.Enabled = false;
            // 
            // cmb_estados
            // 
            this.cmb_estados.DisplayMember = "Descripcion";
            this.cmb_estados.Enabled = false;
            this.cmb_estados.ValueMember = "Pk";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Enabled = false;
            // 
            // Frm_UsuariosBorrar
            // 
            this._titulo = "Borrar Usuario";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(386, 418);
            this.Name = "Frm_UsuariosBorrar";
            this.Load += new System.EventHandler(this.Frm_UsuariosBorrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
