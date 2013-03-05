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
        int[,] enemy = new int[4, 4];
        int groupLvl = Objects.ryanhStats[5] + Objects.mattStats[5] + Objects.aungStats[5],
            spot = 0, slimeCounter = 0, thiefCounter = 0;
        
        // enemy, atk, hp, mp
        int[] slime = new int[4] { 1, 15, 80, 1 },
              thief = { 2, 20, 120, 5 },
              shala = { 3, 30, 200, 8 }, 
              dragon = { 4, 50, 300, 8};
     
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
            for (int x = 0; x < 4; x++)
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

        void updateStatus()
        {
            label1.Text = Objects.ryanhStats[3].ToString();
            label2.Text = Objects.ryanhStats[4].ToString();
            label3.Text = Objects.mattStats[3].ToString();
            label4.Text = Objects.mattStats[4].ToString();
            label5.Text = Objects.aungStats[3].ToString();
            label6.Text = Objects.aungStats[4].ToString();
        }




    }  
}
