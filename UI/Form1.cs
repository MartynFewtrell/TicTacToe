using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        Engine gameEngine = new Engine();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(1))
            {
                button1.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(2))
            {
                button2.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(3))
            {
                button3.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(4))
            {
                button4.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(5))
            {
                button5.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(6))
            {
                button6.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(7))
            {
                button7.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(8))
            {
                button8.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (gameEngine.MoveIsValid(9))
            {
                button9.Text = "X";
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
        }
    }
}
