namespace Pecera
{
    partial class ReporteVentas
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
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1 = new MenuStrip();
            iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem5, iconMenuItem4, iconMenuItem3, iconMenuItem2 });
            menuStrip1.Location = new Point(5, 74);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1008, 62);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem5
            // 
            iconMenuItem5.AutoSize = false;
            iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.Fish;
            iconMenuItem5.IconColor = Color.Black;
            iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem5.IconSize = 40;
            iconMenuItem5.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem5.Name = "iconMenuItem5";
            iconMenuItem5.Size = new Size(80, 58);
            iconMenuItem5.Text = "Usuarios";
            iconMenuItem5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.AutoSize = false;
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.FishFins;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.IconSize = 40;
            iconMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(80, 58);
            iconMenuItem4.Text = "Ventas";
            iconMenuItem4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.AutoSize = false;
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.IconSize = 40;
            iconMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(80, 58);
            iconMenuItem3.Text = "Reportes";
            iconMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.AutoSize = false;
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Flag;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.IconSize = 40;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(80, 58);
            iconMenuItem2.Text = "Acerca de";
            iconMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo1706556671;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(104, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 66);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(313, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 0;
            label1.Text = "Reportes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReporteVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1022, 647);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "ReporteVentas";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteVentas";
            FormClosed += ReporteVentas_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
    }
}