using ClasesSalaEscape;

namespace CodigosSecretosForm
{
    public partial class frmCodigosSecretos : Form
    {
        private ListasCodigosSecretos.ListaConOpciones listaActual;
        public frmCodigosSecretos()
        {
            InitializeComponent();
        }

        private void frmCodigosSecretos_Load(object sender, EventArgs e)
        {
            // Aca estoy cargando una lista aleatoria
            CargarListaAleatoria();
        }

        private void CargarListaAleatoria()
        {
            // Limpiar el listBox
            lstCodigosSecretos.Items.Clear();

            // Obtener lista aleatoria
            listaActual = ListasCodigosSecretos.ObtenerListaAleatoria();

            // Agregar elementos a la listBox
            foreach (string elemento in listaActual.Elementos)
            {
                lstCodigosSecretos.Items.Add(elemento);
            }

            CargarOpcionesEnBotones();
        }

        private void CargarOpcionesEnBotones()
        {
            // Obtener opciones mezcladas
            List<string> opcionesMezcladas = ListasCodigosSecretos.ObtenerOpcionesMezcladas(listaActual);

            // Asignar las opciones mezcladas a los botones
            btnCodigosSecretos1.Text = opcionesMezcladas[0];
            btnCodigosSecretos2.Text = opcionesMezcladas[1];
            btnCodigosSecretos3.Text = opcionesMezcladas[2];
        }

        private void VerificarRespuesta(Button botonClickeado)
        {
            string opcionSeleccionada = botonClickeado.Text;

            // Verificar si la opción es correcta
            if (opcionSeleccionada == listaActual.OpcionCorrecta)
            {
                MessageBox.Show("¡Correcto! Has acertado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrecto. La respuesta correcta era: " +
                    listaActual.OpcionCorrecta, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Cargar nueva lista después de responder
            CargarListaAleatoria();
        }

        private void btnCodigosSecretos1_Click(object sender, EventArgs e)
        {
            Button botonClickeado = (Button)sender;
            VerificarRespuesta(botonClickeado);
        }

        
    }
}
