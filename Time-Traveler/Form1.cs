﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Security.Principal;



namespace Time_Traveler
{
    public partial class Form1 : Form
    {
        int ticks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (IsUserAdministrator())
            {
                AdminLabel.BackColor = Color.Green;

            }
            else
            {
                AdminLabel.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks += 1;
            if (ticks > 10)
            {
                ticks = 0;
                DateTime dn = GetNetworkTime();
                if (dn.ToString("yyyymmdd").Equals("18990101"))
                {
                    this.BackColor = Color.LightYellow;
                }
                if (DateTime.Now.ToString().Equals(dn.ToString()))
                {
                    this.BackColor = Color.LightGreen;
                    

                }
                else
                {
                    this.BackColor = Color.MistyRose;
                    //label1.Text = "MSD: " + diff.TotalMilliseconds;
                }

                TimeIOLabel.Text = "N: " + dn.ToString("hh:mm:ss");
                UTCLabel.Text = "U: " + DateTime.UtcNow.ToString("hh:mm:ss");
                LocalLabel.Text = "L: " + DateTime.Now.ToString("hh:mm:ss");


            }
            else
            {
                UTCLabel.Text = "U:" + DateTime.UtcNow.ToString("hh:mm:ss");
                LocalLabel.Text = "L: " + DateTime.Now.ToString("hh:mm:ss");

            }

        }

        

        public static DateTime GetNetworkTime()
        {

            try
            {
                //default Windows time server
                const string ntpServer = "time.windows.com";

                // NTP message size - 16 bytes of the digest (RFC 2030)
                var ntpData = new byte[48];

                //Setting the Leap Indicator, Version Number and Mode values
                ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

                var addresses = Dns.GetHostEntry(ntpServer).AddressList;

                //The UDP port number assigned to NTP is 123
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                //NTP uses UDP

                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
                {
                    socket.Connect(ipEndPoint);

                    //Stops code hang if NTP is blocked
                    socket.ReceiveTimeout = 3000;
                    try
                    {
                        socket.Send(ntpData);
                        socket.Receive(ntpData);
                    }
                    catch (System.Net.Sockets.SocketException se)
                    {
                        //ignore and move on...  I hope 
                        return new DateTime(1899, 01, 01);
                    }
                    socket.Close();
                }

                //Offset to get to the "Transmit Timestamp" field (time at which the reply 
                //departed the server for the client, in 64-bit timestamp format."
                const byte serverReplyTime = 40;

                //Get the seconds part
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

                //Get the seconds fraction
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

                //Convert From big-endian to little-endian
                intPart = SwapEndianness(intPart);
                fractPart = SwapEndianness(fractPart);

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

                //**UTC** time
                var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

                return networkDateTime.ToLocalTime();
            }
            catch (System.Net.Sockets.SocketException)
            {
                return new DateTime(1899, 01, 01);
            }


        }

        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }


    
    public bool IsUserAdministrator()
    {
        //bool value to hold our return value
        bool isAdmin;
        WindowsIdentity user = null;
        try
        {
            //get the currently logged in user
            user = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(user);
            isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        catch (UnauthorizedAccessException ex)
        {
            isAdmin = false;
        }
        catch (Exception ex)
        {
            isAdmin = false;
        }
        finally
        {
            if (user != null)
                user.Dispose();
        }
        return isAdmin;
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            //SetAC9HPSystemTime timercontrol = new SetAC9HPSystemTime();
            label2.Text = "Last Time Set: " + SetAC9HPSystemTime.SetTime(GetNetworkTime()).ToString();

            
        }
    }
}
