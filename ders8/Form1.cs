using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Second.ToString();
            label2.Text = DateTime.Now.Minute.ToString();
            label3.Text = DateTime.Now.Hour.ToString();



            if (comboBox1.Text == label3.Text && comboBox2.Text == label2.Text)
            {
                timer1.Enabled = false;
                MessageBox.Show("qalx ayaga");

            }

        }
         
    private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);

            }
            for (int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i);

            }
        }
    }
}
