using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTrackVSProj
{
    public partial class AddApplicationForm : Form
    {
        public event EventHandler ButtonSaveClicked;

        public static string position = "";
        public static string company = "";
        public static string date = "";
        public static string status = "";
        public static string details = "";
        public AddApplicationForm()
        {
            InitializeComponent();
        }

        private void lbCompany_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            position = positionTextBox.Text;
            company = companyTestBox.Text;
            date = dateTextBox.Text;
            status = "Application sent";
            details = detailsTextBox.Text;
            OnSaveRequest(EventArgs.Empty);
            this.Close();
        }
        protected virtual void OnSaveRequest(EventArgs e)
        {
            EventHandler eh = ButtonSaveClicked;
            if (eh != null)
                eh(this, e);
        }
        private void Form2_Load(object sender, System.EventArgs e)
        {
            position = "";
            company = "";
            date = "";
            status = "";
            details = "";
        }
    }
}
