using CodigosSecretosForm;
using desafio1Form;

namespace ScapeRoomCFP
{
    public partial class Form1 : Form
    {
        private GameManager gm;
        public Form1(GameManager manager)
        {
            InitializeComponent();
            gm = manager;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        //para iniciar timer = timer1.Start().   Luego se empezaria a ejecutar todo lo que este dentro del evento Tick

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir formulario del chat
            Chat formChat = new Chat(gm);
            formChat.MdiParent = this;
            formChat.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //abrir formulario del captcha
            CaptchaImgForm formCaptchaImgForm = new CaptchaImgForm();
            formCaptchaImgForm.MdiParent = this;
            formCaptchaImgForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //abrir formulario del wordio
            Word_Io formWordio = new Word_Io();
            formWordio.MdiParent = this;
            formWordio.Show();
        }

        private void btnDesafio1_Click(object sender, EventArgs e)
        {
            //abrir formulario del frmDesafio1
            frmDesafio1 Desafio1 = new frmDesafio1();
            Desafio1.MdiParent = this;
            Desafio1.Show();
        }

        private void btnDesafio2_Click(object sender, EventArgs e)
        {
            frmCodigosSecretos Desafio2 = new frmCodigosSecretos();
            Desafio2.MdiParent = this;
            Desafio2.Show();
        }
    }
}
