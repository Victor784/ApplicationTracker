using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppTrackVSProj
{
    public class SentApplication
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string PositionName { get; set; }
        public string Company { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }

        public SentApplication(string id, string positionName, string company, string date, string status, string details)
        {
            Id = id;
            PositionName = positionName;
            Company = company;
            Date = date;
            Status = status;
            Details = details;
        }

        public SentApplication()
        {
            Id = "";
            PositionName = "";
            Company = "";
            Date = "";
            Status = "";
            Details = "";
        }
    }
}
