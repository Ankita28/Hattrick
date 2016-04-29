namespace Hattrick
{
    partial class OwnerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerScreen));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.captainPictureBox = new System.Windows.Forms.PictureBox();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.captainLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.playerPoolButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.leagueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, -3);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(338, 346);
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // captainPictureBox
            // 
            this.captainPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.captainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("captainPictureBox.Image")));
            this.captainPictureBox.Location = new System.Drawing.Point(0, 471);
            this.captainPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.captainPictureBox.Name = "captainPictureBox";
            this.captainPictureBox.Size = new System.Drawing.Size(338, 346);
            this.captainPictureBox.TabIndex = 4;
            this.captainPictureBox.TabStop = false;
            // 
            // playerListBox
            // 
            this.playerListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(229)))), ((int)(((byte)(216)))));
            this.playerListBox.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 30;
            this.playerListBox.Location = new System.Drawing.Point(352, 143);
            this.playerListBox.Margin = new System.Windows.Forms.Padding(15);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(343, 544);
            this.playerListBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(717, 178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 482);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // captainLabel
            // 
            this.captainLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.captainLabel.AutoSize = true;
            this.captainLabel.BackColor = System.Drawing.Color.Transparent;
            this.captainLabel.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captainLabel.ForeColor = System.Drawing.Color.Black;
            this.captainLabel.Location = new System.Drawing.Point(16, 366);
            this.captainLabel.Name = "captainLabel";
            this.captainLabel.Size = new System.Drawing.Size(114, 30);
            this.captainLabel.TabIndex = 7;
            this.captainLabel.Text = "Captain: ";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(16, 412);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 30);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Virat Kohli";
            // 
            // playerPoolButton
            // 
            this.playerPoolButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerPoolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerPoolButton.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPoolButton.ForeColor = System.Drawing.Color.Snow;
            this.playerPoolButton.Location = new System.Drawing.Point(352, 14);
            this.playerPoolButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerPoolButton.Name = "playerPoolButton";
            this.playerPoolButton.Size = new System.Drawing.Size(343, 92);
            this.playerPoolButton.TabIndex = 9;
            this.playerPoolButton.Text = "Visit Player Pool";
            this.playerPoolButton.UseVisualStyleBackColor = true;
            this.playerPoolButton.Click += new System.EventHandler(this.playerPoolButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.Location = new System.Drawing.Point(352, 765);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(343, 52);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // leagueButton
            // 
            this.leagueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leagueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leagueButton.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leagueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leagueButton.Location = new System.Drawing.Point(352, 707);
            this.leagueButton.Name = "leagueButton";
            this.leagueButton.Size = new System.Drawing.Size(343, 52);
            this.leagueButton.TabIndex = 13;
            this.leagueButton.Text = "View League";
            this.leagueButton.UseVisualStyleBackColor = true;
            this.leagueButton.Click += new System.EventHandler(this.leagueButton_Click);
            // 
            // OwnerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(813, 829);
            this.Controls.Add(this.leagueButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.playerPoolButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.captainLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.captainPictureBox);
            this.Controls.Add(this.logoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OwnerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Challengers Bangalore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OwnerScreen_FormClosed);
            this.Load += new System.EventHandler(this.OwnerScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox captainPictureBox;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label captainLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button playerPoolButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button leagueButton;
    }
}