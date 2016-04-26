namespace Hattrick
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            this.leagueGrid = new System.Windows.Forms.DataGridView();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.fixturesButton = new System.Windows.Forms.Button();
            this.finalsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leagueGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leagueGrid
            // 
            this.leagueGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(229)))), ((int)(((byte)(216)))));
            this.leagueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leagueGrid.Location = new System.Drawing.Point(12, 12);
            this.leagueGrid.Name = "leagueGrid";
            this.leagueGrid.RowTemplate.Height = 28;
            this.leagueGrid.Size = new System.Drawing.Size(1031, 440);
            this.leagueGrid.TabIndex = 0;
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(291, 497);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(290, 28);
            this.teamComboBox.TabIndex = 1;
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Impact", 10F);
            this.viewButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewButton.Location = new System.Drawing.Point(618, 487);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(124, 43);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "View Team";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click_1);
            // 
            // fixturesButton
            // 
            this.fixturesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.fixturesButton.Font = new System.Drawing.Font("Impact", 10F);
            this.fixturesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fixturesButton.Location = new System.Drawing.Point(291, 531);
            this.fixturesButton.Name = "fixturesButton";
            this.fixturesButton.Size = new System.Drawing.Size(225, 44);
            this.fixturesButton.TabIndex = 3;
            this.fixturesButton.Text = "View Fixtures";
            this.fixturesButton.UseVisualStyleBackColor = false;
            this.fixturesButton.Click += new System.EventHandler(this.fixturesButton_Click);
            // 
            // finalsButton
            // 
            this.finalsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.finalsButton.Font = new System.Drawing.Font("Impact", 10F);
            this.finalsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finalsButton.Location = new System.Drawing.Point(517, 531);
            this.finalsButton.Name = "finalsButton";
            this.finalsButton.Size = new System.Drawing.Size(225, 44);
            this.finalsButton.TabIndex = 4;
            this.finalsButton.Text = "View Finals";
            this.finalsButton.UseVisualStyleBackColor = false;
            this.finalsButton.Click += new System.EventHandler(this.finalsButton_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1055, 586);
            this.Controls.Add(this.finalsButton);
            this.Controls.Add(this.fixturesButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.teamComboBox);
            this.Controls.Add(this.leagueGrid);
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leagueGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView leagueGrid;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button fixturesButton;
        private System.Windows.Forms.Button finalsButton;

    }
}