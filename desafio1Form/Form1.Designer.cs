namespace desafio1Form
{
    partial class frmDesafio1
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
            lblPregunta = new Label();
            txtRespuesta = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(259, 100);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(299, 15);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "¿A que hora se lanzo el 4to aviso del intento de hackeo?";
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(363, 188);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.PlaceholderText = "00:00";
            txtRespuesta.Size = new Size(78, 23);
            txtRespuesta.TabIndex = 1;
            txtRespuesta.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(363, 297);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmDesafio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 470);
            Controls.Add(btnAceptar);
            Controls.Add(txtRespuesta);
            Controls.Add(lblPregunta);
            Name = "frmDesafio1";
            Text = "Desafio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private TextBox txtRespuesta;
        private Button btnAceptar;
    }
}
