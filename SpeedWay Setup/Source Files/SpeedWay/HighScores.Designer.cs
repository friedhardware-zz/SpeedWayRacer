namespace SpeedWay
{
    partial class HighScores
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sortByList1 = new System.Windows.Forms.ListBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.outbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.column4});
            this.dataGrid.Location = new System.Drawing.Point(33, 80);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(613, 416);
            this.dataGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Points";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 61;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Time (seconds)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // column4
            // 
            this.column4.HeaderText = "Date";
            this.column4.Name = "column4";
            this.column4.ReadOnly = true;
            this.column4.Width = 200;
            // 
            // sortByList1
            // 
            this.sortByList1.FormattingEnabled = true;
            this.sortByList1.Items.AddRange(new object[] {
            "Name",
            "Points/Time",
            "Date"});
            this.sortByList1.Location = new System.Drawing.Point(38, 12);
            this.sortByList1.Name = "sortByList1";
            this.sortByList1.Size = new System.Drawing.Size(120, 43);
            this.sortByList1.TabIndex = 1;
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(194, 12);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(110, 29);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort!!";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // outbutton
            // 
            this.outbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outbutton.Location = new System.Drawing.Point(387, 12);
            this.outbutton.Name = "outbutton";
            this.outbutton.Size = new System.Drawing.Size(176, 29);
            this.outbutton.TabIndex = 5;
            this.outbutton.Text = "Write Report";
            this.outbutton.UseVisualStyleBackColor = true;
            this.outbutton.Click += new System.EventHandler(this.outbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clicking Write Report will make a CSV file in your C: drive!\r\n(Lists all scores s" +
    "orted by name then date)\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Warning!\r\nOnly pulls the top 150 sorted records.";
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outbutton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortByList1);
            this.Controls.Add(this.dataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScores";
            this.Text = "High Scores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox sortByList1;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button outbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;



    }
}