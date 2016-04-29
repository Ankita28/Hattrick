namespace Hattrick
{
    partial class PlayerPoolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerPoolForm));
            this.playerPoolGrid = new System.Windows.Forms.DataGridView();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerpoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hattrickDataSet = new Hattrick.hattrickDataSet();
            this.playerpoolTableAdapter = new Hattrick.hattrickDataSetTableAdapters.playerpoolTableAdapter();
            this.playerTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerPoolGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hattrickDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPoolGrid
            // 
            this.playerPoolGrid.AutoGenerateColumns = false;
            this.playerPoolGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(229)))), ((int)(((byte)(216)))));
            this.playerPoolGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerPoolGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.basepriceDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn});
            this.playerPoolGrid.DataSource = this.playerpoolBindingSource;
            this.playerPoolGrid.Location = new System.Drawing.Point(50, 50);
            this.playerPoolGrid.Name = "playerPoolGrid";
            this.playerPoolGrid.RowTemplate.Height = 28;
            this.playerPoolGrid.Size = new System.Drawing.Size(850, 570);
            this.playerPoolGrid.TabIndex = 0;
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "playerid";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "playerid";
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "speciality";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            // 
            // basepriceDataGridViewTextBoxColumn
            // 
            this.basepriceDataGridViewTextBoxColumn.DataPropertyName = "baseprice";
            this.basepriceDataGridViewTextBoxColumn.HeaderText = "baseprice";
            this.basepriceDataGridViewTextBoxColumn.Name = "basepriceDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // playerpoolBindingSource
            // 
            this.playerpoolBindingSource.DataMember = "playerpool";
            this.playerpoolBindingSource.DataSource = this.hattrickDataSet;
            // 
            // hattrickDataSet
            // 
            this.hattrickDataSet.DataSetName = "hattrickDataSet";
            this.hattrickDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerpoolTableAdapter
            // 
            this.playerpoolTableAdapter.ClearBeforeFill = true;
            // 
            // playerTextBox
            // 
            this.playerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTextBox.Location = new System.Drawing.Point(50, 651);
            this.playerTextBox.Name = "playerTextBox";
            this.playerTextBox.Size = new System.Drawing.Size(286, 32);
            this.playerTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(353, 626);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 57);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Player ID to select";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(434, 626);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 57);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PlayerPoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(943, 695);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.playerTextBox);
            this.Controls.Add(this.playerPoolGrid);
            this.Name = "PlayerPoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Pool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerPoolForm_FormClosed);
            this.Load += new System.EventHandler(this.PlayerPoolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerPoolGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hattrickDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playerPoolGrid;
        private hattrickDataSet hattrickDataSet;
        private System.Windows.Forms.BindingSource playerpoolBindingSource;
        private hattrickDataSetTableAdapters.playerpoolTableAdapter playerpoolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox playerTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;

    }
}