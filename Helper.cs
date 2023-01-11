using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CitizensList
{
    public class Helper
    {
        public static bool PersonalIDNumberVerification(string personalIDnumber)
        {
            if (personalIDnumber.Length != 11)
            {
                return false;
            }

            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += weights[i] * (personalIDnumber[i] - '0');
            }

            int checkDigit = 10 - (sum % 10);

            if (checkDigit == 10)
            {
                checkDigit = 0;
            }

            return personalIDnumber[10] - '0' == checkDigit;
        }

        public static bool CitizenExists(string PersonalIDnumber, List<Person> citizensList)
        {
            foreach (Person resident in citizensList)
            {
                if (resident.PersonalIDNumber == PersonalIDnumber)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
