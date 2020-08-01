using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jackboxapp
{
    public partial class Form1 : Form
    {
            public Form1()
        {;
            Initialize();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button1");
            jackboxRU();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button2");
            jackboxEN();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            github();
        }

        private void button3_Click(object sender, EventArgs e) //english
        {
            englishLanguage();
        }

        private void button4_Click(object sender, EventArgs e) //russian
        {
            russianLanguage();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            changelogbutton();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            changelogbuttonback();
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser3_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkupdatesbutton();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
