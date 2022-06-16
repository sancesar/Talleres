namespace Talleres
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txtcar = new System.Windows.Forms.TextBox();
            this.Txtape = new System.Windows.Forms.TextBox();
            this.Txtnom = new System.Windows.Forms.TextBox();
            this.Txtced = new System.Windows.Forms.TextBox();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Colced = new System.Windows.Forms.ColumnHeader();
            this.Colnom = new System.Windows.Forms.ColumnHeader();
            this.Colape = new System.Windows.Forms.ColumnHeader();
            this.Colcar = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verElementosGuardadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verElementosEliminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txtcar);
            this.groupBox1.Controls.Add(this.Txtape);
            this.groupBox1.Controls.Add(this.Txtnom);
            this.groupBox1.Controls.Add(this.Txtced);
            this.groupBox1.Controls.Add(this.Btnguardar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Txtcar
            // 
            this.Txtcar.Location = new System.Drawing.Point(103, 177);
            this.Txtcar.Name = "Txtcar";
            this.Txtcar.PlaceholderText = "Ingrese su carrera";
            this.Txtcar.Size = new System.Drawing.Size(178, 27);
            this.Txtcar.TabIndex = 8;
            this.Txtcar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcar_KeyPress);
            // 
            // Txtape
            // 
            this.Txtape.Location = new System.Drawing.Point(103, 134);
            this.Txtape.Name = "Txtape";
            this.Txtape.PlaceholderText = "Ingrese su apellido";
            this.Txtape.Size = new System.Drawing.Size(178, 27);
            this.Txtape.TabIndex = 7;
            this.Txtape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtape_KeyPress);
            // 
            // Txtnom
            // 
            this.Txtnom.Location = new System.Drawing.Point(103, 84);
            this.Txtnom.Name = "Txtnom";
            this.Txtnom.PlaceholderText = "Ingrese su nombre";
            this.Txtnom.Size = new System.Drawing.Size(178, 27);
            this.Txtnom.TabIndex = 6;
            this.Txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnom_KeyPress);
            // 
            // Txtced
            // 
            this.Txtced.Location = new System.Drawing.Point(103, 43);
            this.Txtced.Name = "Txtced";
            this.Txtced.PlaceholderText = "Ingrese su cedula";
            this.Txtced.Size = new System.Drawing.Size(178, 27);
            this.Txtced.TabIndex = 5;
            this.Txtced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtced_KeyPress);
            // 
            // Btnguardar
            // 
            this.Btnguardar.Location = new System.Drawing.Point(131, 242);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(94, 29);
            this.Btnguardar.TabIndex = 4;
            this.Btnguardar.Text = "Guardar";
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnEliminar);
            this.groupBox2.Controls.Add(this.listView);
            this.groupBox2.Location = new System.Drawing.Point(401, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(167, 245);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 29);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Colced,
            this.Colnom,
            this.Colape,
            this.Colcar});
            this.listView.Location = new System.Drawing.Point(6, 31);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(425, 208);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Colced
            // 
            this.Colced.DisplayIndex = 3;
            this.Colced.Text = "Cedula";
            this.Colced.Width = 100;
            // 
            // Colnom
            // 
            this.Colnom.DisplayIndex = 0;
            this.Colnom.Text = "Nombre";
            this.Colnom.Width = 100;
            // 
            // Colape
            // 
            this.Colape.DisplayIndex = 1;
            this.Colape.Text = "Apellido";
            this.Colape.Width = 100;
            // 
            // Colcar
            // 
            this.Colcar.DisplayIndex = 2;
            this.Colcar.Text = "Carrera";
            this.Colcar.Width = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarDatosToolStripMenuItem,
            this.verElementosGuardadosToolStripMenuItem,
            this.verElementosEliminadosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ingresarDatosToolStripMenuItem
            // 
            this.ingresarDatosToolStripMenuItem.Name = "ingresarDatosToolStripMenuItem";
            this.ingresarDatosToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.ingresarDatosToolStripMenuItem.Text = "Ingresar datos";
            // 
            // verElementosGuardadosToolStripMenuItem
            // 
            this.verElementosGuardadosToolStripMenuItem.Name = "verElementosGuardadosToolStripMenuItem";
            this.verElementosGuardadosToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.verElementosGuardadosToolStripMenuItem.Text = "Ver elementos guardados";
            // 
            // verElementosEliminadosToolStripMenuItem
            // 
            this.verElementosEliminadosToolStripMenuItem.Name = "verElementosEliminadosToolStripMenuItem";
            this.verElementosEliminadosToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.verElementosEliminadosToolStripMenuItem.Text = "Ver elementos eliminados";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(898, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Alumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button Btnguardar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Txtcar;
        private TextBox Txtape;
        private TextBox Txtnom;
        private TextBox Txtced;
        private GroupBox groupBox2;
        private Button BtnEliminar;
        private ListView listView;
        private ColumnHeader Colced;
        private ColumnHeader Colnom;
        private ColumnHeader Colape;
        private ColumnHeader Colcar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem ingresarDatosToolStripMenuItem;
        private ToolStripMenuItem verElementosGuardadosToolStripMenuItem;
        private ToolStripMenuItem verElementosEliminadosToolStripMenuItem;
        private ToolStripMenuItem autorToolStripMenuItem;
    }
}