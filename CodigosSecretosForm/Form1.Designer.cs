namespace CodigosSecretosForm
{
    partial class frmCodigosSecretos
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
            lblCodigosSecretos = new Label();
            lstCodigosSecretos = new ListBox();
            btnCodigosSecretos1 = new Button();
            btnCodigosSecretos2 = new Button();
            btnCodigosSecretos3 = new Button();
            SuspendLayout();
            // 
            // lblCodigosSecretos
            // 
            lblCodigosSecretos.AutoSize = true;
            lblCodigosSecretos.Location = new Point(239, 55);
            lblCodigosSecretos.Name = "lblCodigosSecretos";
            lblCodigosSecretos.Size = new Size(98, 15);
            lblCodigosSecretos.TabIndex = 0;
            lblCodigosSecretos.Text = "Codigos Secretos";
            // 
            // lstCodigosSecretos
            // 
            lstCodigosSecretos.FormattingEnabled = true;
            lstCodigosSecretos.ItemHeight = 15;
            lstCodigosSecretos.Location = new Point(207, 118);
            lstCodigosSecretos.Name = "lstCodigosSecretos";
            lstCodigosSecretos.Size = new Size(163, 139);
            lstCodigosSecretos.TabIndex = 1;
            // 
            // btnCodigosSecretos1
            // 
            btnCodigosSecretos1.Location = new Point(143, 301);
            btnCodigosSecretos1.Name = "btnCodigosSecretos1";
            btnCodigosSecretos1.Size = new Size(335, 42);
            btnCodigosSecretos1.TabIndex = 2;
            btnCodigosSecretos1.Text = "Opción 1";
            btnCodigosSecretos1.UseVisualStyleBackColor = true;
            btnCodigosSecretos1.Click += btnCodigosSecretos1_Click;
            // 
            // btnCodigosSecretos2
            // 
            btnCodigosSecretos2.Location = new Point(143, 367);
            btnCodigosSecretos2.Name = "btnCodigosSecretos2";
            btnCodigosSecretos2.Size = new Size(335, 42);
            btnCodigosSecretos2.TabIndex = 3;
            btnCodigosSecretos2.Text = "Opcion 2";
            btnCodigosSecretos2.UseVisualStyleBackColor = true;
            btnCodigosSecretos2.Click += btnCodigosSecretos1_Click;
            // 
            // btnCodigosSecretos3
            // 
            btnCodigosSecretos3.Location = new Point(143, 432);
            btnCodigosSecretos3.Name = "btnCodigosSecretos3";
            btnCodigosSecretos3.Size = new Size(335, 42);
            btnCodigosSecretos3.TabIndex = 4;
            btnCodigosSecretos3.Text = "Opción 3";
            btnCodigosSecretos3.UseVisualStyleBackColor = true;
            btnCodigosSecretos3.Click += btnCodigosSecretos1_Click;
            // 
            // frmCodigosSecretos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 550);
            Controls.Add(btnCodigosSecretos3);
            Controls.Add(btnCodigosSecretos2);
            Controls.Add(btnCodigosSecretos1);
            Controls.Add(lstCodigosSecretos);
            Controls.Add(lblCodigosSecretos);
            Name = "frmCodigosSecretos";
            Text = "Desafio 2";
            Load += frmCodigosSecretos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigosSecretos;
        private ListBox lstCodigosSecretos;
        private Button btnCodigosSecretos1;
        private Button btnCodigosSecretos2;
        private Button btnCodigosSecretos3;
    }
}
