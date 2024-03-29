﻿/*
 * Created by: Lana ZE
 * Created on: D13-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Hello World International
 * This program will display "Hello,World!" in 4 different languages
 * once u click on a language itwill change automatically
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloIntLanaZE
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void LblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void Grp1_Enter(object sender, EventArgs e)
        {

        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //this label says hello world in english when clicked
            this.lblHelloWorld.Text = "hello, World!";
        }

        private void RadSpanish_CheckedChanged(object sender, EventArgs e)
        {
            //this label says hello world in Spanish
            this.lblHelloWorld.Text = "Hola, Mundo!";
       }

        private void RadArabic_CheckedChanged(object sender, EventArgs e)
        {
            //this label says hello world in Arabic
            this.lblHelloWorld.Text = "!مرحبا بالعالم";
        }

        private void RadFilipino_CheckedChanged(object sender, EventArgs e)
        {
            //This label says hello world in Filipino
            this.lblHelloWorld.Text = "Kumusta, Mundo!";
        }
    }
}
