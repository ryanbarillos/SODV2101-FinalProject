using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SODV2101_FinalProject.Gameplayloop;

namespace SODV2101_FinalProject
{
    public partial class Gameplayloop : Form
    {
        public Gameplayloop()
        {
            InitializeComponent();
        }

        //this is basically the same with the code from the ateriod gla
        public abstract class Asset
        {
            public Point Center { get; set; }
            public Rectangle Rectangle { get; set; }

            public int MoveX { get; set; } = 0;
            public int MoveY { get; set; } = 0;

            public abstract void Draw(PaintEventArgs e);
            public virtual void Move(int X1, int X2, int Y1, int Y2)
            {
                int newX = Center.X + MoveX;
                if (newX < X1) newX = X2;
                else if (newX > X2) newX = X1;

                int newY = Center.Y + MoveY;
                if (newY < Y1) newY = Y2;
                else if (newY > Y2) newY = Y1;

                Center = new Point(newX, newY);
            }

        }

        //this is the ship that the player will control
        public class Player : Asset
        {
            public Player(Point center)
            {
                Center = center;
            }
            public override void Draw(PaintEventArgs e)
            {
                Pen pen = new Pen(Color.White, 2);
                Graphics g = e.Graphics;

                Point[] ShipBody = new Point[3];
                ShipBody[0] = new Point(Center.X -15, Center.Y);
                ShipBody[1] = new Point(Center.X, Center.Y -15);
                ShipBody[2] = new Point(Center.X +15, Center.Y);

                e.Graphics.DrawPolygon(pen, ShipBody);



            }
        }
        //starting position for player
        Player Ship = new Player(new Point(555, 760));



        private void Gameplayloop_Load(object sender, EventArgs e)
        {
            GameTick.Interval = 45;
            GameTick.Start();

            this.Size = new Size(1200, 900);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.BackColor = Color.Black;
            this.Paint += new PaintEventHandler(this.PaintObject);
        }

        private void PaintObject(object sender, PaintEventArgs e)
        {
            //GameDisplay == the Player view of the game
            int marginX = 50;
            int marginY = 50;
            int gameDisplayWidth = this.ClientSize.Width - 2 * marginX;
            int gameDisplayHeight = this.ClientSize.Height - 2 * marginY;

            Rectangle GameDisplay = new Rectangle(marginX, marginY, gameDisplayWidth, gameDisplayHeight);
            e.Graphics.DrawRectangle(Pens.White, GameDisplay);

            Region clippingRegion = new Region(GameDisplay);
            e.Graphics.Clip = clippingRegion;


            Ship.Draw(e);



            e.Graphics.ResetClip();
        }

        private void Gameplayloop_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Ship.MoveX = -5;
            }
            if (e.KeyCode == Keys.Right)
            {
                Ship.MoveX = 5;
            }
            if (e.KeyCode == Keys.Up)
            {
                Ship.MoveY = -5;
            }
            if (e.KeyCode == Keys.Down)
            {
                Ship.MoveY = 5;
            }
        }

        private void Gameplayloop_KeyUp(object sender, KeyEventArgs e)
        {
            Ship.MoveX = 0;
            Ship.MoveY = 0;
        }
        private void GameTick_Tick(object sender, EventArgs e)
        {
            //the display range for player movement
            //x y top left x y bottom right
            Ship.Move(100, 1000, 500, 700);
            this.Refresh();
        }
    }
}
