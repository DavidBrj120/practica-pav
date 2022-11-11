namespace Clase12_Ejemplos_de_Programacion.Formularios
{
    partial class Frm_Base_Selector
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.cmb_ = new Clase12_Ejemplos_de_Programacion.clases.ComboBox01();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(106, 29);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "TITULO";
            // 
            // cmb_
            // 
            this.cmb_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_.FormattingEnabled = true;
            this.cmb_.Location = new System.Drawing.Point(17, 43);
            this.cmb_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_.Name = "cmb_";
            this.cmb_.Size = new System.Drawing.Size(300, 32);
            this.cmb_.TabIndex = 0;
            this.cmb_.SelectionChangeCommitted += new System.EventHandler(this.cmb__SelectionChangeCommitted);
            // 
            // Frm_Base_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 111);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmb_);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Base_Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public clases.ComboBox01 cmb_;
        public System.Windows.Forms.Label lbl_titulo;
    }
}