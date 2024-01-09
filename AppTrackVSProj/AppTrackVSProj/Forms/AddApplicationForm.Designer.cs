namespace AppTrackVSProj
{
    partial class AddApplicationForm
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
            lbCompany = new Label();
            lbPosition = new Label();
            lbDate = new Label();
            lbStatus = new Label();
            Details = new Label();
            positionTextBox = new TextBox();
            companyTestBox = new TextBox();
            dateTextBox = new TextBox();
            detailsTextBox = new TextBox();
            lbStatus2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbCompany
            // 
            lbCompany.Anchor = AnchorStyles.None;
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(33, 72);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(72, 20);
            lbCompany.TabIndex = 0;
            lbCompany.Text = "Company";
            lbCompany.Click += lbCompany_Click;
            // 
            // lbPosition
            // 
            lbPosition.Anchor = AnchorStyles.None;
            lbPosition.AutoSize = true;
            lbPosition.Location = new Point(33, 27);
            lbPosition.Name = "lbPosition";
            lbPosition.Size = new Size(61, 20);
            lbPosition.TabIndex = 1;
            lbPosition.Text = "Position";
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.None;
            lbDate.AutoSize = true;
            lbDate.Location = new Point(33, 115);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(41, 20);
            lbDate.TabIndex = 2;
            lbDate.Text = "Date";
            lbDate.Click += label3_Click;
            // 
            // lbStatus
            // 
            lbStatus.Anchor = AnchorStyles.None;
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(33, 151);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 3;
            lbStatus.Text = "Status";
            // 
            // Details
            // 
            Details.Anchor = AnchorStyles.None;
            Details.AutoSize = true;
            Details.Location = new Point(33, 187);
            Details.Name = "Details";
            Details.Size = new Size(55, 20);
            Details.TabIndex = 4;
            Details.Text = "Details";
            Details.Click += Details_Click;
            // 
            // positionTextBox
            // 
            positionTextBox.Anchor = AnchorStyles.None;
            positionTextBox.Location = new Point(111, 20);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(125, 27);
            positionTextBox.TabIndex = 5;
            // 
            // companyTestBox
            // 
            companyTestBox.Anchor = AnchorStyles.None;
            companyTestBox.Location = new Point(111, 65);
            companyTestBox.Name = "companyTestBox";
            companyTestBox.Size = new Size(125, 27);
            companyTestBox.TabIndex = 6;
            // 
            // dateTextBox
            // 
            dateTextBox.Anchor = AnchorStyles.None;
            dateTextBox.Location = new Point(111, 108);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(125, 27);
            dateTextBox.TabIndex = 8;
            // 
            // detailsTextBox
            // 
            detailsTextBox.Anchor = AnchorStyles.None;
            detailsTextBox.Location = new Point(111, 184);
            detailsTextBox.Name = "detailsTextBox";
            detailsTextBox.Size = new Size(125, 27);
            detailsTextBox.TabIndex = 9;
            // 
            // lbStatus2
            // 
            lbStatus2.Anchor = AnchorStyles.None;
            lbStatus2.AutoSize = true;
            lbStatus2.Location = new Point(111, 151);
            lbStatus2.Name = "lbStatus2";
            lbStatus2.Size = new Size(117, 20);
            lbStatus2.TabIndex = 10;
            lbStatus2.Text = "Application sent";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(23, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(142, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 277);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbStatus2);
            Controls.Add(detailsTextBox);
            Controls.Add(dateTextBox);
            Controls.Add(companyTestBox);
            Controls.Add(positionTextBox);
            Controls.Add(Details);
            Controls.Add(lbStatus);
            Controls.Add(lbDate);
            Controls.Add(lbPosition);
            Controls.Add(lbCompany);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(279, 279);
            MinimizeBox = false;
            MinimumSize = new Size(279, 279);
            Name = "AddApplicationForm";
            ShowIcon = false;
            Load += AddApplicationForm_Load;
            MouseDown += AddApplicationForm_MouseDown;
            MouseMove += AddApplicationForm_MouseMove;
            MouseUp += AddApplicationForm_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCompany;
        private Label lbPosition;
        private Label lbDate;
        private Label lbStatus;
        private Label Details;
        private TextBox positionTextBox;
        private TextBox companyTestBox;
        private TextBox dateTextBox;
        private TextBox detailsTextBox;
        private Label lbStatus2;
        private Button btnSave;
        private Button btnCancel;
    }
}