using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SODV2101_FinalProject
{
    public partial class Form1 : Form
{
    private Ship myShip = new Ship();

    public Form1()
    {
        InitializeComponent();

        this.Paint += Form1_Paint;
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        // Draw the ship using the Ship class
        myShip.DrawShip(e.Graphics);
    }

    public class Ship
    {
        private int x = 100;
        private int y = 100;

        public void MoveLeft()
        {
            x -= 10;
        }

        public void MoveRight()
        {
            x += 10;
        }

        public void MoveUp()
        {
            y -= 10;
        }

        public void MoveDown()
        {
            y += 10;
        }

        public void DrawShip(Graphics g)
        {
            // Draw the triangle on the PictureBox
            // Adjust the coordinates to make the point of the triangle point to the right
            Point[] points = { new Point(x, y), new Point(x, y - 20), new Point(x + 20, y - 10) };

            g.FillPolygon(Brushes.Blue, points);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
}
