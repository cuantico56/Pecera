namespace Pecera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistapreviadeimpresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ususariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(107, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 68);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.ingresarToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.ususariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(686, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Image = global::Pecera.Properties.Resources.ICONOS_PRESENTACIÓN_34;
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(100, 64);
            this.crearToolStripMenuItem.Text = "Ingresar";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::Pecera.Properties.Resources.ICONOS_PRESENTACIÓN_36;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(115, 64);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Image = global::Pecera.Properties.Resources.ICONOS_PRESENTACIÓN_35;
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(83, 64);
            this.ingresarToolStripMenuItem.Text = "Editar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator,
            this.guardarToolStripMenuItem,
            this.guardarcomoToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirToolStripMenuItem,
            this.vistapreviadeimpresiónToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::Pecera.Properties.Resources.ICONOS_PRESENTACIÓN_16;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(112, 64);
            this.archivoToolStripMenuItem.Text = "&Imagenes";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(271, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // guardarcomoToolStripMenuItem
            // 
            this.guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            this.guardarcomoToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.guardarcomoToolStripMenuItem.Text = "Guardar &como";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            this.vistapreviadeimpresiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image")));
            this.vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            this.vistapreviadeimpresiónToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(271, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // ususariosToolStripMenuItem
            // 
            this.ususariosToolStripMenuItem.Image = global::Pecera.Properties.Resources.ICONOS_PRESENTACIÓN_23;
            this.ususariosToolStripMenuItem.Name = "ususariosToolStripMenuItem";
            this.ususariosToolStripMenuItem.Size = new System.Drawing.Size(104, 64);
            this.ususariosToolStripMenuItem.Text = "Usuarios";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 533);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(107, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 428);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(161, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(297, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 299);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(260, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(170, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            this.label3.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(402, 299);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(158, 23);
            this.textBox6.TabIndex = 8;
            this.textBox6.Visible = false;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(156, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "CodigoBarra";
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(460, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio";
            this.label6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(460, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Imagen";
            this.label7.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(427, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 116);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(398, 236);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 23);
            this.textBox5.TabIndex = 6;
            this.textBox5.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(445, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad";
            this.label5.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(686, 428);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(7, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 66);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Pecera.Properties.Resources.photo1706556671;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(107, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(686, 88);
            this.panel5.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(508, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "AceptarVenta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(350, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "NuevaVenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(218, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cantidad";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(240, 25);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(51, 23);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "1";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(251, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Barra";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox9);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.textBox8);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(805, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 612);
            this.panel6.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(165, 91);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(3, 188);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(193, 33);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "0.00";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(41, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "MontoTotalBs";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(3, 281);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(193, 33);
            this.textBox9.TabIndex = 4;
            this.textBox9.Text = "0.00";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(41, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "MontoTotal_$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1022, 647);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarcomoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem vistapreviadeimpresiónToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label4;
        private Button button1;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox3;
        private Label label2;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private PictureBox pictureBox2;
        public TextBox textBox5;
        private Label label5;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem ususariosToolStripMenuItem;
        private Label label9;
        private TextBox textBox7;
        private Panel panel6;
        private TextBox textBox8;
        private Label label10;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private TextBox textBox9;
        private Label label11;
    }
}