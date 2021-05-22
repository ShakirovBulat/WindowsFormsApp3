using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var graphics = pictureBox1.CreateGraphics();
            var pen = new Pen(Color.Blue, 4);
            string figure = comboBox1.Text;
            string color = comboBox2.Text;
            string thickness = comboBox3.Text;
            if (color == "Yellow")
            {
                pen = new Pen(Color.Yellow, 4);
            }
            if (color == "Yellow" && thickness == "4")
            {
                pen = new Pen(Color.Yellow, 4);
            }
            if (color == "Yellow" && thickness == "5")
            {
                pen = new Pen(Color.Yellow, 5);
            }
            if (color == "Yellow" && thickness == "6")
            {
                pen = new Pen(Color.Yellow, 6);
            }
            if (color == "Black")
            {
                pen = new Pen(Color.Black, 4);
            }
            if (color == "Black" && thickness == "4")
            {
                pen = new Pen(Color.Black, 4);
            }
            if (color == "Black" && thickness == "5")
            {
                pen = new Pen(Color.Black, 5);
            }
            if (color == "Black" && thickness == "6")
            {
                pen = new Pen(Color.Black, 6);
            }
            if (color == "Pink")
            {
                pen = new Pen(Color.Pink, 4);
            }
            if (color == "Pink" && thickness == "4")
            {
                pen = new Pen(Color.Pink, 4);
            }
            if (color == "Pink" && thickness == "5")
            {
                pen = new Pen(Color.Pink, 5);
            }
            if (color == "Pink" && thickness == "6")
            {
                pen = new Pen(Color.Pink, 6);
            }
            if (color == "Orange")
            {
                pen = new Pen(Color.Orange, 4);
            }
            if (color == "Orange" && thickness == "4")
            {
                pen = new Pen(Color.Orange, 4);
            }
            if (color == "Orange" && thickness == "5")
            {
                pen = new Pen(Color.Orange, 5);
            }
            if (color == "Orange" && thickness == "6")
            {
                pen = new Pen(Color.Orange, 6);
            }
            if (color == "Blue")
            {
                pen = new Pen(Color.Blue, 4);
            }
            if (color == "Blue" && thickness == "4")
            {
                pen = new Pen(Color.Blue, 4);
            }
            if (color == "Blue" && thickness == "5")
            {
                pen = new Pen(Color.Blue, 5);
            }
            if (color == "Blue" && thickness == "6")
            {
                pen = new Pen(Color.Blue, 6);
            }
            if (color == "Red")
            {
                pen = new Pen(Color.Red, 4);
            }
            if (color == "Red" && thickness == "4")
            {
                pen = new Pen(Color.Red, 4);
            }
            if (color == "Red" && thickness == "5")
            {
                pen = new Pen(Color.Red, 5);
            }
            if (color == "Red" && thickness == "6")
            {
                pen = new Pen(Color.Red, 6);
            }
            if (figure == "Line")
            {
                graphics.DrawLine(pen, new Point(1, 1), new Point(100, 100));
            }
            if (figure == "Ellipse")
            {
                graphics.DrawEllipse(pen, 50, 50, 60, 60);
            }
            if (figure == "Rectangle")
            {
                graphics.DrawRectangle(pen, 0, 0, 50, 50);
            }
            if (figure == "Triangle")
            {
                Point point1 = new Point(50, 50);
                Point point2 = new Point(300, 90);
                Point point3 = new Point(100, 200);

                graphics.DrawLines(pen, new[] { point1, point2, point3, point1 });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG| All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Не тот файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Как ты ее хочешь сохранить а?";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP| Image Files(*.JPG)|*.JPG| Image Files(*.GIF)|*.GIF| Image Files(*.PNG)|*.PNG| All files (*.*)|*.*";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("что-то пошло не так!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Graphics gph = pictureBox1.CreateGraphics();
            gph.Clear(SystemColors.Window);
        }

            bool Drow;
            private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graf = pictureBox1.CreateGraphics();
            if (Drow == true)
            {
                graf.FillEllipse(Brushes.Black, e.X, e.Y, 3, 3);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Drow = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Drow = false;
        }
    }
}
