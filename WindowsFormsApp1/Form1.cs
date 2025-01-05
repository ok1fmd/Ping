using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t1 = new System.Timers.Timer();
            t1.Interval = 1000;
            t1.Elapsed += OnTimeEvent1;
            t2 = new System.Timers.Timer();
            t2.Interval = 1000;
            t2.Elapsed += OnTimeEvent2;
        }
        System.Timers.Timer t;
        System.Timers.Timer t1;
        System.Timers.Timer t2;
        int h, m, s, h_h, m_m;
        OpenFileDialog openFileDialogFw = new OpenFileDialog();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void btnStartTestIp_Click(object sender, EventArgs e)
        {
            lnbTestIp.Text = "Start Ping";


            if (rdbIp1Ip2.Checked)
            {
                t.Start();
            }
            if (rdbIp1.Checked)
            {
                t1.Start();
            }
            if (rdbIp2.Checked)
            {
                t2.Start();
            }
        }
        private void btnStopTestIp_Click(object sender, EventArgs e)
        {
            t.Stop();
            lnbTestIp.Text = "Test Ping konec";
        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;

                    if (s == 0)
                    {
                        s = 0;
                        m = 0;
                    }
                    if (s == 30)
                    {
                        s = 30;
                        m = 0;
                    }
                    if (s == 60)
                    {
                        s = 0;
                        m = 1;
                        m_m += 1;
                    }
                    if (m_m == 60)
                    //if (m_m == 5)
                    {
                        m = 0;
                        m_m = 0;
                        h += 1;
                    }
                if (h == 1 && m == 0 && s == 0)
                {
                    if (s == 0)
                    {
                        s = 0;
                        m = 0;
                    }
                    if (s == 60)
                    {
                        s = 0;
                        m_m += 1;
                    }
                    if (m_m == 60)
                    //if (m_m == 5)
                    {
                        m = 0;
                        h += 1;
                    }
                }
                if (h == 2)
                {
                    h = 0;
                }
                {
                    if (h == 0 && m == 0 && s == 1)
                    {
                        lnbTestIp.Text = "Start Ping";
                    }
                    //if (h == 0 && m == 0 && s == 30)
                    //{
                    //    lnbTestIp.Text = "Test Ping probíhá.";
                    //    btnPing_Click(sender, e);
                    //    var milliseconds = 25000;
                    //    Thread.Sleep(milliseconds);
                    //}
                    if (h == 0 && m == 1 && s == 0)
                    {
                        lnbTestIp.Text = "Test Ping probíhá.";
                        btnPing_Click(sender, e);
                        btnPing1_Click(sender, e);
                        var milliseconds = 25000;
                        Thread.Sleep(milliseconds);
                    }
                }
            }
            ));
        }
        private void OnTimeEvent1(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;

                if (s == 0)
                {
                    s = 0;
                    m = 0;
                }
                if (s == 30)
                {
                    s = 30;
                    m = 0;
                }
                if (s == 60)
                {
                    s = 0;
                    m = 1;
                    m_m += 1;
                }
                if (m_m == 60)
                //if (m_m == 5)
                {
                    m = 0;
                    m_m = 0;
                    h += 1;
                }
                if (h == 1 && m == 0 && s == 0)
                {
                    if (s == 0)
                    {
                        s = 0;
                        m = 0;
                    }
                    if (s == 60)
                    {
                        s = 0;
                        m_m += 1;
                    }
                    if (m_m == 60)
                    //if (m_m == 5)
                    {
                        m = 0;
                        h += 1;
                    }
                }
                if (h == 2)
                {
                    h = 0;
                }
                {
                    if (h == 0 && m == 0 && s == 1)
                    {
                        lnbTestIp.Text = "Start Ping";
                    }
                    ////if (h == 0 && m == 0 && s == 30)
                    ////{
                    ////    lnbTestIp.Text = "Test Ping probíhá.";
                    ////    btnPing_Click(sender, e);
                    ////    var milliseconds = 25000;
                    ////    Thread.Sleep(milliseconds);
                    //}
                if (h == 0 && m == 1 && s == 0)
                {
                    lnbTestIp.Text = "Test Ping probíhá.";
                    btnPing_Click(sender, e);
                    var milliseconds = 25000;
                    Thread.Sleep(milliseconds);
                }
            }
            }
            ));
        }
        private void OnTimeEvent2(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;

                if (s == 0)
                {
                    s = 0;
                    m = 0;
                }
                if (s == 30)
                {
                    s = 30;
                    m = 0;
                }
                if (s == 60)
                {
                    s = 0;
                    m = 1;
                    m_m += 1;
                }
                if (m_m == 60)
                //if (m_m == 5)
                {
                    m = 0;
                    m_m = 0;
                    h += 1;
                }
                if (h == 1 && m == 0 && s == 0)
                {
                    if (s == 0)
                    {
                        s = 0;
                        m = 0;
                    }
                    if (s == 60)
                    {
                        s = 0;
                        m_m += 1;
                    }
                    if (m_m == 60)
                    //if (m_m == 5)
                    {
                        m = 0;
                        h += 1;
                    }
                }
                if (h == 2)
                {
                    h = 0;
                }
                {
                    if (h == 0 && m == 0 && s == 1)
                    {
                        lnbTestIp.Text = "Start Ping";
                    }
                    //if (h == 0 && m == 0 && s == 30)
                    //{
                    //    lnbTestIp.Text = "Test Ping probíhá.";
                    //    btnPing_Click(sender, e);
                    //    var milliseconds = 25000;
                    //    Thread.Sleep(milliseconds);
                    //}
                    if (h == 0 && m == 1 && s == 0)
                    {
                        lnbTestIp.Text = "Test Ping probíhá.";
                        btnPing1_Click(sender, e);
                        var milliseconds = 25000;
                        Thread.Sleep(milliseconds);
                    }
                }
            }
            ));
        }
        private void btnPing_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(txtIpPing.Text, int.Parse(txtTim.Text));
            PingReply reply2 = ping.Send(txtIpPing.Text, int.Parse(txtTim.Text));
            //77.75.79.222
            using (StreamWriter sw = File.AppendText("logfile.txt"))
            {
                sw.Write(DateTime.Now + "  " + txtIpPing.Text + "  " + reply.Status.ToString() + Environment.NewLine);
                txtLogIp.Text += Environment.NewLine + DateTime.Now + "  " + txtIpPing.Text + "  " + reply.Status.ToString() + "  " + Environment.NewLine;
                sw.Write(DateTime.Now + "  " + txtIpPing.Text + "  " + reply2.Status.ToString() + Environment.NewLine);
                txtLogIp.Text += Environment.NewLine + DateTime.Now + "  " + txtIpPing.Text + "  " + reply2.Status.ToString() + "  " + Environment.NewLine;
            }
        }
        private void btnPing1_Click(object sender, EventArgs e)
        {
            Ping ping1 = new Ping();
            PingReply reply1 = ping1.Send(txtIpPing1.Text, int.Parse(txtTim.Text));
            PingReply reply3 = ping1.Send(txtIpPing1.Text, int.Parse(txtTim.Text));
            //77.75.79.222
            using (StreamWriter sw = File.AppendText("logfile.txt"))
            {
                sw.Write(DateTime.Now + "  " + txtIpPing1.Text + "  " + reply1.Status.ToString() + Environment.NewLine);
                txtLogIp.Text += Environment.NewLine + DateTime.Now + "  " + txtIpPing1.Text + "  " + reply1.Status.ToString() + "  " + Environment.NewLine;
                sw.Write(DateTime.Now + "  " + txtIpPing1.Text + "  " + reply3.Status.ToString() + Environment.NewLine);
                txtLogIp.Text += Environment.NewLine + DateTime.Now + "  " + txtIpPing1.Text + "  " + reply3.Status.ToString() + "  " + Environment.NewLine;
            }
        }

    }
}
