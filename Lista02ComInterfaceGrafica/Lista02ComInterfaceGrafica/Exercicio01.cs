﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista02ComInterfaceGrafica
{
    public partial class Exercicio01 : Form
    {
        int Number = 0;
        
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Number = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Number > 0)
            {
                textBox1.Text = ("Positivo");
            }
            else
            {
                textBox1.Text = ("Não Positivo");
            }
        }

    }
}
