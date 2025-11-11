using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScapeRoomCFP {
    public partial class CaptchaImgForm : Form
    {
        CaptchaImg captcha = new CaptchaImg();

        bool[] esSemaforo;
        bool[] seleccion;



        public CaptchaImgForm()
        {
            InitializeComponent();
            inicializacion();
        }

        private void inicializacion()
        {
            // Inicializamos con 9 espacios (para 9 imágenes)
            esSemaforo = new bool[9];
            seleccion = new bool[9];

            lblDisplay.Text = "¿Es usted un robot?\n Seleccione los semaforos";
            CargarImagenesRandom();

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //CargarImagenes();
            //(CargarImagenesRandom();
            inicializacion();
        }

        private void CargarImagenesRandom()
        {
            // Lista de PictureBoxes
            PictureBox[] cajas = { pb01, pb02, pb03, pb04, pb05, pb06, pb07, pb08, pb09 };

            // Reiniciamos el estado
            for (int i = 0; i < esSemaforo.Length; i++)
            {
                esSemaforo[i] = false;
                seleccion[i] = false;

                //Esto está solo por el botón de pruebas, no debería ser necesario
                cajas[i].BorderStyle = BorderStyle.None;
            }

            Random rnd = new Random();

            // Solución auto-magica que me pasó el profe
            var rm = Recursos.ResourceManager;
            var res = rm.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

            List<Image> gatitos = new List<Image>();
            List<Image> semaforos = new List<Image>();

            foreach (System.Collections.DictionaryEntry entry in res)
            {
                string nombre = entry.Key.ToString();
                if (entry.Value is Image img)
                {
                    if (nombre.StartsWith("Gatito", StringComparison.OrdinalIgnoreCase))
                        gatitos.Add(img);
                    else if (nombre.StartsWith("Semaforo", StringComparison.OrdinalIgnoreCase))
                        semaforos.Add(img);
                }
            }

            // Elegir 3 posiciones aleatorias únicas para los semáforos
            List<int> indicesSemaforo = new List<int>();

            while (indicesSemaforo.Count < 3)
            {
                int index = rnd.Next(0, 9);
                if (!indicesSemaforo.Contains(index))
                {
                    indicesSemaforo.Add(index);
                    esSemaforo[index] = true;
                }
            }

            // Asigno imagenes
            for (int i = 0; i < cajas.Length; i++)
            {
                if (esSemaforo[i])
                {
                    cajas[i].Image = semaforos[rnd.Next(semaforos.Count)];
                }
                else
                {
                    cajas[i].Image = gatitos[rnd.Next(gatitos.Count)];
                }

                cajas[i].SizeMode = PictureBoxSizeMode.Zoom;
            }


        }


        private void btnValidar_Click(object sender, EventArgs e)
        {



            bool todoCorrecto = true;

            for (int i = 0; i < 9; i++)
            {
                // Si seleccionó algo que NO es semáforo → mal
                if (seleccion[i] && !esSemaforo[i])
                {
                    todoCorrecto = false;
                    break;
                }

                // Si hay un semáforo que NO fue seleccionado → mal
                if (esSemaforo[i] && !seleccion[i])
                {
                    todoCorrecto = false;
                    break;
                }
            }

            if (todoCorrecto)
            {
                captcha.Resolver();
                MessageBox.Show("Correcto");
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
        }

        private void pb01_Click(object sender, EventArgs e)
        {


            // Cambiar el valor (true/false)
            seleccion[0] = !seleccion[0];

            // Recuadro lo seleccionado
            if (seleccion[0])
            {
                pb01.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb01.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            // Cambiar el valor (true/false)
            seleccion[1] = !seleccion[1];

            // Recuadro lo seleccionado
            if (seleccion[1])
            {
                pb02.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb02.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void pb03_Click(object sender, EventArgs e)
        {
            // Cambiar el valor (true/false)
            seleccion[2] = !seleccion[2];

            // Recuadro lo seleccionado
            if (seleccion[2])
            {
                pb03.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb03.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void pb04_Click(object sender, EventArgs e)
        {
            // Cambiar el valor (true/false)
            seleccion[3] = !seleccion[3];

            // Recuadro lo seleccionado
            if (seleccion[3])
            {
                pb04.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb04.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void pb05_Click(object sender, EventArgs e)
        {
            // Cambiar el valor (true/false)
            seleccion[4] = !seleccion[4];

            // Recuadro lo seleccionado
            if (seleccion[4])
            {
                pb05.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb05.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void pb06_Click(object sender, EventArgs e)
        {
            // Cambiar el valor (true/false)
            seleccion[5] = !seleccion[5];

            // Recuadro lo seleccionado
            if (seleccion[5])
            {
                pb06.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb06.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void pb07_Click(object sender, EventArgs e)
        {
            // Cambiar el valor (true/false)
            seleccion[6] = !seleccion[6];

            // Recuadro lo seleccionado
            if (seleccion[6])
            {
                pb07.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb07.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void pb08_Click(object sender, EventArgs e)
        {
            // Cambiar el valor (true/false)
            seleccion[7] = !seleccion[7];

            // Recuadro lo seleccionado
            if (seleccion[7])
            {
                pb08.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb08.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void pb09_Click(object sender, EventArgs e)
        {
            // Cambiar el valor (true/false)
            seleccion[8] = !seleccion[8];

            // Recuadro lo seleccionado
            if (seleccion[8])
            {
                pb09.BorderStyle = BorderStyle.Fixed3D; // seleccionado
            }
            else
            {
                pb09.BorderStyle = BorderStyle.None;    // deseleccionado
            }
        }

        private void CaptchaImgForm_Load(object sender, EventArgs e)
        {

        }
    }
}
