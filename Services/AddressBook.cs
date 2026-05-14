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

        foreach (Contact contact in contacts)
        {
            if (contact.FirstName == person.FirstName)
            {
                Console.WriteLine("Duplicate Contact Found");
                return;
            }
        }

        contacts.Add(person);

        Console.WriteLine("\nContact Added Successfully\n");
    }

    public void DisplayContacts()
    {
        foreach (Contact person in contacts)
        {
            Console.WriteLine(person);
            Console.WriteLine("--------------------------");
        }
    }

    public void EditContact(string firstName)
    {
        foreach (Contact person in contacts)
        {
            if (person.FirstName == firstName)
            {
                Console.Write("Enter New City: ");
                person.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                person.State = Console.ReadLine();

                Console.WriteLine("Contact Updated");
                return;
            }
        }

        Console.WriteLine("Contact Not Found");
    }

    public void DeleteContact(string firstName)
    {
        Contact deleteContact = null;

        foreach (Contact person in contacts)
        {
            if (person.FirstName == firstName)
            {
                deleteContact = person;
                break;
            }
        }

        if (deleteContact != null)
        {
            contacts.Remove(deleteContact);
            Console.WriteLine("Contact Deleted");
        }
        else
        {
            Console.WriteLine("Contact Not Found");
        }
    }
    public void SearchByCity(string city)
    {
        bool found = false;

        foreach (Contact person in contacts)
        {
            if (person.City == city)
            {
                Console.WriteLine(person);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No Contact Found");
        }
    }
    public void SearchByState(string state)
    {
        bool found = false;

        foreach (Contact person in contacts)
        {
            if (person.State == state)
            {
                Console.WriteLine(person);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No Contact Found");
        }
    }
    public void ViewByCity()
    {
        Dictionary<string, List<Contact>> cityDictionary =
            new Dictionary<string, List<Contact>>();

        foreach (Contact person in contacts)
        {
            if (!cityDictionary.ContainsKey(person.City))
            {
                cityDictionary[person.City] =
                    new List<Contact>();
            }

            cityDictionary[person.City].Add(person);
        }

        foreach (var city in cityDictionary)
        {
            Console.WriteLine("\nCity: " + city.Key);

            foreach (Contact person in city.Value)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    public void CountByCity(string city)
    {
        int count = 0;

        foreach (Contact person in contacts)
        {
            if (person.City == city)
            {
                count++;
            }
        }

        Console.WriteLine("Total Contacts in " +
                          city + " : " + count);
    }
}