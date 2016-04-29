namespace Hattrick
{
    partial class FinalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalForm));
            this.firstInningsBatView = new System.Windows.Forms.DataGridView();
            this.firstInningsBowlView = new System.Windows.Forms.DataGridView();
            this.secondInningsBowlView = new System.Windows.Forms.DataGridView();
            this.secondInningsBatView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstInningsBatView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstInningsBowlView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondInningsBowlView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondInningsBatView)).BeginInit();
            this.SuspendLayout();
            // 
            // firstInningsBatView
            // 
            this.firstInningsBatView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstInningsBatView.Location = new System.Drawing.Point(28, 46);
            this.firstInningsBatView.Name = "firstInningsBatView";
            this.firstInningsBatView.RowTemplate.Height = 28;
            this.firstInningsBatView.Size = new System.Drawing.Size(934, 434);
            this.firstInningsBatView.TabIndex = 0;
            // 
            // firstInningsBowlView
            // 
            this.firstInningsBowlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstInningsBowlView.Location = new System.Drawing.Point(977, 46);
            this.firstInningsBowlView.Name = "firstInningsBowlView";
            this.firstInningsBowlView.RowTemplate.Height = 28;
            this.firstInningsBowlView.Size = new System.Drawing.Size(919, 434);
            this.firstInningsBowlView.TabIndex = 1;
            // 
            // secondInningsBowlView
            // 
            this.secondInningsBowlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondInningsBowlView.Location = new System.Drawing.Point(977, 551);
            this.secondInningsBowlView.Name = "secondInningsBowlView";
            this.secondInningsBowlView.RowTemplate.Height = 28;
            this.secondInningsBowlView.Size = new System.Drawing.Size(919, 434);
            this.secondInningsBowlView.TabIndex = 3;
            // 
            // secondInningsBatView
            // 
            this.secondInningsBatView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondInningsBatView.Location = new System.Drawing.Point(28, 551);
            this.secondInningsBatView.Name = "secondInningsBatView";
            this.secondInningsBatView.RowTemplate.Height = 28;
            this.secondInningsBatView.Size = new System.Drawing.Size(934, 434);
            this.secondInningsBatView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nexa Light", 12F);
            this.label1.Location = new System.Drawing.Point(23, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "1st Innings Score = 175";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nexa Light", 12F);
            this.label2.Location = new System.Drawing.Point(23, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "2nd Innings Score = 177";
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1902, 839);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondInningsBowlView);
            this.Controls.Add(this.secondInningsBatView);
            this.Controls.Add(this.firstInningsBowlView);
            this.Controls.Add(this.firstInningsBatView);
            this.Name = "FinalForm";
            this.Text = "FinalForm";
            ((System.ComponentModel.ISupportInitialize)(this.firstInningsBatView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstInningsBowlView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondInningsBowlView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondInningsBatView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView firstInningsBatView;
        private System.Windows.Forms.DataGridView firstInningsBowlView;
        private System.Windows.Forms.DataGridView secondInningsBowlView;
        private System.Windows.Forms.DataGridView secondInningsBatView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}