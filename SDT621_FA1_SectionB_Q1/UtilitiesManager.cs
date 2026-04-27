using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SDT621_FA1_SectionB_Q1
{
    public class UtilitiesManager
    {
        public List<ServiceRequest> Requests = new List<ServiceRequest>();

        public void AddRequest(ServiceRequest request)
        {
            request.CalculateUrgency();
            Requests.Add(request);
        }

        public void DisplayQueue()
        {
            Console.WriteLine("\n--- Pending Requests ---");
            foreach (var r in Requests.OrderByDescending(r => r.UrgencyScore))
            {
                Console.WriteLine($"{r.RequestType} | Urgency: {r.UrgencyScore}");
            }
        }

        public ServiceRequest ProcessNext()
        {
            var next = Requests.OrderByDescending(r => r.UrgencyScore).FirstOrDefault();
            if (next != null)
            {
                Requests.Remove(next);
            }
            return next;
        }
    }
}
