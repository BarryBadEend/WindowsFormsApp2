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
        public Form1()
        {
            InitializeComponent();
        }
    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int p;
            Pen blackPen = new Pen(Brushes.Black);

            for (int y = 0; y <= 6; ++y)
            {
                e.Graphics.DrawLine(blackPen, 0, y * 50, 6 * 50, y * 50);
            }

            for (int x = 0; x <= 6; ++x)
            {
                e.Graphics.DrawLine(blackPen, x * 50, 0, x * 50, 6 * 50);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
