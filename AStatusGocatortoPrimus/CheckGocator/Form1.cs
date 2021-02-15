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
using System.Threading;
using EasyModbus;

namespace CheckGocator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient GoClinet = null;
        NetworkStream GoStream = null;
        Thread ThreadGo = null;
        bool ThreadGo_Stage = false;

        ModbusClient modbusIO = null;

        private void Show(String msg)
        {
            MessageBox.Show(msg);
        }
        private void ThreadReadGocator()
        {
            while (ThreadGo_Stage)
            {
                SendGocator(GoClinet,GoStream,"Health,20000\r\n");
                String sensor_stage = ReadGocator(GoClinet, GoStream);
                
                try
                {
                    string[] words = sensor_stage.Split(',');
                    Int32 stage = Convert.ToInt32(words[1]);

                    if (stage <= 0)
                    {
                        label3.Invoke(new Action(() => label3.Text = "Sensor : OFF"));
                        primus(modbusIO, stage);
                    }
                    else
                    {
                        label3.Invoke(new Action(() => label3.Text = "Sensor : ON"));
                        primus(modbusIO, stage);
                    }

                }
                catch(Exception ex)
                {

                }
                Thread.Sleep(200) ;
            }
        }
        private void btnConnectGo_Click(object sender, EventArgs e)
        {
            try
            {
                GoClinet = new TcpClient();
                GoClinet.Connect(tbipGo.Text,Convert.ToInt32(tbportGo.Text));
                btnConnectGo.BackColor = Color.LightGreen;
                Show("Connected Gocator");
            }
            catch (Exception ex)
            {
                Show("Error Connect Gocator");
            }
        }
        private void btnDisconnectGo_Click(object sender, EventArgs e)
        {
            if (GoClinet != null)
            {
                
                GoClinet.Close();
                btnConnectGo.BackColor = SystemColors.Control;
            }
            if(modbusIO != null)
            {
                modbusIO.Disconnect();
                btnConnectMod.BackColor = SystemColors.Control;
            }
            if(ThreadGo != null)
            {
                ThreadGo_Stage = false;
                ThreadGo = null;
                btnStart.BackColor = SystemColors.Control;
            }
        }
        private void SendGocator(TcpClient client,NetworkStream stream,String msg)
        {
            byte[] buff = System.Text.Encoding.ASCII.GetBytes(msg);
            stream = client.GetStream();
            stream.Write(buff, 0, buff.Length);
        }
        private string ReadGocator(TcpClient client, NetworkStream stream)
        {
            stream = client.GetStream();
            byte[] buff = new byte[256];
            stream.Read(buff, 0, buff.Length);
            String data = System.Text.Encoding.ASCII.GetString(buff, 0, buff.Length);
            return data;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (GoClinet != null && modbusIO != null)
            {
                ThreadGo = new Thread(new ThreadStart(ThreadReadGocator));
                ThreadGo_Stage = true;
                ThreadGo.Start();
                btnStart.BackColor = Color.LightGreen;
            }
        }
        /// <summary>
        /// ///////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>////////////////
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void primus(ModbusClient client,Int32 i)
        {
            bool stage;
            if (i <= 0)
            {
                stage = false;
            }
            else
            {
                stage = true;
            }

            client.WriteSingleCoil(0, stage);
        }

        private void btnConnectMod_Click(object sender, EventArgs e)
        {
            try
            {
                modbusIO = new ModbusClient();
                modbusIO.Connect(tbipMod.Text, Convert.ToInt32(tbportMod.Text));
                btnConnectMod.BackColor = Color.LightGreen;
                Show("Connected ModbusIO");
            }
            catch (Exception ex)
            {
                Show("Error Connect ModbusIO");
            }
        }
    }
}
