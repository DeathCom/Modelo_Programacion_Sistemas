namespace Nimbus_01P
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Button_Abrir = new System.Windows.Forms.ToolStripButton();
            this.Button_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Button_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_Lexico = new System.Windows.Forms.ToolStripButton();
            this.Button_Sintactico = new System.Windows.Forms.ToolStripButton();
            this.Button_Semantico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_Salir = new System.Windows.Forms.ToolStripButton();
            this.Btn_Limpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Codigo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Codigo = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Codigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Abrir,
            this.Button_Nuevo,
            this.Button_Guardar,
            this.toolStripSeparator1,
            this.Button_Lexico,
            this.Button_Sintactico,
            this.Button_Semantico,
            this.toolStripSeparator2,
            this.Button_Salir,
            this.Btn_Limpiar,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1111, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Button_Abrir
            // 
            this.Button_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Button_Abrir.Image")));
            this.Button_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Abrir.Name = "Button_Abrir";
            this.Button_Abrir.Size = new System.Drawing.Size(23, 22);
            this.Button_Abrir.Text = "toolStripButton1";
            this.Button_Abrir.ToolTipText = "Abrir";
            this.Button_Abrir.Click += new System.EventHandler(this.Button_Abrir_Click);
            // 
            // Button_Nuevo
            // 
            this.Button_Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Button_Nuevo.Image")));
            this.Button_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Nuevo.Name = "Button_Nuevo";
            this.Button_Nuevo.Size = new System.Drawing.Size(23, 22);
            this.Button_Nuevo.Text = "toolStripButton2";
            this.Button_Nuevo.ToolTipText = "Nuevo";
            this.Button_Nuevo.Click += new System.EventHandler(this.Button_Nuevo_Click);
            // 
            // Button_Guardar
            // 
            this.Button_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Button_Guardar.Image")));
            this.Button_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Guardar.Name = "Button_Guardar";
            this.Button_Guardar.Size = new System.Drawing.Size(23, 22);
            this.Button_Guardar.Text = "toolStripButton3";
            this.Button_Guardar.ToolTipText = "Guardar";
            this.Button_Guardar.Click += new System.EventHandler(this.Button_Guardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Button_Lexico
            // 
            this.Button_Lexico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Lexico.Image = ((System.Drawing.Image)(resources.GetObject("Button_Lexico.Image")));
            this.Button_Lexico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Lexico.Name = "Button_Lexico";
            this.Button_Lexico.Size = new System.Drawing.Size(23, 22);
            this.Button_Lexico.Text = "toolStripButton4";
            this.Button_Lexico.ToolTipText = "Analizador Lexico";
            this.Button_Lexico.Click += new System.EventHandler(this.Button_Lexico_Click);
            // 
            // Button_Sintactico
            // 
            this.Button_Sintactico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Sintactico.Image = ((System.Drawing.Image)(resources.GetObject("Button_Sintactico.Image")));
            this.Button_Sintactico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Sintactico.Name = "Button_Sintactico";
            this.Button_Sintactico.Size = new System.Drawing.Size(23, 22);
            this.Button_Sintactico.Text = "toolStripButton5";
            this.Button_Sintactico.ToolTipText = "Analizador Sintactico";
            this.Button_Sintactico.Click += new System.EventHandler(this.Button_Sintactico_Click);
            // 
            // Button_Semantico
            // 
            this.Button_Semantico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Semantico.Image = ((System.Drawing.Image)(resources.GetObject("Button_Semantico.Image")));
            this.Button_Semantico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Semantico.Name = "Button_Semantico";
            this.Button_Semantico.Size = new System.Drawing.Size(23, 22);
            this.Button_Semantico.Text = "toolStripButton6";
            this.Button_Semantico.ToolTipText = "Analizador Semantico";
            this.Button_Semantico.Click += new System.EventHandler(this.Button_Semantico_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Button_Salir
            // 
            this.Button_Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Button_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Button_Salir.Image")));
            this.Button_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Salir.Name = "Button_Salir";
            this.Button_Salir.Size = new System.Drawing.Size(23, 22);
            this.Button_Salir.Text = "toolStripButton7";
            this.Button_Salir.ToolTipText = "Salir";
            this.Button_Salir.Click += new System.EventHandler(this.Button_Salir_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Limpiar.Text = "toolStripButton1";
            this.Btn_Limpiar.ToolTipText = "Limpiar";
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Codigo);
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 311);
            this.tabControl1.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.Controls.Add(this.label1);
            this.Codigo.Controls.Add(this.Panel_Codigo);
            this.Codigo.Location = new System.Drawing.Point(4, 22);
            this.Codigo.Name = "Codigo";
            this.Codigo.Padding = new System.Windows.Forms.Padding(3);
            this.Codigo.Size = new System.Drawing.Size(725, 285);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo";
            this.Codigo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // Panel_Codigo
            // 
            this.Panel_Codigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Codigo.Location = new System.Drawing.Point(23, 0);
            this.Panel_Codigo.Name = "Panel_Codigo";
            this.Panel_Codigo.Size = new System.Drawing.Size(706, 285);
            this.Panel_Codigo.TabIndex = 0;
            this.Panel_Codigo.Text = "";
            this.Panel_Codigo.VScroll += new System.EventHandler(this.Panel_Codigo_VScroll);
            this.Panel_Codigo.TextChanged += new System.EventHandler(this.Panel_Codigo_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Token,
            this.Tipo_Token,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(738, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(376, 457);
            this.dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            this.Token.Width = 130;
            // 
            // Tipo_Token
            // 
            this.Tipo_Token.HeaderText = "Lexema";
            this.Tipo_Token.Name = "Tipo_Token";
            this.Tipo_Token.ReadOnly = true;
            this.Tipo_Token.Width = 170;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ambito";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Error});
            this.dataGridView2.Location = new System.Drawing.Point(0, 366);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(733, 166);
            this.dataGridView2.TabIndex = 4;
            // 
            // Error
            // 
            this.Error.HeaderText = "Error";
            this.Error.Name = "Error";
            this.Error.ReadOnly = true;
            this.Error.Width = 732;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1111, 544);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nimbus_369";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Codigo.ResumeLayout(false);
            this.Codigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Button_Abrir;
        private System.Windows.Forms.ToolStripButton Button_Nuevo;
        private System.Windows.Forms.ToolStripButton Button_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Button_Lexico;
        private System.Windows.Forms.ToolStripButton Button_Sintactico;
        private System.Windows.Forms.ToolStripButton Button_Semantico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Button_Salir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Codigo;
        private System.Windows.Forms.RichTextBox Panel_Codigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripButton Btn_Limpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
    }
}

