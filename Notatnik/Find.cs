﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                buttonZnajdzNastepny.Enabled = true;
            else
                buttonZnajdzNastepny.Enabled = false;
        }

        private void buttonZnajdzNastepny_Click(object sender, EventArgs e)
        {
            Form1.FindText = textBox1.Text;

            if (checkBoxWielkoscLiter.Checked)
                Form1.WielkoscLiter = true;
            else
                Form1.WielkoscLiter = false;

                this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Form1.FindText = "";
            this.Close();
        }
    }
}
