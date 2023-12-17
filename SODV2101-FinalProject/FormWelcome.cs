/*
 * SODV2101 Final Project
 * By Ryan Barillos, Nathaniel Gatus, Emmanuel Pagaduan
 * 
 * Date Started: 20 Nov 2023
 * Day Finished: 01 Dec 2023
 */
namespace SODV2101_FinalProject
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }
        private void Startbtn_Click(object sender, EventArgs e)
        {
            var gameplayloop = new FormGameplay();
            gameplayloop.Show();
        }

        private void Controlbtn_Click(object sender, EventArgs e)
        {
            var controls = new FormControls();
            controls.Show();
        }
    }
}
