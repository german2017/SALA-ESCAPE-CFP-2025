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

    }
}
