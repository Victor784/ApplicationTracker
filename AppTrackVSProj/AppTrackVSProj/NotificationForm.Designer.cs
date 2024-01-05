namespace AppTrackVSProj
{
    partial class NotificationForm
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
            label_for_pop_up = new Label();
            SuspendLayout();
            // 
            // label_for_pop_up
            // 
            label_for_pop_up.AutoSize = true;
            label_for_pop_up.Location = new Point(-2, 9);
            label_for_pop_up.Name = "label_for_pop_up";
            label_for_pop_up.Size = new Size(299, 40);
            label_for_pop_up.TabIndex = 0;
            label_for_pop_up.Text = "Lorem Ipsum lorem ipsum lorem ipsum lore\r\n\r\n";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(309, 41);
            ControlBox = false;
            Controls.Add(label_for_pop_up);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(500, 10);
            MaximizeBox = false;
            MaximumSize = new Size(315, 100);
            MinimizeBox = false;
            MinimumSize = new Size(315, 47);
            Name = "Form3";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            TransparencyKey = Color.Yellow;
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_for_pop_up;
    }
}