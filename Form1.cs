using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassForm
{

    public partial class Form1 : Form
    {
        double cafe;
        double total;
       
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "A-76";
            label9.Text = "6.40";
            FirstInitialize();
            total = 0;
        }
        void FirstInitialize() {

           
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
           

            cafe = 0;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "A-76")
            {


                label9.Text = "6.40";
            }
            else if ((string)comboBox1.SelectedItem == "A-74")
            {


                label9.Text = "5.40";
            }
            else if ((string)comboBox1.SelectedItem == "A-72")
            {


                label9.Text = "4.40";
            }
            else if ((string)comboBox1.SelectedItem == "A-70")
            {


                label9.Text = "3.40";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox1.Enabled = true;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            groupBox4.Text = "To pay";
            if (textBox1.Text != "")
            {
                label11.Text = $"{(double.Parse(label9.Text) * double.Parse(textBox1.Text))} ";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            groupBox4.Text = "To issue";
            if (textBox2.Text != "")
            {
                label11.Text = $"{Math.Round(double.Parse(textBox2.Text) / double.Parse(label9.Text), 1)} ";
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox3.Text != "")
                {
                    textBox3.ReadOnly = true;
                    cafe += double.Parse(label3.Text) * double.Parse(textBox3.Text);
                }

            }
            else
            {

                textBox3.ReadOnly = false;
                cafe -= double.Parse(label3.Text) * double.Parse(textBox3.Text);
            }
            label12.Text = cafe.ToString() ;
        }

        private void checkBox2_CheckChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                if (checkBox2.Checked == true)
                {
                    textBox4.ReadOnly = true;
                    cafe += double.Parse(label4.Text) * double.Parse(textBox4.Text);
                }

            }
            else
            {

                textBox4.ReadOnly = false;
                cafe -= double.Parse(label4.Text) * double.Parse(textBox4.Text);
            }
            label12.Text = cafe.ToString() ;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                if (checkBox3.Checked == true)
                {
                    textBox5.ReadOnly = true;
                    cafe += double.Parse(label5.Text) * double.Parse(textBox5.Text);
                }

            }
            else
            {

                textBox5.ReadOnly = false;
                cafe -= double.Parse(label5.Text) * double.Parse(textBox5.Text);
            }
            label12.Text = cafe.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                if (textBox6.Text != "")
                {
                    textBox6.ReadOnly = true;
                    cafe += double.Parse(label6.Text) * double.Parse(textBox6.Text);
                }

            }
            else
            {

                textBox6.ReadOnly = false;
                cafe -= double.Parse(label6.Text) * double.Parse(textBox6.Text);


            }
            label12.Text = cafe.ToString() ;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            label13.Text += double.Parse(label11.Text) + double.Parse(label12.Text);

            total += double.Parse(label13.Text);
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total income for today is {total}","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FirstInitialize();
        }
    }
}
