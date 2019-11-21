namespace Manejador_BD_JTM
{
    partial class cambiarNombre
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
            this.btRenombrar = new System.Windows.Forms.Button();
            this.tbNombreNuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btRenombrar
            // 
            this.btRenombrar.Location = new System.Drawing.Point(91, 121);
            this.btRenombrar.Name = "btRenombrar";
            this.btRenombrar.Size = new System.Drawing.Size(75, 23);
            this.btRenombrar.TabIndex = 0;
            this.btRenombrar.Text = "Guardar";
            this.btRenombrar.UseVisualStyleBackColor = true;
            this.btRenombrar.Click += new System.EventHandler(this.BtRenombrar_Click);
            // 
            // tbNombreNuevo
            // 
            this.tbNombreNuevo.Location = new System.Drawing.Point(45, 95);
            this.tbNombreNuevo.Name = "tbNombreNuevo";
            this.tbNombreNuevo.Size = new System.Drawing.Size(156, 20);
            this.tbNombreNuevo.TabIndex = 1;
            // 
            // cambiarNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 179);
            this.Controls.Add(this.tbNombreNuevo);
            this.Controls.Add(this.btRenombrar);
            this.Name = "cambiarNombre";
            this.Opacity = 0.88D;
            this.ShowInTaskbar = false;
            this.Text = "Ingresa el nombre";
            this.Load += new System.EventHandler(this.CambiarNombre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRenombrar;
        private System.Windows.Forms.TextBox tbNombreNuevo;
    }
}