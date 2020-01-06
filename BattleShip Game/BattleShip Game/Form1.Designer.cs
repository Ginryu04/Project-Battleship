namespace BattleShip_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerScore = new System.Windows.Forms.Label();
            this.enemyScore = new System.Windows.Forms.Label();
            this.enemyMoves = new System.Windows.Forms.Label();
            this.roundsText = new System.Windows.Forms.Label();
            this.helpText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enemyLocationList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.enemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyPositionPicker = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Black;
            this.playerScore.Location = new System.Drawing.Point(337, 100);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(49, 32);
            this.playerScore.TabIndex = 0;
            this.playerScore.Text = "00";
            // 
            // enemyScore
            // 
            this.enemyScore.AutoSize = true;
            this.enemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyScore.Location = new System.Drawing.Point(911, 100);
            this.enemyScore.Name = "enemyScore";
            this.enemyScore.Size = new System.Drawing.Size(49, 32);
            this.enemyScore.TabIndex = 1;
            this.enemyScore.Text = "00";
            // 
            // enemyMoves
            // 
            this.enemyMoves.AutoSize = true;
            this.enemyMoves.BackColor = System.Drawing.Color.Transparent;
            this.enemyMoves.ForeColor = System.Drawing.SystemColors.Control;
            this.enemyMoves.Location = new System.Drawing.Point(806, 54);
            this.enemyMoves.Name = "enemyMoves";
            this.enemyMoves.Size = new System.Drawing.Size(25, 17);
            this.enemyMoves.TabIndex = 2;
            this.enemyMoves.Text = "A1";
            // 
            // roundsText
            // 
            this.roundsText.AutoSize = true;
            this.roundsText.BackColor = System.Drawing.Color.Transparent;
            this.roundsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundsText.Location = new System.Drawing.Point(487, 179);
            this.roundsText.Name = "roundsText";
            this.roundsText.Size = new System.Drawing.Size(102, 29);
            this.roundsText.TabIndex = 3;
            this.roundsText.Text = "Rounds";
            // 
            // helpText
            // 
            this.helpText.AutoSize = true;
            this.helpText.BackColor = System.Drawing.Color.Transparent;
            this.helpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpText.ForeColor = System.Drawing.Color.LightGreen;
            this.helpText.Location = new System.Drawing.Point(109, 534);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(328, 18);
            this.helpText.TabIndex = 4;
            this.helpText.Text = "Click on 3 Different Buttons Above to Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "D";
            // 
            // enemyLocationList
            // 
            this.enemyLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyLocationList.DropDownWidth = 95;
            this.enemyLocationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLocationList.FormattingEnabled = true;
            this.enemyLocationList.Location = new System.Drawing.Point(176, 38);
            this.enemyLocationList.Name = "enemyLocationList";
            this.enemyLocationList.Size = new System.Drawing.Size(106, 33);
            this.enemyLocationList.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BattleShip_Game.Properties.Resources.Player;
            this.pictureBox1.Location = new System.Drawing.Point(58, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BattleShip_Game.Properties.Resources.enemy;
            this.pictureBox2.Location = new System.Drawing.Point(660, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(311, 38);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(80, 40);
            this.attackButton.TabIndex = 16;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackEnemyPosition);
            // 
            // w1
            // 
            this.w1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w1.BackgroundImage")));
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.w1.Location = new System.Drawing.Point(103, 221);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(75, 55);
            this.w1.TabIndex = 17;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w2
            // 
            this.w2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w2.BackgroundImage")));
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.w2.Location = new System.Drawing.Point(196, 221);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(75, 55);
            this.w2.TabIndex = 18;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w3
            // 
            this.w3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w3.BackgroundImage")));
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.w3.Location = new System.Drawing.Point(290, 221);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(75, 55);
            this.w3.TabIndex = 19;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w4
            // 
            this.w4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w4.BackgroundImage")));
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.w4.Location = new System.Drawing.Point(381, 221);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(75, 55);
            this.w4.TabIndex = 20;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x1
            // 
            this.x1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x1.BackgroundImage")));
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.x1.Location = new System.Drawing.Point(103, 298);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(75, 55);
            this.x1.TabIndex = 21;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x2
            // 
            this.x2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x2.BackgroundImage")));
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.x2.Location = new System.Drawing.Point(196, 298);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(75, 55);
            this.x2.TabIndex = 22;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x3
            // 
            this.x3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x3.BackgroundImage")));
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.x3.Location = new System.Drawing.Point(290, 298);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(75, 55);
            this.x3.TabIndex = 23;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x4
            // 
            this.x4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x4.BackgroundImage")));
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.x4.Location = new System.Drawing.Point(381, 298);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(75, 55);
            this.x4.TabIndex = 24;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y1
            // 
            this.y1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("y1.BackgroundImage")));
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.y1.Location = new System.Drawing.Point(103, 381);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(75, 55);
            this.y1.TabIndex = 25;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y2
            // 
            this.y2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("y2.BackgroundImage")));
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.y2.Location = new System.Drawing.Point(196, 381);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(75, 55);
            this.y2.TabIndex = 26;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y3
            // 
            this.y3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("y3.BackgroundImage")));
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.y3.Location = new System.Drawing.Point(290, 381);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(75, 55);
            this.y3.TabIndex = 27;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y4
            // 
            this.y4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("y4.BackgroundImage")));
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.y4.Location = new System.Drawing.Point(381, 381);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(75, 55);
            this.y4.TabIndex = 28;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z1
            // 
            this.z1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("z1.BackgroundImage")));
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.z1.Location = new System.Drawing.Point(103, 455);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(75, 55);
            this.z1.TabIndex = 29;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z2
            // 
            this.z2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("z2.BackgroundImage")));
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.z2.Location = new System.Drawing.Point(196, 455);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(75, 55);
            this.z2.TabIndex = 30;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z3
            // 
            this.z3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("z3.BackgroundImage")));
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.z3.Location = new System.Drawing.Point(290, 455);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(75, 55);
            this.z3.TabIndex = 31;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z4
            // 
            this.z4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("z4.BackgroundImage")));
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.z4.Location = new System.Drawing.Point(381, 455);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(75, 55);
            this.z4.TabIndex = 32;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.a1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("a1.BackgroundImage")));
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Location = new System.Drawing.Point(601, 232);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 55);
            this.a1.TabIndex = 33;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = false;
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.a2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("a2.BackgroundImage")));
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Location = new System.Drawing.Point(697, 232);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 55);
            this.a2.TabIndex = 34;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = false;
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.a3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("a3.BackgroundImage")));
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Location = new System.Drawing.Point(791, 232);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 55);
            this.a3.TabIndex = 35;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = false;
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.a4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("a4.BackgroundImage")));
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Location = new System.Drawing.Point(885, 232);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(75, 55);
            this.a4.TabIndex = 36;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = false;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b1.BackgroundImage")));
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Location = new System.Drawing.Point(601, 307);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 55);
            this.b1.TabIndex = 37;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = false;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b2.BackgroundImage")));
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Location = new System.Drawing.Point(697, 307);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 55);
            this.b2.TabIndex = 38;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b3.BackgroundImage")));
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Location = new System.Drawing.Point(791, 307);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 55);
            this.b3.TabIndex = 39;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = false;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b4.BackgroundImage")));
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Location = new System.Drawing.Point(885, 307);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 55);
            this.b4.TabIndex = 40;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = false;
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.c1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("c1.BackgroundImage")));
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Location = new System.Drawing.Point(601, 381);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 55);
            this.c1.TabIndex = 41;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = false;
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.c2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("c2.BackgroundImage")));
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Location = new System.Drawing.Point(697, 381);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 55);
            this.c2.TabIndex = 42;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = false;
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.c3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("c3.BackgroundImage")));
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Location = new System.Drawing.Point(791, 381);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 55);
            this.c3.TabIndex = 43;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = false;
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.c4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("c4.BackgroundImage")));
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Location = new System.Drawing.Point(885, 381);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(75, 55);
            this.c4.TabIndex = 44;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = false;
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.d1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("d1.BackgroundImage")));
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Location = new System.Drawing.Point(601, 455);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(75, 55);
            this.d1.TabIndex = 45;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = false;
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.d2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("d2.BackgroundImage")));
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Location = new System.Drawing.Point(697, 455);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(75, 55);
            this.d2.TabIndex = 46;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = false;
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.d3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("d3.BackgroundImage")));
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Location = new System.Drawing.Point(791, 455);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(75, 55);
            this.d3.TabIndex = 47;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = false;
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.d4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("d4.BackgroundImage")));
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Location = new System.Drawing.Point(885, 455);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 55);
            this.d4.TabIndex = 48;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = false;
            // 
            // enemyPlayTimer
            // 
            this.enemyPlayTimer.Interval = 1000;
            this.enemyPlayTimer.Tick += new System.EventHandler(this.enemyAttackPlayer);
            // 
            // enemyPositionPicker
            // 
            this.enemyPositionPicker.Enabled = true;
            this.enemyPositionPicker.Interval = 500;
            this.enemyPositionPicker.Tick += new System.EventHandler(this.enemyPicksPositions);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleShip_Game.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 577);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemyLocationList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpText);
            this.Controls.Add(this.roundsText);
            this.Controls.Add(this.enemyMoves);
            this.Controls.Add(this.enemyScore);
            this.Controls.Add(this.playerScore);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "BattleShip";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Label enemyMoves;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox enemyLocationList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Timer enemyPlayTimer;
        private System.Windows.Forms.Timer enemyPositionPicker;
    }
}

