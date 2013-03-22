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
    public partial class battle : Form
    {
        // battle objects
        int[,] enemy = new int[3, 4] {{0,0,1,0}, {0,0,1,0}, {0,0,1,0}};
        int groupLvl = Objects.ryanhStats[5] + Objects.mattStats[5] + Objects.aungStats[5],
            spot = 0,
            slimeCounter = 0, thiefCounter = 0,
            battleTurn = 2, playerQueue = 1,
            deathCounterRyanh = 0, deathCounterMatt = 0, deathCounterAung = 0;
        bool ryanhMove = false, mattMove = false, aungMove = false,
             enemy1Dead = false, enemy2Dead = false, enemy3Dead = false,
             attack = false, magic = false, item = false;

        
        // enemy, atk, hp, mp
        int[] slime = new int[4] { 1, 15, 80, 1 },
              thief = { 2, 25, 120, 5 },
              cacti = { 3, 50, 200, 8},
              shala = { 4, 90, 300, 8 }, 
              dragon = { 5, 100, 450, 8};
     
        public battle()
        {
            InitializeComponent();
            updateStatus();

            groupLvl /= 3;
            load_enemy();
        }

        public void load_enemy()
        {
            // determine which enemies will spawn
            if (groupLvl <= 5)
            {
                Random rdm_enemy = new Random();
                Random rdm_enemyNum = new Random();
                int enemyNum = rdm_enemyNum.Next(1, 4);

                enemy[0,0] = rdm_enemy.Next(0, 2);
                enemy[1,0] = rdm_enemy.Next(0, 2);
                enemy[2,0] = rdm_enemy.Next(0, 2);
            }
            spawnEnemy();
        }

        void spawnEnemy()
        {
            for (int x = 0; x < 3; x++)
            {
                switch (enemy[x,0])
                {
                    case 0:
                        for (int y = 1; y < 4; y++)
                        {
                            enemy[x, y] = slime[y];
                        }
                        enemySlime();
                        break;
                    case 1:
                        for (int y = 1; y < 4; y++)
                        {
                            enemy[x, y] = thief[y];
                        }
                        enemyThief();
                        break;

                    case 2:
                        for (int y = 1; y < 4; y++)
                        {
                            enemy[x, y] = shala[y];
                        }
                        break;

                    case 3:
                        for (int y = 1; y < 4; y++)
                        {
                            enemy[x, y] = dragon[y];
                        }
                        break;
                }
            }
            playerTurn();

        }

        void enemySlime()
        {
            spot++;
            if (spot < 4)
            {
                slimeCounter++;
                if (spot == 1)
                {

                    Image image1 = Image.FromFile("C:\\Users\\Ryanh\\Documents\\GitHub\\rpg\\Resources\\slime.jpg");
                    pictureBox1.BackgroundImage = image1;
                    spot1Label.Text = "Slime 1";
                }
                if (spot == 2)
                {
                    Image image2 = Image.FromFile("C:\\Users\\Ryanh\\Documents\\GitHub\\rpg\\Resources\\slime.jpg");
                    pictureBox2.BackgroundImage = image2;
                    if (slimeCounter > 1) spot2Label.Text = "Slime 2";
                    else if (slimeCounter == 1) spot2Label.Text = "Slime 1"; 
                }
                if (spot == 3)
                {
                    Image image3 = Image.FromFile("C:\\Users\\Ryanh\\Documents\\GitHub\\rpg\\Resources\\slime.jpg");
                    pictureBox3.BackgroundImage = image3;
                    spot3Label.Text = "Slime 1";
                    if (slimeCounter > 1)
                    {
                        spot3Label.Text = "Slime 2";
                        if (slimeCounter > 2)
                        {
                            spot3Label.Text = "Slime 3";
                        }
                    }
                    else if ( slimeCounter == 1) spot3Label.Text = "Slime 1";
                } 
            }
        }

        void enemyThief()
        {
            spot++;
            if (spot < 4)
            {
                thiefCounter++;
                if (spot == 1)
                {
                    Image image1 = Image.FromFile("C:\\Users\\Ryanh\\Documents\\GitHub\\rpg\\Resources\\thief.jpg");
                    pictureBox1.BackgroundImage = image1;
                    spot1Label.Text = "Thief 1";
                }
                if (spot == 2)
                {
                    Image image2 = Image.FromFile("C:\\Users\\Ryanh\\Documents\\GitHub\\rpg\\Resources\\thief.jpg");
                    pictureBox2.BackgroundImage = image2;
                    if (thiefCounter == 2) spot2Label.Text = "Thief 2";
                    else if (thiefCounter == 1) spot1Label.Text = "Thief 1";
                }
                else if (spot == 3)
                {
                    Image image3 = Image.FromFile("C:\\Users\\Ryanh\\Documents\\GitHub\\rpg\\Resources\\thief.jpg");
                    pictureBox3.BackgroundImage = image3;
                    spot3Label.Text = "Thief 1";
                    if (thiefCounter == 2) spot3Label.Text = "Thief 2";
                    else if (thiefCounter == 3) spot3Label.Text = "Thief 3";
                } 
            }
        }

        void playerTurn()
        {
            updateStatus(); //check who is alive and able to move
            while ((enemy1Dead == false) || (enemy2Dead == false) || (enemy3Dead == false))
            {
                ryanhTurn();
                mattTurn();
                aungTurn();
                enemyTurn();
            }
        }

        bool ryanhTurn()
        {
            updateStatus();
            while (ryanhMove == false)
            {
                MessageBox.Show("Ryanh's turn to fight!");
                playerQueue = 1;
                this.ShowDialog();
                
            }
            return ryanhMove;
        }

        bool mattTurn()
        {
            updateStatus();
            while (mattMove == false)
            {
                playerQueue = 2;
                //this.ShowDialog();
            }
            return mattMove;
        }

        bool aungTurn()
        {
            updateStatus();
            return aungMove;
        }


        int enemyTurn()
        {
            updateStatus();
            if (enemy1Dead == false) 
            {
                enemy[0, 1] = 0;
            }
            if (enemy2Dead == false)
            {
            }
            if (enemy3Dead == false)
            {
            }


            return battleTurn;
        }

        void updateStatus()
        {          
            label1.Text = Objects.ryanhStats[3].ToString();
            label2.Text = Objects.ryanhStats[4].ToString();
            label3.Text = Objects.mattStats[3].ToString();
            label4.Text = Objects.mattStats[4].ToString();
            label5.Text = Objects.aungStats[3].ToString();
            label6.Text = Objects.aungStats[4].ToString();

            if (Objects.ryanhStats[4] < 1)
            {
                ryanhMove = true;
                deathCounterRyanh++;
                if (deathCounterRyanh < 1) MessageBox.Show("Ryanh has fallen!");
                if (playerQueue == 1) playerQueue = 2;
            }
            if (Objects.mattStats[4] < 1)
            {
                mattMove = true;
                deathCounterMatt++;
                if (deathCounterMatt < 1) MessageBox.Show("Matt has fallen!");
                if (playerQueue == 2) playerQueue = 3;
            }
            if (Objects.aungStats[4] < 1)
            {
                aungMove = true;
                deathCounterAung++;
                if (deathCounterAung < 1) MessageBox.Show("Ryanh has fallen!");
                if ((deathCounterRyanh > 1) & (deathCounterMatt > 1) & (deathCounterAung > 1)) gameOver();
            }

            if (enemy[0, 2] < 1)
            {
                MessageBox.Show(spot1Label.Text + " has been slain!");
                enemy1Dead = true;
            }
            if (enemy[1, 2] < 1)
            {
                MessageBox.Show(spot2Label.Text + " has been slain!");
                enemy2Dead = true;
            }
            if (enemy[2, 2] < 1)
            {
                MessageBox.Show(spot3Label.Text + " has been slain!");
                enemy3Dead = true;
            }
        }


        void gameOver()
        {
            MessageBox.Show("Our heroes have been slain! Game Over.");
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((playerQueue == 1) & (ryanhMove == false) & attack == true)
            {
                enemy[0, 2] -= Objects.ryanhBattle[0];
                ryanhMove = true;
                attack = false;
                playerTurn();
            }
            if (playerQueue == 2) mattMove = true;
        }

        private void spot1Label_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void spot2Label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void spot3Label_Click(object sender, EventArgs e)
        {

        }

        private void attackLabel_Click(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\ok.wav";
            attack = true;
        }

        private void magicLabel_Click(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\ok.wav";
        }

        private void itemLabel_Click(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Ryanh\Documents\GitHub\rpg\Resources\ok.wav";
        }
    }  
}
