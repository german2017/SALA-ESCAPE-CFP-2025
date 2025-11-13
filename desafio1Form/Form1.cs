namespace desafio1Form
{
    public partial class frmDesafio1 : Form
    {
        public frmDesafio1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string respuesta = txtRespuesta.Text;

            if (String.IsNullOrEmpty(respuesta))
            {
                //DialogResult = DialogResult.Cancel;
                MessageBox.Show("No puedes dejar el campo vacío!");
            }
            else
            {
                if (respuesta == "22:25")
                {
                    MessageBox.Show("Respuesta correcta, la letra de este desafio para el codigo final es A");
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta, has perdido 30 segundos de tu tiempo actual");
                    //Aqui se le debería restar tiempo o quitarle una vida.
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acción cancelada");
            DialogResult = DialogResult.Abort;
        }
    }
}
