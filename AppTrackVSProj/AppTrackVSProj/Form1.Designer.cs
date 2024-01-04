namespace AppTrackVSProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView = new DataGridView();
            Position = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Details = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            searchTextBox = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            progressBar = new ProgressBar();
            progressBarLowVal = new Label();
            progressBarHighVal = new Label();
            buttonProgressBarTest = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(39, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(167, 76);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Position, Company, Date, Status, Details, Id });
            dataGridView.Location = new Point(39, 159);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(675, 192);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 125;
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.MinimumWidth = 6;
            Company.Name = "Company";
            Company.ReadOnly = true;
            Company.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Details
            // 
            Details.HeaderText = "Details";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Width = 125;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(300, 76);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(486, 77);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(125, 27);
            searchTextBox.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(620, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(620, 112);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(49, 32);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(291, 10);
            progressBar.TabIndex = 10;
            // 
            // progressBarLowVal
            // 
            progressBarLowVal.AutoSize = true;
            progressBarLowVal.Location = new Point(39, 9);
            progressBarLowVal.Name = "progressBarLowVal";
            progressBarLowVal.Size = new Size(17, 20);
            progressBarLowVal.TabIndex = 8;
            progressBarLowVal.Text = "0";
            // 
            // progressBarHighVal
            // 
            progressBarHighVal.AutoSize = true;
            progressBarHighVal.Location = new Point(317, 9);
            progressBarHighVal.Name = "progressBarHighVal";
            progressBarHighVal.Size = new Size(40, 20);
            progressBarHighVal.TabIndex = 9;
            progressBarHighVal.Text = "Goal";
            // 
            // buttonProgressBarTest
            // 
            buttonProgressBarTest.Location = new Point(377, 13);
            buttonProgressBarTest.Name = "buttonProgressBarTest";
            buttonProgressBarTest.Size = new Size(37, 28);
            buttonProgressBarTest.TabIndex = 11;
            buttonProgressBarTest.Text = "buttonProgressBarTest";
            buttonProgressBarTest.UseVisualStyleBackColor = true;
            buttonProgressBarTest.Click += buttonProgressBarTest_Click;
            // 
            // button1
            // 
            button1.Location = new Point(437, 15);
            button1.Name = "button1";
            button1.Size = new Size(28, 27);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 450);
            Controls.Add(button1);
            Controls.Add(buttonProgressBarTest);
            Controls.Add(progressBarHighVal);
            Controls.Add(progressBarLowVal);
            Controls.Add(progressBar);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(searchTextBox);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(500, 500);
            MaximizeBox = false;
            MaximumSize = new Size(834, 497);
            MinimizeBox = false;
            MinimumSize = new Size(834, 497);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        public DataGridView dataGridView;
        private Button btnUpdate;
        private TextBox searchTextBox;
        private Button btnSearch;
        private Button btnClear;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Details;
        private DataGridViewTextBoxColumn Id;
        private ProgressBar progressBar;
        private Label progressBarLowVal;
        private Label progressBarHighVal;
        private Button buttonProgressBarTest;
        private Button button1;
    }
}