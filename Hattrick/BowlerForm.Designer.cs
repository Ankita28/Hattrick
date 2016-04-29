namespace Hattrick
{
    partial class BowlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BowlerForm));
            this.backButton = new System.Windows.Forms.Button();
            this.performanceGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.performanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.backButton.Font = new System.Drawing.Font("Impact", 12F);
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(330, 523);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(347, 52);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // performanceGrid
            // 
            this.performanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.performanceGrid.Location = new System.Drawing.Point(12, 12);
            this.performanceGrid.Name = "performanceGrid";
            this.performanceGrid.RowTemplate.Height = 28;
            this.performanceGrid.Size = new System.Drawing.Size(993, 505);
            this.performanceGrid.TabIndex = 2;
            // 
            // BowlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1017, 591);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.performanceGrid);
            this.Name = "BowlerForm";
            this.Text = "BowlerForm";
            this.Load += new System.EventHandler(this.BowlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView performanceGrid;

    }
}