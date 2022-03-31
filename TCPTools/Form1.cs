using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TCPTools.SocketServer;

namespace TCPTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 服务端业务
        string serverIP = "";
        int serverPort;
        TcpService server;

        //服务端侦听
        private void btnStart_Click(object sender, EventArgs e)
        {
            serverIP = tboxIP.Text;

            if (string.IsNullOrEmpty(serverIP))
            {
                MessageBox.Show("IP不能为空");
                return;
            }

            if (!int.TryParse(tboxPort.Text, out serverPort))
            {
                MessageBox.Show("端口必须为数字");
                return;
            }
            btnStart.Enabled = false;
            tboxIP.Enabled = false;

            try
            {
                //在指定端口上建立监听线程
                server = new TcpService(serverPort, 100, serverIP);
                server.Connected += new NetEventHandler(server_Connected);
                server.DisConnect += new NetEventHandler(server_DisConnect);
                server.Start();

                Log("服务启动成功");
            }
            catch (Exception ex)
            {
                Log("服务启动失败,错误信息：" + ex.Message);
            }
        }
        //服务端断开
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                btnStart.Enabled = true;
                tboxIP.Enabled = true;

                server.Close();
                Log("服务结束成功");
            }
        }

        //客户端断开事件
        void server_DisConnect(IDataTransmit sender, NetEventArgs e)
        {
            RefreshClient();
            Log(sender.RemoteEndPoint.ToString() + " 连接断开");
        }

        //客户端连接事件
        void server_Connected(IDataTransmit sender, NetEventArgs e)
        {

            RefreshClient();
            Log(sender.RemoteEndPoint.ToString() + " 连接成功");
            sender.ReceiveData += new NetEventHandler(sender_ReceiveData);
            //接收数据
            sender.Start();
        }

        //服务端接收数据
        void sender_ReceiveData(IDataTransmit sender, NetEventArgs e)
        {
            try
            {
                byte[] data = (byte[])e.EventArg;

                try
                {
                    string str = Encoding.UTF8.GetString(data);
                    Log("接收" + sender.RemoteEndPoint.ToString() + "消息：" + str);
                }
                catch (Exception ex)
                {
                    Log("服务器监听出错：" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Log("处理数据出错：" + ex.Message);
            }
        }

        //刷新客户端
        void RefreshClient()
        {
            var session = server.Session;

            Invoke(new Action(() =>
            {
                lstClient.Items.Clear();
                foreach (var item in server.Session)
                {
                    lstClient.Items.Add(item.Key);
                }
            }));
        }

        //服务端清空消息
        private void btnServerClear_Click(object sender, EventArgs e)
        {
            lstServerMsg.Items.Clear();
        }

        //服务端给客户端发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            var item = lstClient.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("请选择客户端");
                return;
            }
            var ipArr = item.ToString().Split(':');
            IPAddress ip = IPAddress.Parse(ipArr[0]);

            IPEndPoint point = new IPEndPoint(ip, int.Parse(ipArr[1]));

            string msg = richServerMsg.Text;

            if (string.IsNullOrEmpty(msg))
            {
                MessageBox.Show("请输入发送的消息");
                return;
            }

            server.Session[point].Send(msg);

            Log("发送消息成功");
        }

        #endregion

        #region 客户端业务

        //客户端socket
        Socket client;

        //客户端连接服务端
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress ip = IPAddress.Parse(tboxClientIP.Text);
                IPEndPoint point = new IPEndPoint(ip, int.Parse(tboxClientPort.Text));
                client.Connect(point);

                LogClient("连接成功");

                btnConnect.Enabled = false;

                Thread th = new Thread(ReceiveMsg)
                {
                    IsBackground = true
                };
                th.Start();
            }
            catch (Exception ex)
            {
                LogClient(ex.Message);
            }
        }

        //客户端接收服务端消息
        void ReceiveMsg()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int n = client.Receive(buffer);
                    string s = Encoding.UTF8.GetString(buffer, 0, n);
                    LogClient(s);
                }
                catch (Exception ex)
                {
                    LogClient(ex.Message);
                    break;
                }

            }
        }

        //客户端断开连接
        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                btnConnect.Enabled = true;
                client.Dispose();
                client.Close();
            }
            LogClient("断开成功");
        }

        //客户端发送消息
        private void btnClientSend_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("请连接服务端");
                return;
            }

            string msg = tboxMsg.Text;

            if (string.IsNullOrEmpty(msg))
            {
                MessageBox.Show("请输入消息");
                return;
            }

            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            client.Send(buffer);
            LogClient("发送成功");
        }

        //客户端清空消息
        private void btnClearMsg_Click(object sender, EventArgs e)
        {
            lstClientMsg.Items.Clear();
        }

        #endregion

        #region 记录消息

        //服务端日志
        void Log(string msg)
        {
            Invoke(new Action(() =>
            {
                lstServerMsg.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "|" + msg);
            }));
        }

        //客户端日志
        void LogClient(string msg)
        {
            Invoke(new Action(() =>
            {
                lstClientMsg.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "|" + msg);
            }));
        }
        #endregion
    }
}
