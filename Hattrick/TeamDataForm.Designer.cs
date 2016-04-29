namespace Hattrick
{
    partial class TeamDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamDataForm));
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.captainLabel = new System.Windows.Forms.Label();
            this.batsmenButton = new System.Windows.Forms.Button();
            this.bowlerButton = new System.Windows.Forms.Button();
            this.captainPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.captainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerListBox
            // 
            this.playerListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerListBox.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 30;
            this.playerListBox.Location = new System.Drawing.Point(528, 106);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(337, 574);
            this.playerListBox.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Impact", 10F);
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(3, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 39);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // captainLabel
            // 
            this.captainLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.captainLabel.AutoSize = true;
            this.captainLabel.BackColor = System.Drawing.Color.Transparent;
            this.captainLabel.Font = new System.Drawing.Font("Nexa Light", 12F);
            this.captainLabel.Location = new System.Drawing.Point(3, 42);
            this.captainLabel.Name = "captainLabel";
            this.captainLabel.Size = new System.Drawing.Size(102, 30);
            this.captainLabel.TabIndex = 0;
            this.captainLabel.Text = "Captain";
            // 
            // batsmenButton
            // 
            this.batsmenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batsmenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.batsmenButton.Font = new System.Drawing.Font("Impact", 9F);
            this.batsmenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batsmenButton.Location = new System.Drawing.Point(528, 703);
            this.batsmenButton.Name = "batsmenButton";
            this.batsmenButton.Size = new System.Drawing.Size(165, 61);
            this.batsmenButton.TabIndex = 4;
            this.batsmenButton.Text = "Batsmen Performance";
            this.batsmenButton.UseVisualStyleBackColor = false;
            this.batsmenButton.Click += new System.EventHandler(this.batsmenButton_Click);
            // 
            // bowlerButton
            // 
            this.bowlerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bowlerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.bowlerButton.Font = new System.Drawing.Font("Impact", 9F);
            this.bowlerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bowlerButton.Location = new System.Drawing.Point(699, 703);
            this.bowlerButton.Name = "bowlerButton";
            this.bowlerButton.Size = new System.Drawing.Size(165, 61);
            this.bowlerButton.TabIndex = 5;
            this.bowlerButton.Text = "Bowler Performance";
            this.bowlerButton.UseVisualStyleBackColor = false;
            this.bowlerButton.Click += new System.EventHandler(this.bowlerButton_Click);
            // 
            // captainPictureBox
            // 
            this.captainPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.captainPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.captainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("captainPictureBox.Image")));
            this.captainPictureBox.Location = new System.Drawing.Point(3, 452);
            this.captainPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.captainPictureBox.Name = "captainPictureBox";
            this.captainPictureBox.Size = new System.Drawing.Size(338, 346);
            this.captainPictureBox.TabIndex = 7;
            this.captainPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 146);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 482);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(8, 77);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(338, 346);
            this.logoPictureBox.TabIndex = 10;
            this.logoPictureBox.TabStop = false;
            // 
            // TeamDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(876, 831);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.captainPictureBox);
            this.Controls.Add(this.bowlerButton);
            this.Controls.Add(this.batsmenButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.captainLabel);
            this.Name = "TeamDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Data";
            this.Load += new System.EventHandler(this.TeamDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label captainLabel;
        private System.Windows.Forms.Button batsmenButton;
        private System.Windows.Forms.Button bowlerButton;
        private System.Windows.Forms.PictureBox captainPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}