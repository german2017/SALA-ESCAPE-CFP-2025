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
    public partial class Chat : Form
    {
        private GameManager gm = new GameManager();
        private ChatManager chat;
        public Chat(GameManager manager)
        {
            InitializeComponent();
            gm = manager;
            chat = new ChatManager(gm);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Mostrar el primer mensaje al iniciar el chat en el label
            label1.Text = chat.RecibirPrimerMensaje();
        }
    }
}
