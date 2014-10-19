using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11FindTheThirdElementFromLast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ThirdElementFromLast x = new ThirdElementFromLast(textBox1.Text.Split(','));
            label2.Text = x.GetThirdElementFromLast();
        }
    }
}
