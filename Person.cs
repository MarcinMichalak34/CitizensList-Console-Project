using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizensList
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PersonalIDNumber { get; set; }
        public string City { get; set; }

        public Person(string name, string lastName, string personalIDNumber, string city)
        {
            Name = name;
            LastName = lastName;
            PersonalIDNumber = personalIDNumber;
            City = city;
        }

        public static void PersonDataUpdate(Person citizen, string newName, string newLastName)
        {
            citizen.Name = newName;
            citizen.LastName = newLastName;
        }

        public static string PersonToString(Person citizen)
        {
            string text = $"City: {citizen.City} \n Name: {citizen.Name} \n Last Name: {citizen.LastName} \n Personal ID Number: {citizen.PersonalIDNumber}";
            return text;
        }
    }
}
