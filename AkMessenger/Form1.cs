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
using System.IO;

namespace AkMessenger
{
    public partial class Form1 : Form
    {
        public int numOfmsgs, numSent;
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public String TextToSend;
        public String name;
        public Form1()
        {
            InitializeComponent();
            numOfmsgs = 0;
            numSent = 0;
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIpLocal.Text = address.ToString();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            client = new TcpClient();
            /*try
            {
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(txtIpClient.Text), int.Parse(txtPortClient.Text));
                lstChat.AppendText("Your IP is: " + txtIpClient.Text);
            }
            catch (Exception ex)
            {
                lstChat.AppendText("Your IP is: " + txtIpClient.Text);
            }*/

            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(txtIpClient.Text), int.Parse(txtPortClient.Text));

            try
             {
                 client.Connect(IpEnd);

                 if (client.Connected)
                 {
                     lstChat.AppendText("Connected to server" + "\n");
                     connPan.BackColor = Color.Green;
                     panel1.Visible = false;
                     pnlTop2.Visible = true;
                     txtName2.Text = txtName.Text;
                     txtIpClient2.Text = txtIpClient.Text;
                     name = txtName.Text;
                     STW = new StreamWriter(client.GetStream());
                     STR = new StreamReader(client.GetStream());
                     STW.AutoFlush = true;
                     backgroundWorker1.RunWorkerAsync();
                     backgroundWorker2.WorkerSupportsCancellation = true;

                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("This is an error message: " + ex.Message.ToString());
             }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    if(numOfmsgs == 0)
                    {
                        this.lstChat.Invoke(new MethodInvoker(delegate ()
                        {
                            lstChat.AppendText("\n");
                        }));
                        numOfmsgs++;
                        numSent = 0;
                    }
                        this.lstChat.Invoke(new MethodInvoker(delegate ()
                        {
                            lstChat.AppendText(recieve + "\n");
                        }));
                    
                    recieve = "";
                }
                catch (Exception ex)
                {
                    connPan.BackColor = Color.Red;
                    this.lstChat.Invoke(new MethodInvoker(delegate ()
                    {
                        lstChat.AppendText("Connection has been lost" + "\n");
                    }));
                    
                    //MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(name + ": " + TextToSend + "\t \t" + DateTime.Now.ToString("h:mm:ss tt"));
                if(numSent == 0)
                {
                    this.lstChat.Invoke(new MethodInvoker(delegate ()
                    {
                        lstChat.AppendText("\n");
                    }));
                    numSent++;
                    numOfmsgs = 0;

                }
                    this.lstChat.Invoke(new MethodInvoker(delegate ()
                    {
                        lstChat.AppendText("    - " + TextToSend + "\t \t" + DateTime.Now.ToString("h:mm:ss tt") + "\n");
                    }));    
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                TextToSend = txtMessage.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            txtMessage.Text = "";
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtPortLocal.Text));
            //connPan.BackColor = Color.Yellow;
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            lstChat.AppendText("Connection established on port: " + txtPortLocal.Text + "\n");
            connPan.BackColor = Color.Green;
            panel1.Visible = false;
            pnlTop2.Visible = true;
            txtName2.Text = txtName.Text;
            txtIpClient2.Text = txtIpClient.Text;
            name = txtName.Text;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter){
                if (txtMessage.Text != "")
                {
                    TextToSend = txtMessage.Text;
                    backgroundWorker2.RunWorkerAsync();
                }
                txtMessage.Text = "";
            }
            
        }

        private void txtPortLocal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPortClient_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPortLocal_DoubleClick(object sender, EventArgs e)
        {
            txtPortLocal.ReadOnly = false;
        }

        private void txtPortClient_DoubleClick(object sender, EventArgs e)
        {
            txtPortClient.ReadOnly = false;
        }

        private void pnlTop2_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = true;
            pnlTop2.Visible = false;
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
