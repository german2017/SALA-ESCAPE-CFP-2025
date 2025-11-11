using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScapeRoomCFP
{
    public partial class Word_Io : Form
    {

        WordIO puzzle = new WordIO();
        int intentos = 0;


        public Word_Io()
        {
            InitializeComponent();
        }

        private void Avanzar(TextBox actual, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            actual.Text = e.KeyChar.ToString().ToLower();
            e.Handled = true;

            this.SelectNextControl(actual, true, true, true, true);
        }


        void LimpiarCajas()
        {
            txtL1.Clear();
            txtL2.Clear();
            txtL3.Clear();
            txtL4.Clear();
            txtL5.Clear();
            txtL6.Clear();
            txtL7.Clear();
            txtL8.Clear();
            txtL1.Focus();
        }

        private void Colorear(TextBox txt, char letraIntento, char letraCorrecta, string palabra)
        {
            if (letraIntento == letraCorrecta)
                txt.BackColor = Color.LightGreen;
            else if (palabra.Contains(letraIntento))
                txt.BackColor = Color.Yellow;
            else
                txt.BackColor = Color.IndianRed;
        }
        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string intento = (txtL1.Text + txtL2.Text + txtL3.Text + txtL4.Text +
                     txtL5.Text + txtL6.Text + txtL7.Text + txtL8.Text);

            intento = intento.ToLower();

            if (intento.Length != 8 || intento.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Completá todas las letras.");
                return;
            }


            string correcta = puzzle.ObtenerPalabraCorrecta();

            Colorear(txtL1, intento[0], correcta[0], correcta);
            Colorear(txtL2, intento[1], correcta[1], correcta);
            Colorear(txtL3, intento[2], correcta[2], correcta);
            Colorear(txtL4, intento[3], correcta[3], correcta);
            Colorear(txtL5, intento[4], correcta[4], correcta);
            Colorear(txtL6, intento[5], correcta[5], correcta);
            Colorear(txtL7, intento[6], correcta[6], correcta);
            Colorear(txtL8, intento[7], correcta[7], correcta);

            lstIntentos.Items.Add(intento);

            if (puzzle.Validar(intento))
            {
                MessageBox.Show("¡Correcto!");
                btnComprobar.Enabled = false;
                return;
            }
            intentos++;
            lblIntentos.Text = $"{intentos}";

            LimpiarCajas();
        }


        #region KeyPress
        private void txtL1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Avanzar(txtL1, e);
        }

        private void txtL2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Avanzar(txtL2, e);
        }

        private void txtL3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Avanzar(txtL3, e);
        }

        private void txtL4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Avanzar(txtL4, e);
        }

        private void txtL5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Avanzar(txtL5, e);
        }

        private void txtL6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Avanzar(txtL6, e);
        }

        private void txtL7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Avanzar(txtL7, e);
        }
        private void txtL8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Avanzar(txtL8, e);
        }
        #endregion

        private void txtL5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
