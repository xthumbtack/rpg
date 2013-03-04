using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rpg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            stats();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        void stats()
        {
            ryanh_hpLabel.Text = Objects.ryanhStats[3].ToString();
            ryanh_mpLabel.Text = Objects.ryanhStats[4].ToString();
            matt_hpLabel.Text = Objects.mattStats[3].ToString();
            matt_mpLabel.Text = Objects.mattStats[4].ToString();
            aung_hpLabel.Text = Objects.aungStats[3].ToString();
            aung_mpLabel.Text = Objects.aungStats[4].ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit the game?";
            string caption = "Exit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form. 

                this.Close();

            }
        }
        private void fightButton_Click(object sender, EventArgs e)
        {
            // hide main form
            this.Hide();

            // show other form
            battle fight = new battle();
            fight.ShowDialog();

            // close application
            this.Close();
        }
        private void trainButton_Click(object sender, EventArgs e)
        {
        }


        private void restButton_Click(object sender, EventArgs e)
        {

        }

        private void shopButton_Click(object sender, EventArgs e)
        {

        }

    }
}
