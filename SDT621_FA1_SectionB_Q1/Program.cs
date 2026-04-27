using SDT621_FA1_SectionB_Q1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Emfuleni Municipality Service Desk ===");

        List<Resident> residents = new List<Resident>();
        UtilitiesManager manager = new UtilitiesManager();

        // 1. Add Residents
        Console.Write("How many residents? ");
        int resCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < resCount; i++)
        {
            Console.WriteLine($"\nResident {i + 1}:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            string acc = Console.ReadLine();

            Console.Write("Monthly Usage: ");
            double usage = double.Parse(Console.ReadLine());

            residents.Add(new Resident(name, address, acc, usage));
        }

        // 2. Add Service Requests
        Console.Write("\nHow many service requests? ");
        int reqCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < reqCount; i++)
        {
            Console.WriteLine($"\nRequest {i + 1}:");

            Console.Write("Select resident (1 to " + residents.Count + "): ");
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Request Type: ");
            string type = Console.ReadLine();

            Console.Write("Priority (1-5): ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Severity (1-10): ");
            int severity = int.Parse(Console.ReadLine());

            Console.Write("Estimated Hours: ");
            int hours = int.Parse(Console.ReadLine());

            ServiceRequest req = new ServiceRequest
            {
                Resident = residents[index],
                RequestType = type,
                PriorityLevel = priority,
                SeverityLevel = severity,
                EstimatedHours = hours
            };

            manager.AddRequest(req);
        }

        // 3. Display Queue
        manager.DisplayQueue();

        // 4 & 5. Process Requests
        Console.WriteLine("\n--- Processing Requests ---");
        while (true)
        {
            var req = manager.ProcessNext();
            if (req == null) break;

            Console.WriteLine("\n--- Service Report ---");
            Console.WriteLine($"Resident: {req.Resident.Name}");
            Console.WriteLine($"Request: {req.RequestType}");
            Console.WriteLine($"Urgency Score: {req.UrgencyScore}");
            Console.WriteLine($"Estimated Time: {req.EstimatedHours} hours");
        }

        Console.WriteLine("\nAll requests processed.");
    }
}