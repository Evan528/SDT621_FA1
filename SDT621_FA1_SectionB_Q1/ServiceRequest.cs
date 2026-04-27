using System;
using System.Collections.Generic;
using System.Text;

namespace SDT621_FA1_SectionB_Q1
{
    public class ServiceRequest
    {
        public Resident Resident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; } 
        public int SeverityLevel { get; set; } 
        public int EstimatedHours { get; set; }

        public int UrgencyScore { get; set; }

        public void CalculateUrgency()
        {
            UrgencyScore = PriorityLevel * SeverityLevel;
        }
    }
}
