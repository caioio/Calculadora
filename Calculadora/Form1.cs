using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcEvent(object sender, EventArgs e)
        {
            tBmensagem.Text = " ";
            try
            {
                //double result = (double.Parse(textBox2.Text) + double.Parse(textBox1.Text));
                textBox3.Text = (double.Parse(textBox2.Text) + double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                tBmensagem.Text = ex.ToString();
            }
        }
    }
}
