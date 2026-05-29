namespace Rock_Paper_Scissor
{
    partial class frmGame
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPlayer1Btns = new System.Windows.Forms.Panel();
            this.btnScissorPlayer1 = new System.Windows.Forms.Button();
            this.btnPaperPlayer1 = new System.Windows.Forms.Button();
            this.btnRockPlayer1 = new System.Windows.Forms.Button();
            this.pnlPlayer2Btns = new System.Windows.Forms.Panel();
            this.btnScissorPlayer2 = new System.Windows.Forms.Button();
            this.btnPaperPlayer2 = new System.Windows.Forms.Button();
            this.btnRockPlayer2 = new System.Windows.Forms.Button();
            this.pbPlayer2Choice = new System.Windows.Forms.PictureBox();
            this.pbPlayer1Choice = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoundTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayer1Wins = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDraws = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPlayer2Wins = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlPlayer1Btns.SuspendLayout();
            this.pnlPlayer2Btns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2Choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Choice)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblRounds);
            this.panel2.Location = new System.Drawing.Point(436, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 73);
            this.panel2.TabIndex = 11;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.ForeColor = System.Drawing.Color.White;
            this.lblRounds.Location = new System.Drawing.Point(16, 11);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(130, 53);
            this.lblRounds.TabIndex = 12;
            this.lblRounds.Text = " 1 / 10";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlayer1.Location = new System.Drawing.Point(110, 227);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(164, 53);
            this.lblPlayer1.TabIndex = 12;
            this.lblPlayer1.Text = "Player1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlayer2.Location = new System.Drawing.Point(754, 227);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(172, 53);
            this.lblPlayer2.TabIndex = 13;
            this.lblPlayer2.Text = "Player2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(484, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 53);
            this.label1.TabIndex = 16;
            this.label1.Text = "VS";
            // 
            // pnlPlayer1Btns
            // 
            this.pnlPlayer1Btns.Controls.Add(this.btnScissorPlayer1);
            this.pnlPlayer1Btns.Controls.Add(this.btnPaperPlayer1);
            this.pnlPlayer1Btns.Controls.Add(this.btnRockPlayer1);
            this.pnlPlayer1Btns.Location = new System.Drawing.Point(34, 528);
            this.pnlPlayer1Btns.Name = "pnlPlayer1Btns";
            this.pnlPlayer1Btns.Size = new System.Drawing.Size(313, 132);
            this.pnlPlayer1Btns.TabIndex = 24;
            // 
            // btnScissorPlayer1
            // 
            this.btnScissorPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScissorPlayer1.BackgroundImage = global::Rock_Paper_Scissor.Properties.Resources.scissor;
            this.btnScissorPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissorPlayer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissorPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScissorPlayer1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissorPlayer1.ForeColor = System.Drawing.Color.Transparent;
            this.btnScissorPlayer1.ImageIndex = 2;
            this.btnScissorPlayer1.Location = new System.Drawing.Point(218, 12);
            this.btnScissorPlayer1.Name = "btnScissorPlayer1";
            this.btnScissorPlayer1.Size = new System.Drawing.Size(80, 80);
            this.btnScissorPlayer1.TabIndex = 20;
            this.btnScissorPlayer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnScissorPlayer1.UseVisualStyleBackColor = false;
            this.btnScissorPlayer1.Click += new System.EventHandler(this.btnRockPaperScissorPlayer1_Click);
            this.btnScissorPlayer1.MouseEnter += new System.EventHandler(this.btnRockPaperScissorPlayer1_MouseEnter);
            this.btnScissorPlayer1.MouseLeave += new System.EventHandler(this.btnRockPaperScissorPlayer1_MouseLeave);
            // 
            // btnPaperPlayer1
            // 
            this.btnPaperPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaperPlayer1.BackgroundImage = global::Rock_Paper_Scissor.Properties.Resources.paper;
            this.btnPaperPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaperPlayer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaperPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaperPlayer1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaperPlayer1.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaperPlayer1.ImageIndex = 2;
            this.btnPaperPlayer1.Location = new System.Drawing.Point(117, 41);
            this.btnPaperPlayer1.Name = "btnPaperPlayer1";
            this.btnPaperPlayer1.Size = new System.Drawing.Size(80, 80);
            this.btnPaperPlayer1.TabIndex = 19;
            this.btnPaperPlayer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaperPlayer1.UseVisualStyleBackColor = false;
            this.btnPaperPlayer1.Click += new System.EventHandler(this.btnRockPaperScissorPlayer1_Click);
            this.btnPaperPlayer1.MouseEnter += new System.EventHandler(this.btnRockPaperScissorPlayer1_MouseEnter);
            this.btnPaperPlayer1.MouseLeave += new System.EventHandler(this.btnRockPaperScissorPlayer1_MouseLeave);
            // 
            // btnRockPlayer1
            // 
            this.btnRockPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRockPlayer1.BackgroundImage = global::Rock_Paper_Scissor.Properties.Resources.rock;
            this.btnRockPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRockPlayer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRockPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRockPlayer1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRockPlayer1.ForeColor = System.Drawing.Color.Transparent;
            this.btnRockPlayer1.ImageIndex = 2;
            this.btnRockPlayer1.Location = new System.Drawing.Point(16, 12);
            this.btnRockPlayer1.Name = "btnRockPlayer1";
            this.btnRockPlayer1.Size = new System.Drawing.Size(80, 80);
            this.btnRockPlayer1.TabIndex = 18;
            this.btnRockPlayer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRockPlayer1.UseVisualStyleBackColor = false;
            this.btnRockPlayer1.Click += new System.EventHandler(this.btnRockPaperScissorPlayer1_Click);
            this.btnRockPlayer1.MouseEnter += new System.EventHandler(this.btnRockPaperScissorPlayer1_MouseEnter);
            this.btnRockPlayer1.MouseLeave += new System.EventHandler(this.btnRockPaperScissorPlayer1_MouseLeave);
            // 
            // pnlPlayer2Btns
            // 
            this.pnlPlayer2Btns.Controls.Add(this.btnScissorPlayer2);
            this.pnlPlayer2Btns.Controls.Add(this.btnPaperPlayer2);
            this.pnlPlayer2Btns.Controls.Add(this.btnRockPlayer2);
            this.pnlPlayer2Btns.Location = new System.Drawing.Point(680, 528);
            this.pnlPlayer2Btns.Name = "pnlPlayer2Btns";
            this.pnlPlayer2Btns.Size = new System.Drawing.Size(314, 132);
            this.pnlPlayer2Btns.TabIndex = 25;
            // 
            // btnScissorPlayer2
            // 
            this.btnScissorPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScissorPlayer2.BackgroundImage = global::Rock_Paper_Scissor.Properties.Resources.scissor;
            this.btnScissorPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissorPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissorPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScissorPlayer2.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissorPlayer2.ForeColor = System.Drawing.Color.Transparent;
            this.btnScissorPlayer2.ImageIndex = 2;
            this.btnScissorPlayer2.Location = new System.Drawing.Point(221, 11);
            this.btnScissorPlayer2.Name = "btnScissorPlayer2";
            this.btnScissorPlayer2.Size = new System.Drawing.Size(80, 80);
            this.btnScissorPlayer2.TabIndex = 23;
            this.btnScissorPlayer2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnScissorPlayer2.UseVisualStyleBackColor = false;
            this.btnScissorPlayer2.Click += new System.EventHandler(this.btnRockPaperScissorPlayer2_Click);
            this.btnScissorPlayer2.MouseEnter += new System.EventHandler(this.btnRockPaperScissorPlayer2_MouseEnter);
            this.btnScissorPlayer2.MouseLeave += new System.EventHandler(this.btnRockPaperScissorPlayer2_MouseLeave);
            // 
            // btnPaperPlayer2
            // 
            this.btnPaperPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaperPlayer2.BackgroundImage = global::Rock_Paper_Scissor.Properties.Resources.paper;
            this.btnPaperPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaperPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaperPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaperPlayer2.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaperPlayer2.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaperPlayer2.ImageIndex = 2;
            this.btnPaperPlayer2.Location = new System.Drawing.Point(120, 40);
            this.btnPaperPlayer2.Name = "btnPaperPlayer2";
            this.btnPaperPlayer2.Size = new System.Drawing.Size(80, 80);
            this.btnPaperPlayer2.TabIndex = 22;
            this.btnPaperPlayer2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaperPlayer2.UseVisualStyleBackColor = false;
            this.btnPaperPlayer2.Click += new System.EventHandler(this.btnRockPaperScissorPlayer2_Click);
            this.btnPaperPlayer2.MouseEnter += new System.EventHandler(this.btnRockPaperScissorPlayer2_MouseEnter);
            this.btnPaperPlayer2.MouseLeave += new System.EventHandler(this.btnRockPaperScissorPlayer2_MouseLeave);
            // 
            // btnRockPlayer2
            // 
            this.btnRockPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRockPlayer2.BackgroundImage = global::Rock_Paper_Scissor.Properties.Resources.rock;
            this.btnRockPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRockPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRockPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRockPlayer2.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRockPlayer2.ForeColor = System.Drawing.Color.Transparent;
            this.btnRockPlayer2.ImageIndex = 2;
            this.btnRockPlayer2.Location = new System.Drawing.Point(19, 11);
            this.btnRockPlayer2.Name = "btnRockPlayer2";
            this.btnRockPlayer2.Size = new System.Drawing.Size(80, 80);
            this.btnRockPlayer2.TabIndex = 21;
            this.btnRockPlayer2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRockPlayer2.UseVisualStyleBackColor = false;
            this.btnRockPlayer2.Click += new System.EventHandler(this.btnRockPaperScissorPlayer2_Click);
            this.btnRockPlayer2.MouseEnter += new System.EventHandler(this.btnRockPaperScissorPlayer2_MouseEnter);
            this.btnRockPlayer2.MouseLeave += new System.EventHandler(this.btnRockPaperScissorPlayer2_MouseLeave);
            // 
            // pbPlayer2Choice
            // 
            this.pbPlayer2Choice.Location = new System.Drawing.Point(711, 296);
            this.pbPlayer2Choice.Name = "pbPlayer2Choice";
            this.pbPlayer2Choice.Size = new System.Drawing.Size(256, 214);
            this.pbPlayer2Choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer2Choice.TabIndex = 17;
            this.pbPlayer2Choice.TabStop = false;
            // 
            // pbPlayer1Choice
            // 
            this.pbPlayer1Choice.Location = new System.Drawing.Point(62, 296);
            this.pbPlayer1Choice.Name = "pbPlayer1Choice";
            this.pbPlayer1Choice.Size = new System.Drawing.Size(256, 214);
            this.pbPlayer1Choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer1Choice.TabIndex = 14;
            this.pbPlayer1Choice.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(451, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 53);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Game";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(336, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 10);
            this.panel1.TabIndex = 10;
            // 
            // RoundTimer
            // 
            this.RoundTimer.Interval = 1500;
            this.RoundTimer.Tick += new System.EventHandler(this.RoundTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(554, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Wins";
            // 
            // lblPlayer1Wins
            // 
            this.lblPlayer1Wins.AutoSize = true;
            this.lblPlayer1Wins.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.lblPlayer1Wins.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Wins.Location = new System.Drawing.Point(10, 5);
            this.lblPlayer1Wins.Name = "lblPlayer1Wins";
            this.lblPlayer1Wins.Size = new System.Drawing.Size(39, 43);
            this.lblPlayer1Wins.TabIndex = 14;
            this.lblPlayer1Wins.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblPlayer1Wins);
            this.panel3.Location = new System.Drawing.Point(428, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 55);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(430, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Wins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(485, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Draws";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lblDraws);
            this.panel4.Location = new System.Drawing.Point(491, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(55, 55);
            this.panel4.TabIndex = 15;
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.lblDraws.ForeColor = System.Drawing.Color.White;
            this.lblDraws.Location = new System.Drawing.Point(10, 5);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(39, 43);
            this.lblDraws.TabIndex = 14;
            this.lblDraws.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.lblPlayer2Wins);
            this.panel5.Location = new System.Drawing.Point(553, 268);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(55, 55);
            this.panel5.TabIndex = 15;
            // 
            // lblPlayer2Wins
            // 
            this.lblPlayer2Wins.AutoSize = true;
            this.lblPlayer2Wins.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.lblPlayer2Wins.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Wins.Location = new System.Drawing.Point(10, 5);
            this.lblPlayer2Wins.Name = "lblPlayer2Wins";
            this.lblPlayer2Wins.Size = new System.Drawing.Size(39, 43);
            this.lblPlayer2Wins.TabIndex = 14;
            this.lblPlayer2Wins.Text = "0";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 671);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlPlayer2Btns);
            this.Controls.Add(this.pnlPlayer1Btns);
            this.Controls.Add(this.pbPlayer2Choice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPlayer1Choice);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGame_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPlayer1Btns.ResumeLayout(false);
            this.pnlPlayer2Btns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2Choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Choice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.PictureBox pbPlayer1Choice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPlayer2Choice;
        private System.Windows.Forms.Button btnRockPlayer1;
        private System.Windows.Forms.Button btnPaperPlayer1;
        private System.Windows.Forms.Button btnScissorPlayer1;
        private System.Windows.Forms.Button btnScissorPlayer2;
        private System.Windows.Forms.Button btnPaperPlayer2;
        private System.Windows.Forms.Button btnRockPlayer2;
        private System.Windows.Forms.Panel pnlPlayer1Btns;
        private System.Windows.Forms.Panel pnlPlayer2Btns;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer RoundTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayer1Wins;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPlayer2Wins;
    }
}