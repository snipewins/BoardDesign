namespace BoardGame
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.gbBG = new System.Windows.Forms.GroupBox();
            this.btnDeleteTile = new System.Windows.Forms.Button();
            this.btnColorBG = new System.Windows.Forms.Button();
            this.btnImageBG = new System.Windows.Forms.Button();
            this.gbToolbox = new System.Windows.Forms.GroupBox();
            this.gbArrows = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.gbPawns = new System.Windows.Forms.GroupBox();
            this.btnImagePawn = new System.Windows.Forms.Button();
            this.btnColorPawn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTiles = new System.Windows.Forms.GroupBox();
            this.cbAllTiles = new System.Windows.Forms.CheckBox();
            this.btnImageTile = new System.Windows.Forms.Button();
            this.btnColorTile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbInitialInfo = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbStartX = new System.Windows.Forms.TextBox();
            this.tbStartY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTileWidth = new System.Windows.Forms.TextBox();
            this.tbTileHeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFormWidth = new System.Windows.Forms.TextBox();
            this.tbFormHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.gbBG.SuspendLayout();
            this.gbToolbox.SuspendLayout();
            this.gbArrows.SuspendLayout();
            this.gbPawns.SuspendLayout();
            this.gbTiles.SuspendLayout();
            this.gbInitialInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(38, 9);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(26, 20);
            this.tbHeight.TabIndex = 2;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(38, 36);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(26, 20);
            this.tbWidth.TabIndex = 3;
            // 
            // gbBG
            // 
            this.gbBG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbBG.Controls.Add(this.btnColorBG);
            this.gbBG.Controls.Add(this.btnImageBG);
            this.gbBG.Controls.Add(this.tbWidth);
            this.gbBG.Controls.Add(this.tbHeight);
            this.gbBG.Controls.Add(this.label2);
            this.gbBG.Controls.Add(this.label1);
            this.gbBG.Location = new System.Drawing.Point(1, 0);
            this.gbBG.Name = "gbBG";
            this.gbBG.Padding = new System.Windows.Forms.Padding(0);
            this.gbBG.Size = new System.Drawing.Size(124, 88);
            this.gbBG.TabIndex = 5;
            this.gbBG.TabStop = false;
            // 
            // btnDeleteTile
            // 
            this.btnDeleteTile.Location = new System.Drawing.Point(59, 61);
            this.btnDeleteTile.Name = "btnDeleteTile";
            this.btnDeleteTile.Size = new System.Drawing.Size(58, 23);
            this.btnDeleteTile.TabIndex = 7;
            this.btnDeleteTile.Text = "Delete";
            this.btnDeleteTile.UseVisualStyleBackColor = true;
            this.btnDeleteTile.Click += new System.EventHandler(this.btnDeleteTile_Click);
            // 
            // btnColorBG
            // 
            this.btnColorBG.Location = new System.Drawing.Point(70, 10);
            this.btnColorBG.Name = "btnColorBG";
            this.btnColorBG.Size = new System.Drawing.Size(44, 23);
            this.btnColorBG.TabIndex = 6;
            this.btnColorBG.Text = "Color";
            this.btnColorBG.UseVisualStyleBackColor = true;
            this.btnColorBG.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnImageBG
            // 
            this.btnImageBG.Location = new System.Drawing.Point(70, 35);
            this.btnImageBG.Name = "btnImageBG";
            this.btnImageBG.Size = new System.Drawing.Size(44, 23);
            this.btnImageBG.TabIndex = 5;
            this.btnImageBG.Text = "Image";
            this.btnImageBG.UseVisualStyleBackColor = true;
            this.btnImageBG.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // gbToolbox
            // 
            this.gbToolbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbToolbox.BackColor = System.Drawing.SystemColors.Control;
            this.gbToolbox.Controls.Add(this.gbArrows);
            this.gbToolbox.Controls.Add(this.gbPawns);
            this.gbToolbox.Controls.Add(this.gbTiles);
            this.gbToolbox.Controls.Add(this.gbBG);
            this.gbToolbox.Enabled = false;
            this.gbToolbox.Location = new System.Drawing.Point(0, 0);
            this.gbToolbox.Name = "gbToolbox";
            this.gbToolbox.Size = new System.Drawing.Size(457, 88);
            this.gbToolbox.TabIndex = 6;
            this.gbToolbox.TabStop = false;
            // 
            // gbArrows
            // 
            this.gbArrows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbArrows.Controls.Add(this.btnDown);
            this.gbArrows.Controls.Add(this.btnPlace);
            this.gbArrows.Controls.Add(this.btnRight);
            this.gbArrows.Controls.Add(this.btnLeft);
            this.gbArrows.Controls.Add(this.btnUp);
            this.gbArrows.Location = new System.Drawing.Point(373, 0);
            this.gbArrows.Name = "gbArrows";
            this.gbArrows.Padding = new System.Windows.Forms.Padding(0);
            this.gbArrows.Size = new System.Drawing.Size(80, 88);
            this.gbArrows.TabIndex = 7;
            this.gbArrows.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
//            this.btnDown.BackgroundImage = global::BoardGame.Properties.Resources.Down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(28, 57);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 28);
            this.btnDown.TabIndex = 13;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.BackColor = System.Drawing.Color.Transparent;
//          this.btnPlace.BackgroundImage = global::BoardGame.Properties.Resources.Place;
            this.btnPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlace.Location = new System.Drawing.Point(28, 34);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(24, 24);
            this.btnPlace.TabIndex = 11;
            this.btnPlace.UseVisualStyleBackColor = false;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
//            this.btnRight.BackgroundImage = global::BoardGame.Properties.Resources.Right;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(51, 34);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(28, 24);
            this.btnRight.TabIndex = 12;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
//            this.btnLeft.BackgroundImage = global::BoardGame.Properties.Resources.Left;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(1, 34);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(28, 24);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
 //           this.btnUp.BackgroundImage = global::BoardGame.Properties.Resources.Up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(28, 7);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 28);
            this.btnUp.TabIndex = 11;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // gbPawns
            // 
            this.gbPawns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPawns.Controls.Add(this.btnImagePawn);
            this.gbPawns.Controls.Add(this.btnColorPawn);
            this.gbPawns.Controls.Add(this.textBox3);
            this.gbPawns.Controls.Add(this.textBox4);
            this.gbPawns.Controls.Add(this.label5);
            this.gbPawns.Controls.Add(this.label6);
            this.gbPawns.Enabled = false;
            this.gbPawns.Location = new System.Drawing.Point(247, 0);
            this.gbPawns.Name = "gbPawns";
            this.gbPawns.Padding = new System.Windows.Forms.Padding(0);
            this.gbPawns.Size = new System.Drawing.Size(130, 88);
            this.gbPawns.TabIndex = 7;
            this.gbPawns.TabStop = false;
            // 
            // btnImagePawn
            // 
            this.btnImagePawn.Location = new System.Drawing.Point(70, 35);
            this.btnImagePawn.Name = "btnImagePawn";
            this.btnImagePawn.Size = new System.Drawing.Size(44, 23);
            this.btnImagePawn.TabIndex = 5;
            this.btnImagePawn.Text = "Image";
            this.btnImagePawn.UseVisualStyleBackColor = true;
            this.btnImagePawn.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnColorPawn
            // 
            this.btnColorPawn.Location = new System.Drawing.Point(71, 9);
            this.btnColorPawn.Name = "btnColorPawn";
            this.btnColorPawn.Size = new System.Drawing.Size(44, 23);
            this.btnColorPawn.TabIndex = 4;
            this.btnColorPawn.Text = "Color";
            this.btnColorPawn.UseVisualStyleBackColor = true;
            this.btnColorPawn.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 9);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(26, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Height";
            // 
            // gbTiles
            // 
            this.gbTiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbTiles.Controls.Add(this.cbAllTiles);
            this.gbTiles.Controls.Add(this.btnImageTile);
            this.gbTiles.Controls.Add(this.btnColorTile);
            this.gbTiles.Controls.Add(this.textBox1);
            this.gbTiles.Controls.Add(this.textBox2);
            this.gbTiles.Controls.Add(this.label3);
            this.gbTiles.Controls.Add(this.label4);
            this.gbTiles.Location = new System.Drawing.Point(124, 0);
            this.gbTiles.Name = "gbTiles";
            this.gbTiles.Padding = new System.Windows.Forms.Padding(0);
            this.gbTiles.Size = new System.Drawing.Size(124, 88);
            this.gbTiles.TabIndex = 6;
            this.gbTiles.TabStop = false;
            // 
            // cbAllTiles
            // 
            this.cbAllTiles.AutoSize = true;
            this.cbAllTiles.Location = new System.Drawing.Point(12, 63);
            this.cbAllTiles.Name = "cbAllTiles";
            this.cbAllTiles.Size = new System.Drawing.Size(62, 17);
            this.cbAllTiles.TabIndex = 6;
            this.cbAllTiles.Text = "All Tiles";
            this.cbAllTiles.UseVisualStyleBackColor = true;
            // 
            // btnImageTile
            // 
            this.btnImageTile.Location = new System.Drawing.Point(70, 35);
            this.btnImageTile.Name = "btnImageTile";
            this.btnImageTile.Size = new System.Drawing.Size(44, 23);
            this.btnImageTile.TabIndex = 5;
            this.btnImageTile.Text = "Image";
            this.btnImageTile.UseVisualStyleBackColor = true;
            this.btnImageTile.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnColorTile
            // 
            this.btnColorTile.Location = new System.Drawing.Point(70, 9);
            this.btnColorTile.Name = "btnColorTile";
            this.btnColorTile.Size = new System.Drawing.Size(44, 23);
            this.btnColorTile.TabIndex = 4;
            this.btnColorTile.Text = "Color";
            this.btnColorTile.UseVisualStyleBackColor = true;
            this.btnColorTile.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Height";
            // 
            // gbInitialInfo
            // 
            this.gbInitialInfo.Controls.Add(this.label16);
            this.gbInitialInfo.Controls.Add(this.btnCreate);
            this.gbInitialInfo.Controls.Add(this.label13);
            this.gbInitialInfo.Controls.Add(this.tbStartX);
            this.gbInitialInfo.Controls.Add(this.tbStartY);
            this.gbInitialInfo.Controls.Add(this.label14);
            this.gbInitialInfo.Controls.Add(this.label15);
            this.gbInitialInfo.Controls.Add(this.label10);
            this.gbInitialInfo.Controls.Add(this.tbTileWidth);
            this.gbInitialInfo.Controls.Add(this.tbTileHeight);
            this.gbInitialInfo.Controls.Add(this.label11);
            this.gbInitialInfo.Controls.Add(this.label12);
            this.gbInitialInfo.Controls.Add(this.label9);
            this.gbInitialInfo.Controls.Add(this.tbFormWidth);
            this.gbInitialInfo.Controls.Add(this.tbFormHeight);
            this.gbInitialInfo.Controls.Add(this.label7);
            this.gbInitialInfo.Controls.Add(this.label8);
            this.gbInitialInfo.Location = new System.Drawing.Point(97, 114);
            this.gbInitialInfo.Name = "gbInitialInfo";
            this.gbInitialInfo.Size = new System.Drawing.Size(265, 127);
            this.gbInitialInfo.TabIndex = 7;
            this.gbInitialInfo.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Leave Empty for Defaults";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(158, 90);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 29);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Start Position";
            // 
            // tbStartX
            // 
            this.tbStartX.Location = new System.Drawing.Point(210, 64);
            this.tbStartX.Name = "tbStartX";
            this.tbStartX.Size = new System.Drawing.Size(26, 20);
            this.tbStartX.TabIndex = 17;
            // 
            // tbStartY
            // 
            this.tbStartY.Location = new System.Drawing.Point(210, 37);
            this.tbStartY.Name = "tbStartY";
            this.tbStartY.Size = new System.Drawing.Size(26, 20);
            this.tbStartY.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(159, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Horizontal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(166, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Vertical";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tile Size";
            // 
            // tbTileWidth
            // 
            this.tbTileWidth.Location = new System.Drawing.Point(127, 64);
            this.tbTileWidth.Name = "tbTileWidth";
            this.tbTileWidth.Size = new System.Drawing.Size(26, 20);
            this.tbTileWidth.TabIndex = 12;
            // 
            // tbTileHeight
            // 
            this.tbTileHeight.Location = new System.Drawing.Point(127, 37);
            this.tbTileHeight.Name = "tbTileHeight";
            this.tbTileHeight.Size = new System.Drawing.Size(26, 20);
            this.tbTileHeight.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Width";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Form Size";
            // 
            // tbFormWidth
            // 
            this.tbFormWidth.Location = new System.Drawing.Point(50, 64);
            this.tbFormWidth.Name = "tbFormWidth";
            this.tbFormWidth.Size = new System.Drawing.Size(26, 20);
            this.tbFormWidth.TabIndex = 7;
            // 
            // tbFormHeight
            // 
            this.tbFormHeight.Location = new System.Drawing.Point(50, 37);
            this.tbFormHeight.Name = "tbFormHeight";
            this.tbFormHeight.Size = new System.Drawing.Size(26, 20);
            this.tbFormHeight.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Height";
            // 
            // pbBackground
            // 
            this.pbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBackground.BackColor = System.Drawing.Color.Transparent;
            this.pbBackground.Location = new System.Drawing.Point(0, 86);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(457, 422);
            this.pbBackground.TabIndex = 8;
            this.pbBackground.TabStop = false;
            this.pbBackground.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 507);
            this.Controls.Add(this.gbInitialInfo);
            this.Controls.Add(this.gbToolbox);
            this.Controls.Add(this.pbBackground);
            this.MinimumSize = new System.Drawing.Size(473, 330);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.gbBG.ResumeLayout(false);
            this.gbBG.PerformLayout();
            this.gbToolbox.ResumeLayout(false);
            this.gbArrows.ResumeLayout(false);
            this.gbPawns.ResumeLayout(false);
            this.gbPawns.PerformLayout();
            this.gbTiles.ResumeLayout(false);
            this.gbTiles.PerformLayout();
            this.gbInitialInfo.ResumeLayout(false);
            this.gbInitialInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.GroupBox gbBG;
        private System.Windows.Forms.Button btnImageBG;
        private System.Windows.Forms.GroupBox gbToolbox;
        private System.Windows.Forms.GroupBox gbArrows;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox gbPawns;
        private System.Windows.Forms.Button btnImagePawn;
        private System.Windows.Forms.Button btnColorPawn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbTiles;
        private System.Windows.Forms.Button btnImageTile;
        private System.Windows.Forms.Button btnColorTile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbAllTiles;
        private System.Windows.Forms.GroupBox gbInitialInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbStartX;
        private System.Windows.Forms.TextBox tbStartY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTileWidth;
        private System.Windows.Forms.TextBox tbTileHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFormWidth;
        private System.Windows.Forms.TextBox tbFormHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnColorBG;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button btnDeleteTile;
    }
}

