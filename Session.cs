using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultant_Plus
{
    public class Session
    {
        public string Date;
        public double TotalHours;
        public double HourlyRate;
        public string Comment;

        public Session(string date, double hourlyRate, string comment, double totalHours)
        {
            Date = date;
            HourlyRate = hourlyRate;
            Comment = comment;
            TotalHours = totalHours;
        }

        public Session()
        {
        }
    }
}
