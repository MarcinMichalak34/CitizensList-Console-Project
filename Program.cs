using CitizensList;
using System;

var fileName = "CitizenList.txt";

{
    do
    {
        Console.Write("1. City: ");
        var city =  Console.ReadLine();
        Console.Write("2. Name: "); 
        var name = Console.ReadLine();
        Console.Write("3. Last Name: ");
        var lastName = Console.ReadLine();
        Console.Write("4. Personal ID Number: ");
        var personalIDNumber = Console.ReadLine();
        if (!Helper.PersonalIDNumberVerification(personalIDNumber))
        {
            Console.WriteLine("Wrong Personal ID Number, please try again.");
        }
        else
        {
            var currentCitizen = Person.CitizensList.FirstOrDefault(x => x.PersonalIDNumber == personalIDNumber);
            if (currentCitizen != null)
            {
                Console.WriteLine("Citizen exists, overwriting data.");
                Person.PersonDataUpdate(currentCitizen, name, lastName);
            }
            else
            {
                var citizen = new Person(name, lastName, personalIDNumber, city);
                Person.CitizensList.Add(citizen);
                Console.WriteLine("New citizen add to database.");
                Console.WriteLine("If you want add another citizen, click ENTER. If you want exit program, click ESC.");
            }
            using (StreamWriter sw = new(fileName))
            { 
                foreach (var citizen in Person.CitizensList)
                {
                    sw.WriteLine(Person.PersonToString(citizen));
                }
            }
        }

    } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
}

