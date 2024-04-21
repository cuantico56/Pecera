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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            crearToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarcomoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            vistapreviadeimpresiónToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ususariosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            textBox5 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            errorProvider1 = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            label19 = new Label();
            textBox12 = new TextBox();
            label14 = new Label();
            label18 = new Label();
            textBox13 = new TextBox();
            label17 = new Label();
            label15 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox11 = new TextBox();
            label13 = new Label();
            radioButton1 = new RadioButton();
            textBox10 = new TextBox();
            label12 = new Label();
            label16 = new Label();
            textBox9 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(107, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 68);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearToolStripMenuItem, productosToolStripMenuItem, ingresarToolStripMenuItem, archivoToolStripMenuItem, ususariosToolStripMenuItem, ventasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(686, 68);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Image = Properties.Resources.ICONOS_PRESENTACIÓN_34;
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(100, 64);
            crearToolStripMenuItem.Text = "Ingresar";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Image = Properties.Resources.ICONOS_PRESENTACIÓN_36;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(115, 64);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Image = Properties.Resources.ICONOS_PRESENTACIÓN_35;
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(83, 64);
            ingresarToolStripMenuItem.Text = "Editar";
            ingresarToolStripMenuItem.Click += ingresarToolStripMenuItem_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, toolStripSeparator, guardarToolStripMenuItem, guardarcomoToolStripMenuItem, toolStripSeparator1, imprimirToolStripMenuItem, vistapreviadeimpresiónToolStripMenuItem, toolStripSeparator2, salirToolStripMenuItem });
            archivoToolStripMenuItem.Image = Properties.Resources.ICONOS_PRESENTACIÓN_16;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(112, 64);
            archivoToolStripMenuItem.Text = "&Imagenes";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = (Image)resources.GetObject("nuevoToolStripMenuItem.Image");
            nuevoToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoToolStripMenuItem.Size = new Size(274, 26);
            nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = (Image)resources.GetObject("abrirToolStripMenuItem.Image");
            abrirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            abrirToolStripMenuItem.Size = new Size(274, 26);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(271, 6);
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = (Image)resources.GetObject("guardarToolStripMenuItem.Image");
            guardarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarToolStripMenuItem.Size = new Size(274, 26);
            guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // guardarcomoToolStripMenuItem
            // 
            guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            guardarcomoToolStripMenuItem.Size = new Size(274, 26);
            guardarcomoToolStripMenuItem.Text = "Guardar &como";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(271, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Image = (Image)resources.GetObject("imprimirToolStripMenuItem.Image");
            imprimirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem.Size = new Size(274, 26);
            imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            vistapreviadeimpresiónToolStripMenuItem.Image = (Image)resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image");
            vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            vistapreviadeimpresiónToolStripMenuItem.Size = new Size(274, 26);
            vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(271, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(274, 26);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // ususariosToolStripMenuItem
            // 
            ususariosToolStripMenuItem.Image = Properties.Resources.ICONOS_PRESENTACIÓN_23;
            ususariosToolStripMenuItem.Name = "ususariosToolStripMenuItem";
            ususariosToolStripMenuItem.Size = new Size(104, 64);
            ususariosToolStripMenuItem.Text = "Usuarios";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(73, 64);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(8, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(92, 533);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(106, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(687, 440);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(123, 173);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 5;
            label4.Text = "Descripcion";
            label4.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(123, 379);
            button1.Name = "button1";
            button1.Size = new Size(110, 31);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(38, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 23);
            textBox4.TabIndex = 4;
            textBox4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(122, 101);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            label3.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(38, 329);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 23);
            textBox6.TabIndex = 8;
            textBox6.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(38, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 23);
            textBox3.TabIndex = 2;
            textBox3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(122, 29);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "CodigoBarra";
            label2.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(130, 302);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 9;
            label6.Text = "Precio";
            label6.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(38, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 0;
            textBox2.Visible = false;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(459, 49);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 11;
            label7.Text = "Imagen";
            label7.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.ICONOS_PRESENTACIÓN_36;
            pictureBox2.Image = Properties.Resources.ICONOS_PRESENTACIÓN_36;
            pictureBox2.Location = new Point(376, 96);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 226);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(38, 265);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(260, 23);
            textBox5.TabIndex = 6;
            textBox5.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(118, 241);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 7;
            label5.Text = "Cantidad";
            label5.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.NullValue = null;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Location = new Point(2, -3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(687, 443);
            dataGridView1.TabIndex = 13;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(7, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(93, 66);
            panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.photo1706556671;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(textBox7);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(107, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(686, 88);
            panel5.TabIndex = 4;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(508, 19);
            button3.Name = "button3";
            button3.Size = new Size(123, 29);
            button3.TabIndex = 6;
            button3.Text = "AceptarVenta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(350, 19);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 5;
            button2.Text = "NuevaVenta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(218, 1);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 4;
            label9.Text = "Cantidad";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(240, 25);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(51, 23);
            textBox7.TabIndex = 3;
            textBox7.Text = "1";
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.KeyPress += textBox1_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(251, 63);
            label8.Name = "label8";
            label8.Size = new Size(27, 25);
            label8.TabIndex = 2;
            label8.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 1;
            label1.Text = "Codigo Barra";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox1);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(textBox9);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(textBox8);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(805, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(202, 612);
            panel6.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label12);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 366);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(130, 338);
            label19.Name = "label19";
            label19.Size = new Size(44, 17);
            label19.TabIndex = 5;
            label19.Text = "Comb";
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(17, 208);
            textBox12.Name = "textBox12";
            textBox12.PlaceholderText = "0.00";
            textBox12.Size = new Size(164, 33);
            textBox12.TabIndex = 12;
            textBox12.Text = "0.00";
            textBox12.TextAlign = HorizontalAlignment.Center;
            textBox12.KeyPress += textBox12_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(51, 248);
            label14.Name = "label14";
            label14.Size = new Size(89, 21);
            label14.TabIndex = 11;
            label14.Text = "VueltoEn$";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(87, 338);
            label18.Name = "label18";
            label18.Size = new Size(15, 17);
            label18.TabIndex = 4;
            label18.Text = "$";
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox13.Location = new Point(17, 272);
            textBox13.Name = "textBox13";
            textBox13.PlaceholderText = "0.00";
            textBox13.Size = new Size(164, 33);
            textBox13.TabIndex = 10;
            textBox13.Text = "0.00";
            textBox13.TextAlign = HorizontalAlignment.Center;
            textBox13.KeyPress += textBox13_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 338);
            label17.Name = "label17";
            label17.Size = new Size(22, 17);
            label17.TabIndex = 3;
            label17.Text = "Bs";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(51, 184);
            label15.Name = "label15";
            label15.Size = new Size(97, 21);
            label15.TabIndex = 9;
            label15.Text = "VueltoEnBs";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(145, 320);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 2;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(87, 320);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 1;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox11.Location = new Point(13, 105);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(164, 33);
            textBox11.TabIndex = 8;
            textBox11.Text = "0.00";
            textBox11.TextAlign = HorizontalAlignment.Center;
            textBox11.KeyPress += textBox10_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(55, 81);
            label13.Name = "label13";
            label13.Size = new Size(77, 21);
            label13.TabIndex = 7;
            label13.Text = "PagoEn$";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(26, 320);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox10.Location = new Point(13, 39);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(164, 33);
            textBox10.TabIndex = 6;
            textBox10.Text = "0.00";
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.KeyPress += textBox10_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(51, 15);
            label12.Name = "label12";
            label12.Size = new Size(85, 21);
            label12.TabIndex = 5;
            label12.Text = "PagoEnBs";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Yellow;
            label16.Location = new Point(41, 398);
            label16.Name = "label16";
            label16.Size = new Size(54, 30);
            label16.TabIndex = 13;
            label16.Text = "Tasa";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.Location = new Point(6, 574);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(193, 33);
            textBox9.TabIndex = 4;
            textBox9.Text = "0.00";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(41, 550);
            label11.Name = "label11";
            label11.Size = new Size(115, 21);
            label11.TabIndex = 3;
            label11.Text = "MontoTotal_$";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(3, 497);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(196, 33);
            textBox8.TabIndex = 1;
            textBox8.Text = "0.00";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(41, 473);
            label10.Name = "label10";
            label10.Size = new Size(123, 21);
            label10.TabIndex = 0;
            label10.Text = "MontoTotal_Bs";
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1022, 647);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private PictureBox pictureBox2;
        public TextBox textBox5;
        private Label label5;
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
        private TextBox textBox9;
        private Label label11;
        private TextBox textBox12;
        private Label label14;
        private TextBox textBox13;
        private Label label15;
        private TextBox textBox11;
        private Label label13;
        private TextBox textBox10;
        private Label label12;
        private Label label16;
        private GroupBox groupBox1;
        private Label label19;
        private Label label18;
        private Label label17;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridView dataGridView1;
        private Label label7;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
    }
}