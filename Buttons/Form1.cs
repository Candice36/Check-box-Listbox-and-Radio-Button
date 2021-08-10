using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movies = "";

            if(checkBox1.Checked)
            {
                movies = movies + checkBox1.Text + "\r\n";
            }

            if(checkBox2.Checked)
            {
                movies = movies + checkBox2.Text + "\r\n";
            }

            if(checkBox3.Checked)
            {
                movies = movies + checkBox3.Text + "\r\n";
            }

            if (checkBox4.Checked)
            {
                movies = movies + checkBox4.Text + "\r\n";
            }

            if (checkBox5.Checked)
            {
                movies = movies + checkBox5.Text + "\r\n";
            }

            if (checkBox6.Checked)
            {
                movies = movies + checkBox6.Text + "\r\n";
            }

                  MessageBox.Show(movies);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Comedy");
            listBox1.Items.Add("Action");
            listBox1.Items.Add("Science Fiction");
            listBox1.Items.Add("Animation");
            listBox1.Items.Add("Romance");
            listBox1.Items.Add("Horror/Thriller");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Long Kiss Goodnight");
            listBox1.Items.Add("Illegal Tenders");
            listBox1.Items.Add("Fast and Furious");
            listBox1.Items.Add("San Andreas");
            listBox1.Items.Add("Aquaman");
            listBox1.Items.Add("Men in Black");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Bring It On");
            listBox1.Items.Add("American Pie");
            listBox1.Items.Add("Friday");
            listBox1.Items.Add("Serial Mom");
            listBox1.Items.Add("Goodburger");
            listBox1.Items.Add("We're the Millers");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Dream Catcher");
            listBox1.Items.Add("The Fly");
            listBox1.Items.Add("Species");
            listBox1.Items.Add("Slugs");
            listBox1.Items.Add("Invasion of the body snatchers");
            listBox1.Items.Add("Squirm");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Lion King");
            listBox1.Items.Add("Aladdin");
            listBox1.Items.Add("Jungle Book");
            listBox1.Items.Add("Alvin and Chipmunks");
            listBox1.Items.Add("101 Dalmations");
            listBox1.Items.Add("Lilo and Stitch");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Notebook");
            listBox1.Items.Add("So first Dates");
            listBox1.Items.Add("My best friends wedding");
            listBox1.Items.Add("Bridesmaid");
            listBox1.Items.Add("Wedding Planner");
            listBox1.Items.Add("Monster-N-Law");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Halloween");
            listBox1.Items.Add("Friday the 13th");
            listBox1.Items.Add("Nightmare on Elm Street");
            listBox1.Items.Add("Texas Chainsaw Massacre");
            listBox1.Items.Add("Carrie");
            listBox1.Items.Add("IT");
        }
    }
}
