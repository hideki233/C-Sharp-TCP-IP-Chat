using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Xml;

namespace wa2client
{
    public partial class frmclient : Form
    {
        public frmclient()
        {
            InitializeComponent();
        }
        IPAddress ipserver;
        int port;
        IPEndPoint ipend;
        Socket client;



       public async void Conexao()
        {
            ipserver = IPAddress.Parse(tbip.Text);
            port = int.Parse(tbport.Text);

            ipend = new IPEndPoint(ipserver, port);
            client = new Socket(ipend.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            await client.ConnectAsync(ipend);
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            Conexao();
        }

         public void enviarmsg()
         {

         string mensagem = tbtext.Text;
             byte[] bufferEnconding = Encoding.UTF8.GetBytes(mensagem);
             client.Send(bufferEnconding);


         }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            enviarmsg();
        }

        private void frmclient_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }

    }
}
