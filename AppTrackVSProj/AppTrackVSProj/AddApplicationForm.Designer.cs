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
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.companyTestBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.lbStatus2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Location = new System.Drawing.Point(24, 79);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(72, 20);
            this.lbCompany.TabIndex = 0;
            this.lbCompany.Text = "Company";
            this.lbCompany.Click += new System.EventHandler(this.lbCompany_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(24, 41);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(61, 20);
            this.lbPosition.TabIndex = 1;
            this.lbPosition.Text = "Position";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(24, 122);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(41, 20);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date";
            this.lbDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(24, 169);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(49, 20);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status";
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Location = new System.Drawing.Point(24, 219);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(55, 20);
            this.Details.TabIndex = 4;
            this.Details.Text = "Details";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(146, 34);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(125, 27);
            this.positionTextBox.TabIndex = 5;
            // 
            // companyTestBox
            // 
            this.companyTestBox.Location = new System.Drawing.Point(146, 79);
            this.companyTestBox.Name = "companyTestBox";
            this.companyTestBox.Size = new System.Drawing.Size(125, 27);
            this.companyTestBox.TabIndex = 6;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(146, 122);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(125, 27);
            this.dateTextBox.TabIndex = 8;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(146, 219);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(125, 27);
            this.detailsTextBox.TabIndex = 9;
            // 
            // lbStatus2
            // 
            this.lbStatus2.AutoSize = true;
            this.lbStatus2.Location = new System.Drawing.Point(146, 169);
            this.lbStatus2.Name = "lbStatus2";
            this.lbStatus2.Size = new System.Drawing.Size(117, 20);
            this.lbStatus2.TabIndex = 10;
            this.lbStatus2.Text = "Application sent";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 345);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbStatus2);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.companyTestBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbCompany);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

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