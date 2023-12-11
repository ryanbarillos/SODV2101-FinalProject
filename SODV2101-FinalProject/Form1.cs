/*
 * SODV2101 Final Project
 * By Ryan Barillos, Nathaniel Gatus, Emmanuel Pagaduan
 * 
 * Date Started: 20 Nov 2023
 * Day Finished: 01 Dec 2023
 */
namespace SODV2101_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Gameplayloop gameplayloop = new Gameplayloop();
            gameplayloop.Show();
        }

        private void Controlbtn_Click(object sender, EventArgs e)
        {
            Controls controls = new Controls();

            controls.Show();
        }
    }
}
