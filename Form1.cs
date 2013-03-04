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


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\04.wav");
            player.Play(); 
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            // hide main form
            this.Hide();

            // show other form
            Form2 form2 = new Form2();
            form2.ShowDialog();

            // close application
            this.Close();
        }

    }
}
