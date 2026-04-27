using System;
using System.Collections.Generic;
using System.Text;

namespace SDT621_FA1_SectionB_Q2
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge();
        }

        private int CalculateAge()
        {
            if (IDNumber.Length < 6) return 0;

            string yearStr = IDNumber.Substring(0, 2);
            string monthStr = IDNumber.Substring(2, 2);
            string dayStr = IDNumber.Substring(4, 2);

            if (!int.TryParse(yearStr, out int year) ||
                !int.TryParse(monthStr, out int month) ||
                !int.TryParse(dayStr, out int day))
                return 0;

            int currentYear = DateTime.Now.Year;
            int century = (year <= currentYear % 100) ? 2000 : 1900;
            int fullYear = century + year;

            DateTime birthDate = new DateTime(fullYear, month, day);
            int age = currentYear - fullYear;
            if (DateTime.Now < birthDate.AddYears(age)) age--;

            return age;
        }

        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return "Invalid ID: Must be exactly 13 digits.";

            if (!IDNumber.All(char.IsDigit))
                return "Invalid ID: Must contain numbers only.";

            if (Age < 0 || Age > 130)
                return "Invalid ID: Age calculated is not realistic.";

            return $"Valid ID. Citizen is {Age} years old.";
        }
    }
}
