namespace Rock_Paper_Scissor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVsComputer = new System.Windows.Forms.Button();
            this.btnVsPlayer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(314, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(425, 53);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rock-Paper-Scissor";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "playericon.png");
            this.imageList1.Images.SetKeyName(1, "computer_Nero_AI_Image_Upscaler_Photo_Face.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rock_Paper_Scissor.Properties.Resources.rockpaperscissor;
            this.pictureBox2.Location = new System.Drawing.Point(275, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(488, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnVsComputer
            // 
            this.btnVsComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVsComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVsComputer.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsComputer.ForeColor = System.Drawing.Color.White;
            this.btnVsComputer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVsComputer.ImageIndex = 1;
            this.btnVsComputer.ImageList = this.imageList1;
            this.btnVsComputer.Location = new System.Drawing.Point(347, 384);
            this.btnVsComputer.Name = "btnVsComputer";
            this.btnVsComputer.Size = new System.Drawing.Size(341, 82);
            this.btnVsComputer.TabIndex = 2;
            this.btnVsComputer.Text = "          VS Computer";
            this.btnVsComputer.UseVisualStyleBackColor = false;
            this.btnVsComputer.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnVsPlayer
            // 
            this.btnVsPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVsPlayer.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsPlayer.ForeColor = System.Drawing.Color.White;
            this.btnVsPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVsPlayer.ImageIndex = 0;
            this.btnVsPlayer.ImageList = this.imageList1;
            this.btnVsPlayer.Location = new System.Drawing.Point(347, 472);
            this.btnVsPlayer.Name = "btnVsPlayer";
            this.btnVsPlayer.Size = new System.Drawing.Size(341, 82);
            this.btnVsPlayer.TabIndex = 1;
            this.btnVsPlayer.Text = "     VS Player";
            this.btnVsPlayer.UseVisualStyleBackColor = false;
            this.btnVsPlayer.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(161, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 10);
            this.panel1.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1044, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVsComputer);
            this.Controls.Add(this.btnVsPlayer);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock-Paper-Scissor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnVsPlayer;
        private System.Windows.Forms.Button btnVsComputer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

