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
            this.hattrickDataSet = new Hattrick.hattrickDataSet();
            this.playerpoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerpoolTableAdapter = new Hattrick.hattrickDataSetTableAdapters.playerpoolTableAdapter();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.playerPoolGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hattrickDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpoolBindingSource)).BeginInit();
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
            // hattrickDataSet
            // 
            this.hattrickDataSet.DataSetName = "hattrickDataSet";
            this.hattrickDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerpoolBindingSource
            // 
            this.playerpoolBindingSource.DataMember = "playerpool";
            this.playerpoolBindingSource.DataSource = this.hattrickDataSet;
            // 
            // playerpoolTableAdapter
            // 
            this.playerpoolTableAdapter.ClearBeforeFill = true;
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
            // PlayerPoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(943, 644);
            this.Controls.Add(this.playerPoolGrid);
            this.Name = "PlayerPoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Pool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerPoolForm_FormClosed);
            this.Load += new System.EventHandler(this.PlayerPoolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerPoolGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hattrickDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpoolBindingSource)).EndInit();
            this.ResumeLayout(false);

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

    }
}