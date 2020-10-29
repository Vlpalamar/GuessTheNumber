using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int i;
        int randi;
        public Random rand = new Random();
        

        public Form1()
        {
            InitializeComponent();
            randi=rand.Next(0, 2000);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        int count = 0;
        private void Play_Click(object sender, EventArgs e)
        {
            i =Convert.ToInt32(textBox1.Text);
            IsTrueLabel.Visible = true;
            
            CountLabel.Text += (++count).ToString() + ". " + i.ToString()+". " ;
            if (i<0 || i>2000)
            {
                IsTrueLabel.Text = "nuber is not in a range,try again";
                CountLabel.Text += "not in a range";
                
            }
            else if (i==randi)
            {
                IsTrueLabel.Text = $"Congratulation, u won\n\n u were needed in { count}Tries ";
                CountLabel.Text += "True";
                Play.Visible = false;
                Replay.Visible = true;
               
                

            }
            else if(i< randi)
            {
                IsTrueLabel.Text = "u number is less then computer's number,try again";
                CountLabel.Text += "Need Large";
               
            }
            else if (i > randi)
            {
                IsTrueLabel.Text = "u number is large then computer's number,try again";
                CountLabel.Text += "Need Less";
            }
            CountLabel.Text += "\n";

        }

        private void Replay_Click(object sender, EventArgs e)
        {
            Replay.Visible = false;
            CountLabel.Text = "";
            count = 0;
            randi = rand.Next(0, 2000);
            textBox1.Text = "";
            IsTrueLabel.Text = "";
            Play.Visible = true;
        }
    }
}
