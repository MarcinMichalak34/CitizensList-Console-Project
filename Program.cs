using System;
using CitizensList;

List<Person> citizensList = new();

var fileName = "CitizenList.txt";

Console.Write("1. City: ");
var city = Console.ReadLine();
Console.Write("2. Name: ");
var name = Console.ReadLine();
Console.Write("3. Last Name: ");
var lastName = Console.ReadLine();
Console.Write("4. Personal ID Number: ");
var personalIDNumber = Console.ReadLine();