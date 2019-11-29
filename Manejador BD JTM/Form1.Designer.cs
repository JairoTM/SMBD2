namespace Manejador_BD_JTM
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvCarpetasArchivos = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bttCreaTabla = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoDatoAtributo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAgregarAtritbuto = new System.Windows.Forms.Button();
            this.tbNombreAtributo = new System.Windows.Forms.TextBox();
            this.cbTipoDeLlave = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTamanio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTablaDeLlaveForanea = new System.Windows.Forms.ComboBox();
            this.lbTablaSelec = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btEditarAtributo = new System.Windows.Forms.Button();
            this.dgv_Atributos = new System.Windows.Forms.DataGridView();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Atributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // tvCarpetasArchivos
            // 
            this.tvCarpetasArchivos.Location = new System.Drawing.Point(12, 45);
            this.tvCarpetasArchivos.Name = "tvCarpetasArchivos";
            this.tvCarpetasArchivos.Size = new System.Drawing.Size(166, 451);
            this.tvCarpetasArchivos.TabIndex = 0;
            this.tvCarpetasArchivos.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.TvCarpetasArchivos_NodeMouseHover);
            this.tvCarpetasArchivos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvCarpetasArchivos_NodeMouseClick);
            this.tvCarpetasArchivos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvCarpetasArchivos_NodeMouseDoubleClick);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.Windows;
            // 
            // bttCreaTabla
            // 
            this.bttCreaTabla.Location = new System.Drawing.Point(184, 45);
            this.bttCreaTabla.Name = "bttCreaTabla";
            this.bttCreaTabla.Size = new System.Drawing.Size(75, 23);
            this.bttCreaTabla.TabIndex = 2;
            this.bttCreaTabla.Text = "Crear tabla";
            this.bttCreaTabla.UseVisualStyleBackColor = true;
            this.bttCreaTabla.Click += new System.EventHandler(this.BttCreaTabla_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearBDToolStripMenuItem,
            this.cargarBDToolStripMenuItem,
            this.refrescarToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItem1.Text = "Base de datos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // crearBDToolStripMenuItem
            // 
            this.crearBDToolStripMenuItem.Name = "crearBDToolStripMenuItem";
            this.crearBDToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.crearBDToolStripMenuItem.Text = "Crear BD";
            this.crearBDToolStripMenuItem.Click += new System.EventHandler(this.CrearBDToolStripMenuItem_Click);
            // 
            // cargarBDToolStripMenuItem
            // 
            this.cargarBDToolStripMenuItem.Name = "cargarBDToolStripMenuItem";
            this.cargarBDToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cargarBDToolStripMenuItem.Text = "Cargar BD";
            this.cargarBDToolStripMenuItem.Click += new System.EventHandler(this.CargarBDToolStripMenuItem_Click);
            // 
            // refrescarToolStripMenuItem
            // 
            this.refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            this.refrescarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.refrescarToolStripMenuItem.Text = "Refrescar";
            this.refrescarToolStripMenuItem.Click += new System.EventHandler(this.RefrescarToolStripMenuItem_Click);
            // 
            // eliminarBD
            // 
            this.eliminarBD.Location = new System.Drawing.Point(184, 74);
            this.eliminarBD.Name = "eliminarBD";
            this.eliminarBD.Size = new System.Drawing.Size(75, 23);
            this.eliminarBD.TabIndex = 5;
            this.eliminarBD.Text = "Elimina BD";
            this.eliminarBD.UseVisualStyleBackColor = true;
            this.eliminarBD.Click += new System.EventHandler(this.EliminarBD_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo de Dato";
            // 
            // cbTipoDatoAtributo
            // 
            this.cbTipoDatoAtributo.FormattingEnabled = true;
            this.cbTipoDatoAtributo.Items.AddRange(new object[] {
            "Cadena",
            "Entero",
            "Flotante"});
            this.cbTipoDatoAtributo.Location = new System.Drawing.Point(95, 63);
            this.cbTipoDatoAtributo.Name = "cbTipoDatoAtributo";
            this.cbTipoDatoAtributo.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDatoAtributo.TabIndex = 17;
            this.cbTipoDatoAtributo.SelectedIndexChanged += new System.EventHandler(this.CbTipoDatoAtributo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Llave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre Atributo";
            // 
            // btAgregarAtritbuto
            // 
            this.btAgregarAtritbuto.Location = new System.Drawing.Point(286, 201);
            this.btAgregarAtritbuto.Name = "btAgregarAtritbuto";
            this.btAgregarAtritbuto.Size = new System.Drawing.Size(75, 23);
            this.btAgregarAtritbuto.TabIndex = 13;
            this.btAgregarAtritbuto.Text = "Agregar";
            this.btAgregarAtritbuto.UseVisualStyleBackColor = true;
            this.btAgregarAtritbuto.Click += new System.EventHandler(this.BtAgregarAtritbuto_Click);
            // 
            // tbNombreAtributo
            // 
            this.tbNombreAtributo.Location = new System.Drawing.Point(95, 37);
            this.tbNombreAtributo.Name = "tbNombreAtributo";
            this.tbNombreAtributo.Size = new System.Drawing.Size(100, 20);
            this.tbNombreAtributo.TabIndex = 12;
            // 
            // cbTipoDeLlave
            // 
            this.cbTipoDeLlave.FormattingEnabled = true;
            this.cbTipoDeLlave.Items.AddRange(new object[] {
            "Ninguna",
            "Primaria",
            "Secundaria"});
            this.cbTipoDeLlave.Location = new System.Drawing.Point(95, 115);
            this.cbTipoDeLlave.Name = "cbTipoDeLlave";
            this.cbTipoDeLlave.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDeLlave.TabIndex = 11;
            this.cbTipoDeLlave.SelectedIndexChanged += new System.EventHandler(this.CbTipoDeLlave_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.tbTamanio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbTablaDeLlaveForanea);
            this.panel1.Controls.Add(this.lbTablaSelec);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbTipoDatoAtributo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btAgregarAtritbuto);
            this.panel1.Controls.Add(this.tbNombreAtributo);
            this.panel1.Controls.Add(this.cbTipoDeLlave);
            this.panel1.Location = new System.Drawing.Point(275, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 227);
            this.panel1.TabIndex = 22;
            // 
            // tbTamanio
            // 
            this.tbTamanio.Location = new System.Drawing.Point(95, 90);
            this.tbTamanio.Name = "tbTamanio";
            this.tbTamanio.Size = new System.Drawing.Size(100, 20);
            this.tbTamanio.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tamaño del dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tabla para llave foranea: ";
            // 
            // cbTablaDeLlaveForanea
            // 
            this.cbTablaDeLlaveForanea.FormattingEnabled = true;
            this.cbTablaDeLlaveForanea.Items.AddRange(new object[] {
            "Ninguna",
            "Primaria",
            "Secundaria"});
            this.cbTablaDeLlaveForanea.Location = new System.Drawing.Point(95, 164);
            this.cbTablaDeLlaveForanea.Name = "cbTablaDeLlaveForanea";
            this.cbTablaDeLlaveForanea.Size = new System.Drawing.Size(121, 21);
            this.cbTablaDeLlaveForanea.TabIndex = 20;
            // 
            // lbTablaSelec
            // 
            this.lbTablaSelec.AutoSize = true;
            this.lbTablaSelec.Location = new System.Drawing.Point(6, 10);
            this.lbTablaSelec.Name = "lbTablaSelec";
            this.lbTablaSelec.Size = new System.Drawing.Size(106, 13);
            this.lbTablaSelec.TabIndex = 19;
            this.lbTablaSelec.Text = "Tabla seleccionada: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Elimina Tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btEditarAtributo
            // 
            this.btEditarAtributo.Location = new System.Drawing.Point(184, 145);
            this.btEditarAtributo.Name = "btEditarAtributo";
            this.btEditarAtributo.Size = new System.Drawing.Size(75, 23);
            this.btEditarAtributo.TabIndex = 23;
            this.btEditarAtributo.Text = "Editar";
            this.btEditarAtributo.UseVisualStyleBackColor = true;
            this.btEditarAtributo.Click += new System.EventHandler(this.BtEditarAtributo_Click);
            // 
            // dgv_Atributos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Atributos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Atributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Atributos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Atributos.Location = new System.Drawing.Point(184, 278);
            this.dgv_Atributos.Name = "dgv_Atributos";
            this.dgv_Atributos.Size = new System.Drawing.Size(695, 218);
            this.dgv_Atributos.TabIndex = 23;
            this.dgv_Atributos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Atributos_CellClick);
            this.dgv_Atributos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Atributos_CellEnter);
            // 
            // dgvRegistros
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistros.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegistros.Location = new System.Drawing.Point(12, 502);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(867, 197);
            this.dgvRegistros.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 705);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btEditarAtributo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Atributos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eliminarBD);
            this.Controls.Add(this.bttCreaTabla);
            this.Controls.Add(this.tvCarpetasArchivos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SMBD- Sistema Manejador de Bases de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Atributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCarpetasArchivos;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bttCreaTabla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrescarToolStripMenuItem;
        private System.Windows.Forms.Button eliminarBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoDatoAtributo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAgregarAtritbuto;
        private System.Windows.Forms.TextBox tbNombreAtributo;
        private System.Windows.Forms.ComboBox cbTipoDeLlave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTablaSelec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTablaDeLlaveForanea;
        private System.Windows.Forms.Button btEditarAtributo;
        private System.Windows.Forms.TextBox tbTamanio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Atributos;
        private System.Windows.Forms.DataGridView dgvRegistros;
    }
}

