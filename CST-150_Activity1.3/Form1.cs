﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void christmasAnswerBtn_Click(object sender, EventArgs e)
        {
            christmasAnswerTxt.Text = "Christmas Day is December, 25";
        }
    }
}
