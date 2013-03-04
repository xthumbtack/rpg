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
        int groupLvl = Objects.ryanhStats[5] + Objects.mattStats[5] + Objects.aungStats[5];
        
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
            for (int x = 0; x < 3; x++)
            {
                switch (enemy[x,0])
                {
                    case 0:
                        for (int y = 1; y < 3; y++)
                        {
                            enemy[0, y] = slime[y];
                        }
                        break;
                    case 1:
                        for (int y = 1; y < 3; y++)
                        {
                            enemy[1, y] = thief[y];
                        }

                        break;

                    case 2:
                        for (int y = 1; y < 3; y++)
                        {
                            enemy[2, y] = shala[y];
                        }
                        break;

                    case 3:
                        for (int y = 1; y < 3; y++)
                        {
                            enemy[3, y] = dragon[y];
                        }
                        break;
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



        public void ryanhHP_change(object sender, EventArgs e)
        {
            label1.Text = Objects.ryanhStats[3].ToString();
            label1.Refresh();

        }

        private void ryanhMP_change(object sender, EventArgs e)
        {
            label2.Text = Objects.ryanhStats[4].ToString();
        }

        private void mattHP_change(object sender, EventArgs e)
        {
            label3.Text = Objects.mattStats[3].ToString();
        }

        private void mattMP_change(object sender, EventArgs e)
        {
            label4.Text = Objects.mattStats[4].ToString();
        }

        private void aungHP_change(object sender, EventArgs e)
        {
            label5.Text = Objects.aungStats[3].ToString();
        }

        private void aungMP_change(object sender, EventArgs e)
        {
            label6.Text = Objects.aungStats[4].ToString();
        }


        private void battle_Load(object sender, EventArgs e)
        {

        }
    }  
}
