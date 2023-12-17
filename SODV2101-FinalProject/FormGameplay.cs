using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SODV2101_FinalProject
{
    public partial class FormGameplay : Form
    {
        public static int ShipBody2X { get; set; }
        public static int ShipBody2Y { get; set; }



        // Add a field for the projectile (bullet)
        private Projectile bullet;

        public FormGameplay()
        {
            InitializeComponent();
        }

        public abstract class Ship
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

            public void Shoot(Graphics graphics, int x, int y)
            {
                int circleDiameter = 20; // Set the diameter of the circle

                // Ensure that the coordinates are within the valid range
                if (x < 0 || y < 0 || x + circleDiameter > graphics.VisibleClipBounds.Width || y + circleDiameter > graphics.VisibleClipBounds.Height)
                {
                    // Log or handle invalid coordinates
                    Console.WriteLine($"Invalid coordinates - x: {x}, y: {y}");
                    return;
                }

                // Log the valid coordinates before drawing
                Console.WriteLine($"DrawCircle - x: {x}, y: {y}");

                // Draw the blue circle
                graphics.FillEllipse(Brushes.Blue, x, y, circleDiameter, circleDiameter);
            }
        }

        public class Projectile
        {
            public Point Location { get; set; }
            public int Speed { get; set; }

            public Projectile(int x, int y, int speed)
            {
                Location = new Point(x, y);
                Speed = speed;
            }

            public void Move()
            {
                // Update the Location to move from left to right
                Location = new Point(Location.X + Speed, Location.Y);
            }

            public void Draw(Graphics graphics)
            {
                int diameter = 10; // Set the diameter of the projectile
                graphics.FillEllipse(Brushes.Yellow, Location.X - diameter / 2, Location.Y - diameter / 2, diameter, diameter);
            }
        }


        public class Player : Ship
        {
            public Player(Point center)
            {
                Center = center;
                ShipBody2X = Center.X; // Initialize the x-coordinate
                ShipBody2Y = Center.Y + 15; // Initialize the y-coordinate
            }

            public override void Draw(PaintEventArgs e)
            {
                Pen pen = new Pen(Color.Blue, 2);
                Graphics g = e.Graphics;

                Point[] ShipBody = new Point[3];
                ShipBody[0] = new Point(Center.X, Center.Y - 15);
                ShipBody[1] = new Point(Center.X + 25, Center.Y);
                ShipBody[2] = new Point(Center.X, Center.Y + 15);

                e.Graphics.DrawPolygon(pen, ShipBody);
            }

            public void MoveAndDrawCircle(Graphics graphics, int distance)
            {
                for (int i = 0; i < distance; i += 5)
                {
                    DrawCircle(graphics, MoveX + i, MoveY);
                    Move(0, 800, 0, 600); // Adjust the bounds as needed
                    System.Threading.Thread.Sleep(100); // Optional: Add a delay for visualization
                    Application.DoEvents(); // Allow the application to process events
                }
            }

            private void DrawCircle(Graphics graphics, int x, int y)
            {
                // Modify this to fit your circle drawing logic
                graphics.FillEllipse(Brushes.Blue, x, y, 20, 20);
            }
        }

        public class Enemy : Ship
        {
            public Enemy(Point center)
            {
                Center = center;
            }

            public override void Draw(PaintEventArgs e)
            {
                Pen pen = new Pen(Color.Red, 2);
                Graphics g = e.Graphics;

                Point[] ShipBody = new Point[3];
                ShipBody[0] = new Point(Center.X, Center.Y - 15);
                ShipBody[1] = new Point(Center.X - 25, Center.Y);
                ShipBody[2] = new Point(Center.X, Center.Y + 15);

                e.Graphics.DrawPolygon(pen, ShipBody);

                Console.WriteLine($"ShipBody2X: {ShipBody2X}, ShipBody2Y: {ShipBody2Y}");
            }

            public void TrackPlayer(int playerX, int playerY)
            {
                //go towards the player's coordinates in 3-pixel increments
                if (playerX > Center.X)
                {
                    Center = new Point(Center.X + 3, Center.Y);
                }

                if (playerX < Center.X)
                {
                    Center = new Point(Center.X - 3, Center.Y);
                }

                if (playerY > Center.Y)
                {
                    Center = new Point(Center.X, Center.Y + 3);
                }

                if (playerY < Center.Y)
                {
                    Center = new Point(Center.X, Center.Y - 3);
                }
            }
        }

        //starting position for player
        Player p = new Player(new Point(155, 460));

        //enemy position
        Enemy enemy = new Enemy(new Point(700, 400));

        private void Gameplayloop_Load(object sender, EventArgs e)
        {
            GameTick.Interval = 45;
            GameTick.Start();

            this.Size = new Size(1200, 900);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.BackColor = Color.Black;
            this.Paint += new PaintEventHandler(this.PaintObject);

            // Initialize the bullet
            bullet = new Projectile(ShipBody2X, ShipBody2Y, 10);
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

            enemy.Draw(e);
            p.Draw(e);

            if (bullet != null)
            {
                bullet.Draw(e.Graphics);
            }

            e.Graphics.ResetClip();
        }

        private void Gameplayloop_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Reset player movement
            p.MoveX = 0;
            p.MoveY = 0;

            // Set player movement based on the key pressed
            if (e.KeyCode == Keys.Left)
            {
                p.MoveX = -5;
                enemy.TrackPlayer(ShipBody2X, ShipBody2Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                p.MoveX = 5;
                enemy.TrackPlayer(ShipBody2X, ShipBody2Y);
            }
            else if (e.KeyCode == Keys.Up)
            {
                p.MoveY = -5;
                enemy.TrackPlayer(ShipBody2X, ShipBody2Y);
            }
            else if (e.KeyCode == Keys.Down)
            {
                p.MoveY = 5;
                enemy.TrackPlayer(ShipBody2X, ShipBody2Y);
            }
            else if (e.KeyCode == Keys.Space) // this is the shooting mechanic
            {
                // Set the initial position of the bullet to the player's location
                Projectile newBullet = new Projectile(ShipBody2X, ShipBody2Y, 10);

                // Assign the new projectile to the existing bullet variable
                bullet = newBullet;
            }
        }


        private void Gameplayloop_KeyUp(object sender, KeyEventArgs e)
        {
            p.MoveX = 0;
            p.MoveY = 0;
        }

        private void GameTick_Tick(object sender, EventArgs e)
        {
            p.Move(100, 1000, 100, 900);

            Console.WriteLine($"ShipBody2X: {ShipBody2X}, ShipBody2Y: {ShipBody2Y}");

            // Move the bullet from left to right when space is pressed
            if (bullet != null)
            {
                bullet.Move();

                // Check if the bullet is out of bounds
                if (bullet.Location.X > this.ClientSize.Width)
                {
                    // Set the bullet to null to indicate it's not visible
                    bullet = null;
                }
            }

            this.Refresh();
        }

    }
}