﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneral_MouseOver(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void btnRegistroLibros_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }
    }

}
