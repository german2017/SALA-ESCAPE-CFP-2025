namespace ScapeRoomCFP
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
            button1 = new Button();
            btnDesafio1 = new Button();
            btnDesafio2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            apagarToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(13, 13);
            button1.Name = "button1";
            button1.Size = new Size(78, 72);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDesafio1
            // 
            btnDesafio1.BackColor = Color.Transparent;
            btnDesafio1.BackgroundImage = (Image)resources.GetObject("btnDesafio1.BackgroundImage");
            btnDesafio1.BackgroundImageLayout = ImageLayout.Stretch;
            btnDesafio1.FlatStyle = FlatStyle.Flat;
            btnDesafio1.Location = new Point(13, 109);
            btnDesafio1.Name = "btnDesafio1";
            btnDesafio1.Size = new Size(78, 72);
            btnDesafio1.TabIndex = 2;
            btnDesafio1.UseVisualStyleBackColor = false;
            btnDesafio1.Click += btnDesafio1_Click;
            // 
            // btnDesafio2
            // 
            btnDesafio2.BackColor = Color.Transparent;
            btnDesafio2.BackgroundImage = (Image)resources.GetObject("btnDesafio2.BackgroundImage");
            btnDesafio2.BackgroundImageLayout = ImageLayout.Stretch;
            btnDesafio2.FlatStyle = FlatStyle.Flat;
            btnDesafio2.Location = new Point(13, 204);
            btnDesafio2.Name = "btnDesafio2";
            btnDesafio2.Size = new Size(78, 72);
            btnDesafio2.TabIndex = 3;
            btnDesafio2.UseVisualStyleBackColor = false;
            btnDesafio2.Click += btnDesafio2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(13, 300);
            button4.Name = "button4";
            button4.Size = new Size(78, 72);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(1059, 541);
            button5.Name = "button5";
            button5.Size = new Size(78, 72);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(13, 398);
            button6.Name = "button6";
            button6.Size = new Size(78, 72);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 625);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1149, 45);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 255);
            inicioToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("inicioToolStripMenuItem.BackgroundImage");
            inicioToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { apagarToolStripMenuItem });
            inicioToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(92, 41);
            inicioToolStripMenuItem.Text = "         ";
            inicioToolStripMenuItem.TextImageRelation = TextImageRelation.Overlay;
            // 
            // apagarToolStripMenuItem
            // 
            apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            apagarToolStripMenuItem.Size = new Size(180, 42);
            apagarToolStripMenuItem.Text = "Apagar";
            // 
            // timer1
            // 
            timer1.Interval = 300000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 670);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnDesafio2);
            Controls.Add(btnDesafio1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnDesafio1;
        private Button btnDesafio2;
        private Button button4;
        private Button button5;
        private Button button6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
