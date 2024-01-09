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
    public partial class NotificationForm : Form
    {
        public NotificationForm(Form owner, string text = "Lorem ipsum lorem ipsum")
        {
            
            InitializeComponent();
            this.label_for_pop_up.Text = text;
            this.Owner = owner;
            this.StartPosition = FormStartPosition.Manual;
            int xOffset = 500;
            int yOffset = 60;
            this.Location = new System.Drawing.Point(owner.Location.X + xOffset, owner.Location.Y + yOffset);
            if (owner is MainForm parentForm)
            {
                parentForm.FormMoved += ParentForm_ParentLocationChanged;
            }

        }
        private void ParentForm_ParentLocationChanged(object sender, EventArgs e)
        {
            if (this.Owner is MainForm parentForm)
            {
                int xOffset = 500;
                int yOffset = 60;
                this.Location = new System.Drawing.Point(parentForm.Location.X + xOffset, parentForm.Location.Y + yOffset);
            }
        }
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;      

            t1.Interval = 10;  
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();  
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
                t1.Stop();   
            else
                this.Opacity += 0.05;
        }

        System.Windows.Forms.Timer t2 = new System.Windows.Forms.Timer();
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.FormOwnerClosing)
                Close();
            else
            {
                e.Cancel = true;
                t2.Interval = 50;
                t2.Tick += new EventHandler(fadeOut);
                t2.Start();

                if (Opacity == 0)
                    e.Cancel = false;
            }
            

        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t2.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
