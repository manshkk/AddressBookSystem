using System;
using System.Collections.Generic;

public class AddressBook
{
    List<Contact> contacts = new List<Contact>();

    public void AddContact()
    {
        Contact person = new Contact();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();

        Console.Write("Enter Address: ");
        person.Address = Console.ReadLine();

        Console.Write("Enter City: ");
        person.City = Console.ReadLine();

        Console.Write("Enter State: ");
        person.State = Console.ReadLine();

        Console.Write("Enter Zip: ");
        person.Zip = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Phone Number: ");
        person.PhoneNumber = Console.ReadLine();

        Console.Write("Enter Email: ");
        person.Email = Console.ReadLine();

        contacts.Add(person);

        Console.WriteLine("Contact Added Successfully");
    }
}