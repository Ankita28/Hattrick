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
            this.SuspendLayout();
            // 
            // playerListBox
            // 
            this.playerListBox.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 30;
            this.playerListBox.Location = new System.Drawing.Point(134, 42);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(337, 574);
            this.playerListBox.TabIndex = 2;
            // 
            // backButton
            // 
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
            this.captainLabel.AutoSize = true;
            this.captainLabel.BackColor = System.Drawing.Color.Transparent;
            this.captainLabel.Font = new System.Drawing.Font("Nexa Light", 12F);
            this.captainLabel.Location = new System.Drawing.Point(143, 9);
            this.captainLabel.Name = "captainLabel";
            this.captainLabel.Size = new System.Drawing.Size(102, 30);
            this.captainLabel.TabIndex = 0;
            this.captainLabel.Text = "Captain";
            // 
            // batsmenButton
            // 
            this.batsmenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.batsmenButton.Font = new System.Drawing.Font("Impact", 9F);
            this.batsmenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batsmenButton.Location = new System.Drawing.Point(134, 625);
            this.batsmenButton.Name = "batsmenButton";
            this.batsmenButton.Size = new System.Drawing.Size(165, 61);
            this.batsmenButton.TabIndex = 4;
            this.batsmenButton.Text = "Batsmen Performance";
            this.batsmenButton.UseVisualStyleBackColor = false;
            this.batsmenButton.Click += new System.EventHandler(this.batsmenButton_Click);
            // 
            // bowlerButton
            // 
            this.bowlerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.bowlerButton.Font = new System.Drawing.Font("Impact", 9F);
            this.bowlerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bowlerButton.Location = new System.Drawing.Point(306, 625);
            this.bowlerButton.Name = "bowlerButton";
            this.bowlerButton.Size = new System.Drawing.Size(165, 61);
            this.bowlerButton.TabIndex = 5;
            this.bowlerButton.Text = "Bowler Performance";
            this.bowlerButton.UseVisualStyleBackColor = false;
            this.bowlerButton.Click += new System.EventHandler(this.bowlerButton_Click);
            // 
            // TeamDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 686);
            this.Controls.Add(this.bowlerButton);
            this.Controls.Add(this.batsmenButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.captainLabel);
            this.Name = "TeamDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Data";
            this.Load += new System.EventHandler(this.TeamDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label captainLabel;
        private System.Windows.Forms.Button batsmenButton;
        private System.Windows.Forms.Button bowlerButton;
    }
}