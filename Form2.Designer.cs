namespace rpg
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemTemplate = new Microsoft.VisualBasic.PowerPacks.DataRepeaterItem();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainLabel = new System.Windows.Forms.Label();
            this.restLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.fightLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.mpLabel = new System.Windows.Forms.Label();
            this.ryanhLabel = new System.Windows.Forms.Label();
            this.mattLabel = new System.Windows.Forms.Label();
            this.aungLabel = new System.Windows.Forms.Label();
            this.ryanh_hpLabel = new System.Windows.Forms.Label();
            this.matt_hpLabel = new System.Windows.Forms.Label();
            this.aung_hpLabel = new System.Windows.Forms.Label();
            this.ryanh_mpLabel = new System.Windows.Forms.Label();
            this.matt_mpLabel = new System.Windows.Forms.Label();
            this.aung_mpLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemTemplate
            // 
            this.ItemTemplate.ForeColor = System.Drawing.Color.White;
            this.ItemTemplate.Size = new System.Drawing.Size(684, 226);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(692, 470);
            this.shapeContainer1.TabIndex = 56;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.BorderWidth = 3;
            this.rectangleShape2.Location = new System.Drawing.Point(258, 164);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(103, 138);
            this.rectangleShape2.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(258, 20);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(425, 114);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 442);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(692, 28);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // trainLabel
            // 
            this.trainLabel.AutoSize = true;
            this.trainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainLabel.Location = new System.Drawing.Point(284, 206);
            this.trainLabel.Name = "trainLabel";
            this.trainLabel.Size = new System.Drawing.Size(66, 25);
            this.trainLabel.TabIndex = 59;
            this.trainLabel.Text = "Train";
            this.trainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trainLabel.MouseEnter += new System.EventHandler(this.train_mouseEnter);
            // 
            // restLabel
            // 
            this.restLabel.AutoSize = true;
            this.restLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restLabel.Location = new System.Drawing.Point(284, 267);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(60, 25);
            this.restLabel.TabIndex = 62;
            this.restLabel.Text = "Rest";
            this.restLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restLabel.Click += new System.EventHandler(this.restButton_Click);
            this.restLabel.MouseEnter += new System.EventHandler(this.rest_mouseEnter);
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.Location = new System.Drawing.Point(284, 237);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(66, 25);
            this.shopLabel.TabIndex = 63;
            this.shopLabel.Text = "Shop";
            this.shopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shopLabel.Click += new System.EventHandler(this.shopButton_Click);
            this.shopLabel.MouseEnter += new System.EventHandler(this.shop_mouseEnter);
            // 
            // fightLabel
            // 
            this.fightLabel.AutoSize = true;
            this.fightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fightLabel.Location = new System.Drawing.Point(284, 176);
            this.fightLabel.Name = "fightLabel";
            this.fightLabel.Size = new System.Drawing.Size(65, 25);
            this.fightLabel.TabIndex = 58;
            this.fightLabel.Text = "Fight";
            this.fightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fightLabel.Click += new System.EventHandler(this.fightButton_Click);
            this.fightLabel.MouseEnter += new System.EventHandler(this.fight_mouseEnter);
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(446, 30);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(43, 25);
            this.hpLabel.TabIndex = 64;
            this.hpLabel.Text = "HP";
            // 
            // mpLabel
            // 
            this.mpLabel.AutoSize = true;
            this.mpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpLabel.Location = new System.Drawing.Point(485, 30);
            this.mpLabel.Name = "mpLabel";
            this.mpLabel.Size = new System.Drawing.Size(46, 25);
            this.mpLabel.TabIndex = 65;
            this.mpLabel.Text = "MP";
            // 
            // ryanhLabel
            // 
            this.ryanhLabel.AutoSize = true;
            this.ryanhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ryanhLabel.Location = new System.Drawing.Point(306, 53);
            this.ryanhLabel.Name = "ryanhLabel";
            this.ryanhLabel.Size = new System.Drawing.Size(79, 25);
            this.ryanhLabel.TabIndex = 66;
            this.ryanhLabel.Text = "Ryanh";
            // 
            // mattLabel
            // 
            this.mattLabel.AutoSize = true;
            this.mattLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mattLabel.Location = new System.Drawing.Point(306, 73);
            this.mattLabel.Name = "mattLabel";
            this.mattLabel.Size = new System.Drawing.Size(58, 25);
            this.mattLabel.TabIndex = 67;
            this.mattLabel.Text = "Matt";
            // 
            // aungLabel
            // 
            this.aungLabel.AutoSize = true;
            this.aungLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aungLabel.Location = new System.Drawing.Point(306, 93);
            this.aungLabel.Name = "aungLabel";
            this.aungLabel.Size = new System.Drawing.Size(66, 25);
            this.aungLabel.TabIndex = 68;
            this.aungLabel.Text = "Aung";
            // 
            // ryanh_hpLabel
            // 
            this.ryanh_hpLabel.AutoSize = true;
            this.ryanh_hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ryanh_hpLabel.Location = new System.Drawing.Point(419, 53);
            this.ryanh_hpLabel.Name = "ryanh_hpLabel";
            this.ryanh_hpLabel.Size = new System.Drawing.Size(51, 25);
            this.ryanh_hpLabel.TabIndex = 69;
            this.ryanh_hpLabel.Text = "100";
            // 
            // matt_hpLabel
            // 
            this.matt_hpLabel.AutoSize = true;
            this.matt_hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matt_hpLabel.Location = new System.Drawing.Point(419, 73);
            this.matt_hpLabel.Name = "matt_hpLabel";
            this.matt_hpLabel.Size = new System.Drawing.Size(51, 25);
            this.matt_hpLabel.TabIndex = 70;
            this.matt_hpLabel.Text = "100";
            // 
            // aung_hpLabel
            // 
            this.aung_hpLabel.AutoSize = true;
            this.aung_hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aung_hpLabel.Location = new System.Drawing.Point(419, 93);
            this.aung_hpLabel.Name = "aung_hpLabel";
            this.aung_hpLabel.Size = new System.Drawing.Size(51, 25);
            this.aung_hpLabel.TabIndex = 71;
            this.aung_hpLabel.Text = "100";
            // 
            // ryanh_mpLabel
            // 
            this.ryanh_mpLabel.AutoSize = true;
            this.ryanh_mpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ryanh_mpLabel.Location = new System.Drawing.Point(485, 50);
            this.ryanh_mpLabel.Name = "ryanh_mpLabel";
            this.ryanh_mpLabel.Size = new System.Drawing.Size(51, 25);
            this.ryanh_mpLabel.TabIndex = 72;
            this.ryanh_mpLabel.Text = "100";
            // 
            // matt_mpLabel
            // 
            this.matt_mpLabel.AutoSize = true;
            this.matt_mpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matt_mpLabel.Location = new System.Drawing.Point(485, 70);
            this.matt_mpLabel.Name = "matt_mpLabel";
            this.matt_mpLabel.Size = new System.Drawing.Size(51, 25);
            this.matt_mpLabel.TabIndex = 73;
            this.matt_mpLabel.Text = "100";
            // 
            // aung_mpLabel
            // 
            this.aung_mpLabel.AutoSize = true;
            this.aung_mpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aung_mpLabel.Location = new System.Drawing.Point(485, 93);
            this.aung_mpLabel.Name = "aung_mpLabel";
            this.aung_mpLabel.Size = new System.Drawing.Size(51, 25);
            this.aung_mpLabel.TabIndex = 74;
            this.aung_mpLabel.Text = "100";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(692, 470);
            this.Controls.Add(this.aung_mpLabel);
            this.Controls.Add(this.matt_mpLabel);
            this.Controls.Add(this.ryanh_mpLabel);
            this.Controls.Add(this.aung_hpLabel);
            this.Controls.Add(this.matt_hpLabel);
            this.Controls.Add(this.ryanh_hpLabel);
            this.Controls.Add(this.aungLabel);
            this.Controls.Add(this.mattLabel);
            this.Controls.Add(this.ryanhLabel);
            this.Controls.Add(this.fightLabel);
            this.Controls.Add(this.mpLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.trainLabel);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.restLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "RPG(form2)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.DataRepeaterItem ItemTemplate;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label trainLabel;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label restLabel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label fightLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label mpLabel;
        private System.Windows.Forms.Label ryanhLabel;
        private System.Windows.Forms.Label mattLabel;
        private System.Windows.Forms.Label aungLabel;
        private System.Windows.Forms.Label ryanh_hpLabel;
        private System.Windows.Forms.Label matt_hpLabel;
        private System.Windows.Forms.Label aung_hpLabel;
        private System.Windows.Forms.Label ryanh_mpLabel;
        private System.Windows.Forms.Label matt_mpLabel;
        private System.Windows.Forms.Label aung_mpLabel;



    }
}