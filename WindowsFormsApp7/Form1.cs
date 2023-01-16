using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int click = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (click == 0)
            {
                fontDialog1.ShowColor = true;

                fontDialog1.Font = textBox1.Font;
                fontDialog1.Color = textBox1.ForeColor;

                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    textBox1.Font = fontDialog1.Font;
                    textBox1.ForeColor = fontDialog1.Color;
                    click++;
                }
            }
            else
            {
                switch (e.Button)
                {

                    case MouseButtons.Left:

                        Label label = new Label();

                        label.Location = new Point((e.X), e.Y);

                        label.Text = textBox1.Text;
                        label.Font = textBox1.Font;
                        label.Height = textBox1.Height;
                        label.Width = textBox1.Width;
                        label.ForeColor = textBox1.ForeColor;
                        this.Controls.Add(label);
                        break;

                    case MouseButtons.Middle:
                        textBox1.Text = "";

                        fontDialog1.ShowColor = true;

                        fontDialog1.Font = textBox1.Font;
                        fontDialog1.Color = textBox1.ForeColor;

                        if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                        {
                            textBox1.Font = fontDialog1.Font;
                            textBox1.ForeColor = fontDialog1.Color;
                        }
                        break;
                    case MouseButtons.Right:
                        Label label2 = new Label();

                        label2.Location = new Point(rnd.Next(0, 700), rnd.Next(0, 500));

                        label2.Text = textBox1.Text;
                        label2.Font = textBox1.Font;
                        label2.Height = textBox1.Height;
                        label2.Width = textBox1.Width;
                        label2.ForeColor = textBox1.ForeColor;
                        this.Controls.Add(label2);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
