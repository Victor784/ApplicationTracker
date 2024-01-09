using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AppTrackVSProj
{
    public class NotificationManager
    {
        private readonly Form mainForm;
        System.Timers.Timer? tenMinutesTimer;
        private readonly List<String> funFacts;
        public NotificationManager(Form form) 
        {     
            mainForm = form;
            tenMinutesTimer = new System.Timers.Timer(600000);
            tenMinutesTimer.Elapsed += OnTimedEvent;
            tenMinutesTimer.AutoReset = true;
            tenMinutesTimer.Enabled = true;
            funFacts = new List<string>{"Resumes were first used in 1482.",
            "The shortest job ever lasted 2 hours.",
            "A 6-second glance decides a resume's fate.",
            "LinkedIn profiles with photos get more views.",
            "Your email address influences hiring decisions.",
            "The average job search takes 43 days.",
            "Job interviews existed in ancient China.",
            "Recruiters spend 7 seconds on your resume.",
            "References were once written on tombstones.",
            "Hobbies on resumes can boost chances.",
            "The first job board was a physical board.",
            "The word 'resume' means summary in French.",
            "Social media affects hiring decisions.",
            "The first online job board was launched in 1992.",
            "Networking increases job opportunities.",
            "Recruiters check your online presence.",
            "Smiling in interviews builds rapport.",
            "The first job advertisement was in 1650.",
            "Recruiters prefer specific skills on resumes.",
            "The concept of cover letters dates to 1950s.",
            "Most hiring managers use Applicant Tracking Systems.",
            "Interviews can improve brain function.",
            "Remote work existed in the 1970s.",
            "Employers check social media for red flags.",
            "Video interviews became popular in 2000s.",
            "Thank-you emails impact hiring decisions.",
            "Soft skills are as vital as technical skills.",
            "LinkedIn profiles with summaries get noticed.",
            "Resumes should be tailored for each job.",
            "Unusual fonts on resumes can be risky.",
            "Internships increase job prospects.",
            "LinkedIn endorsements influence recruiters.",
            "Work anniversaries boost job satisfaction.",
            "The first recorded job interview was in 1921.",
            "Employers value lifelong learning.",
            "Career change is common in the 21st century.",
            "Positive body language enhances interviews.",
            "Flexible work schedules improve productivity.",
            "Recruiters prioritize relevant experience.",
            "The world's first headhunter was in 1878.",
            "The concept of a two-week notice began in 1940s.",
            "Mentorship accelerates career growth.",
            "Tattoos can influence hiring decisions.",
            "Networking events can lead to unexpected opportunities.",
            "The first job interview question is often 'Tell me about yourself.'"};
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //add here what you want to happen once every 10 minutes
            Random rnd = new Random();
            int r = rnd.Next(this.funFacts.Count());
            createNotification(funFacts[r]);     
        }
        public void createNotification(string text)
        {
            NotificationForm notification = new NotificationForm(this.mainForm, text);
            notification.Show();
            System.Timers.Timer timer = new System.Timers.Timer(3000);
            timer.AutoReset = false;
            timer.Elapsed += (sender, e) => CloseNotification(notification, timer);
            
            timer.Start();
        }
        private void CloseNotification(NotificationForm notificationForm, System.Timers.Timer timer)
        {
            if (notificationForm.InvokeRequired)
            {
                notificationForm.Invoke(new Action(() => CloseNotification(notificationForm, timer)));
            }
            else
            {
                notificationForm.Close();
                timer.Stop();
            }
        }
    }
}
