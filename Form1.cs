using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22SubatOrnekk
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Button[,] button = new Button[11,11];   
            int top=0;
            int left = 0;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 40;
                    button[i, j].Height = 40;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    this.Controls.Add(button[i, j]);
                    left += 40;
                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                    }
                }
                top += 40;
                left = 0;

            }
        }
    }
}
