using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace The_definition_of_Insanity
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            tb_LocalIP.Text = GetLocalIP();
            tb_RemoteIP.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "127.0.0.1";
        }

        private void label_Connect_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(tb_LocalIP.Text), Convert.ToInt32(tb_LocalPort.Text));
            socket.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(tb_RemoteIP.Text), Convert.ToInt32(tb_RemotePort.Text));
            socket.Connect(epRemote);

            buffer = new byte[1500];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                lb_Conversation.Items.Add("\rFriend: " + receivedMessage);

                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(rtb_Message.Text);

            socket.Send(sendingMessage);

            lb_Conversation.Items.Add("\rMe: " + rtb_Message.Text);
            rtb_Message.Text = "";
        }

        private void rtb_Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case (char)Keys.Enter:
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    byte[] sendingMessage = new byte[1500];
                    sendingMessage = aEncoding.GetBytes(rtb_Message.Text);

                    socket.Send(sendingMessage);

                    lb_Conversation.Items.Add("\rMe: " + rtb_Message.Text);
                    rtb_Message.Text = "";
                    break;
            }
        }
    }
}
