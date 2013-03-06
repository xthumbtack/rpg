using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace rpg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            playMusic();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\04.wav";
        }

        void playMusic()
        {
            
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\ok.wav";
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\ok.wav";
            // hide main form
            this.Hide();

            // show other form
            Form2 form2 = new Form2();
            form2.ShowDialog();

            // close application
            this.Close();
        }

        private void start_mouseEnter(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\menumove.wav";
        }

        private void exit_mouseEnter(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\menumove.wav";
        }

    }
}
