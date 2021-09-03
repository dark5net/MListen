using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultipleListenPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < textBox2.Lines.Length-1; i++)
            //{
            //    new Thread(() => this.Exec(textBox2.Lines[i].ToString())) { IsBackground = true }.Start();
            //}
            foreach (string x in textBox2.Lines)
            {
                new Thread(() => this.Exec(x)) { IsBackground = true }.Start();
            }
            
        }

        private void Exec(string cmdline)
        {
            string ncpath = textBox1.Text.Trim();
            Process.Start("CMD.exe", "/K " + ncpath + " " + cmdline);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.dark5.net/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://nmap.org/ncat/");
        }
    }
}
