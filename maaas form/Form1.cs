using System;
using System.Windows.Forms;

namespace maaas_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal rutbe, aklad, maas=0, edv, pens, tibb, kiraye, yemek, xdmili, xxs, derece, xrcdil, artim, vergiguz, vergiguz2;

            if (comboBox1.Text == "Kapitan")
                rutbe = 146;
            else if (comboBox1.Text == "Əsgər")
                rutbe = 92;
            else if (comboBox1.Text == "Kiçik Çavuş")
                rutbe = 114;
            else if (comboBox1.Text == "Gizir")
                rutbe = 124;
            else if (comboBox1.Text == "Baş Gizir")
                rutbe = 127;
            else if (comboBox1.Text == "Leytenant")
                rutbe = 140;
            else if (comboBox1.Text == "Baş Leytenant")
                rutbe = 144;
            else if (comboBox1.Text == "Mayor")
                rutbe = 148;
            else if (comboBox1.Text == "Polkovnik Leytenant")
                rutbe = 150;
            else if (comboBox1.Text == "Polkovnik")
                rutbe = 150;
            else
                rutbe = 0;

            aklad = Convert.ToDecimal(textBox2.Text);
            yemek = Convert.ToDecimal(textBox1.Text);
            kiraye = Convert.ToDecimal(textBox3.Text);
            edv = (aklad + rutbe - 200) * Convert.ToDecimal( 0.14);

            if (comboBox2.Text == "2 il")
                xdmili = (aklad + rutbe) * Convert.ToDecimal( 0.05);
            else if (comboBox2.Text == "5 il")
                xdmili = (aklad + rutbe) * Convert.ToDecimal( 0.1);
            else if (comboBox2.Text == "10 il")
                xdmili = (aklad + rutbe) * Convert.ToDecimal(0.15);
            else if (comboBox2.Text == "15 il")
                xdmili = (aklad + rutbe) * Convert.ToDecimal(0.20);
            else if (comboBox2.Text == "20 il")
                xdmili = (aklad + rutbe) * Convert.ToDecimal(0.25);
            else if (comboBox2.Text == "25 il")
                xdmili = (aklad + rutbe) * Convert.ToDecimal(0.30);
            else
                xdmili = 0;

            if (comboBox3.Text == "15%")
                xxs = aklad * Convert.ToDecimal(0.15);
            else if (comboBox3.Text == "20%")
                xxs = aklad * Convert.ToDecimal(0.2);
            else if (comboBox3.Text == "30%")
                xxs = aklad * Convert.ToDecimal(0.3);
            else
                xxs = 0;

            if (comboBox4.Text == "USTA (zabit)")
                derece = aklad * Convert.ToDecimal(0.35);
            else if (comboBox4.Text == "USTA (gizir)")
                derece = aklad * Convert.ToDecimal(0.30);
            else if (comboBox4.Text == "1.derece (zabit)")
                derece = aklad * Convert.ToDecimal(0.25);
            else if (comboBox4.Text == "1.derece (gizir)")
                derece = aklad * Convert.ToDecimal(0.2);
            else if (comboBox4.Text == "2.derece (zabit)")
                derece = aklad * Convert.ToDecimal(0.15);
            else if (comboBox4.Text == "2.derece (gizir)")
                derece = aklad * Convert.ToDecimal(0.1);
            else
                derece = 0;

            if (comboBox6.Text == "15%")
                xrcdil = aklad * Convert.ToDecimal(0.15);
            else if (comboBox6.Text == "10%")
                xrcdil = aklad * Convert.ToDecimal(0.1);
            else
                xrcdil = 0;

            if (comboBox5.Text=="20%")
                artim = aklad* Convert.ToDecimal(0.2);
            else
                artim = 0;

          

            pens = Convert.ToDecimal(0.03) * (aklad + rutbe + xdmili + xxs + derece + xrcdil+artim);
            tibb = Convert.ToDecimal(0.02) * (aklad + rutbe + xdmili + xxs + derece + xrcdil+artim);
            maas = aklad + rutbe + xdmili + xxs + derece + xrcdil + yemek + kiraye + artim - edv - tibb - pens;

            if (checkBox1.Checked)
                maas = maas + 7;

            if (checkBox2.Checked == true)
                maas = maas + 56;

            label11.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;

            label11.Text = Convert.ToString(maas) + " azn";
            label13.Text = "e.d.v:" + " -" + Convert.ToString(edv) + " azn";
            label14.Text = "pensiay:" + " -" + Convert.ToString(pens) + " azn";
            label15.Text = "tibbi sigorta:" + " -" + Convert.ToString(tibb) + " azn";
            label17.Text = "artım" + " -" + Convert.ToString(artim) + " azn";
            label18.Text = "xid.ili:" + xdmili.ToString() + " azn";
            label19.Text = "xus.xid.s:" + xxs.ToString() + " azn";
            label20.Text = "derece:" + derece.ToString() + " azn";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label11.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false; 
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }
    }
}
