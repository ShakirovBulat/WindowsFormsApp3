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
            var graphics = panel1.CreateGraphics();
            var pen = new Pen(Color.Blue, 4);
            graphics.DrawEllipse(pen, 50, 50, 60, 60);
            graphics.DrawLine(new Pen(Color.Red, 10), new Point(1, 1), new Point(100, 100));
            graphics.DrawRectangle(pen, 0, 0, 50, 50);
        }
    }
}
