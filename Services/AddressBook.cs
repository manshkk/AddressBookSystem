using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class AddressBook
{
    List<Contact> contacts = new List<Contact>();

    // UC2
    public void AddContact()
    {
        Contact person = new Contact();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine()!;

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine()!;

        Console.Write("Enter Address: ");
        person.Address = Console.ReadLine()!;

        Console.Write("Enter City: ");
        person.City = Console.ReadLine()!;

        Console.Write("Enter State: ");
        person.State = Console.ReadLine()!;

        Console.Write("Enter Zip: ");
        person.Zip = Convert.ToInt32(Console.ReadLine()!);

        Console.Write("Enter Phone Number: ");
        person.PhoneNumber = Console.ReadLine()!;

        Console.Write("Enter Email: ");
        person.Email = Console.ReadLine()!;

        // UC7 Duplicate Check
        foreach (Contact contact in contacts)
        {
            if (contact.FirstName == person.FirstName)
            {
                Console.WriteLine("Duplicate Contact Found");
                return;
            }
        }

        contacts.Add(person);

        Console.WriteLine("Contact Added Successfully");
    }

    // UC5
    public void DisplayContacts()
    {
        foreach (Contact person in contacts)
        {
            Console.WriteLine(person);
            Console.WriteLine("----------------------");
        }
    }

    // UC3
    public void EditContact(string firstName)
    {
        foreach (Contact person in contacts)
        {
            if (person.FirstName == firstName)
            {
                Console.Write("Enter New Address: ");
                person.Address = Console.ReadLine()!;

                Console.Write("Enter New City: ");
                person.City = Console.ReadLine()!;

                Console.Write("Enter New State: ");
                person.State = Console.ReadLine()!;

                Console.Write("Enter New Zip: ");
                person.Zip = Convert.ToInt32(Console.ReadLine()!);

                Console.Write("Enter New Phone Number: ");
                person.PhoneNumber = Console.ReadLine()!;

                Console.Write("Enter New Email: ");
                person.Email = Console.ReadLine()!;

                Console.WriteLine("Contact Updated Successfully");
                return;
            }
        }

        Console.WriteLine("Contact Not Found");
    }

    // UC4
    public void DeleteContact(string firstName)
    {
        Contact? deleteContact = null;

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
            Console.WriteLine("Contact Deleted Successfully");
        }
        else
        {
            Console.WriteLine("Contact Not Found");
        }
    }

    // UC8
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

    // UC8
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

    // UC9
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

    // UC10
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

    // UC11
    public void SortByName()
    {
        contacts.Sort(delegate (Contact c1, Contact c2)
        {
            return c1.FirstName.CompareTo(c2.FirstName);
        });

        Console.WriteLine("\nSorted By Name:\n");

        foreach (Contact person in contacts)
        {
            Console.WriteLine(person);
        }
    }

    // UC12
    public void SortByCity()
    {
        contacts.Sort(delegate (Contact c1, Contact c2)
        {
            return c1.City.CompareTo(c2.City);
        });

        Console.WriteLine("\nSorted By City:\n");

        foreach (Contact person in contacts)
        {
            Console.WriteLine(person);
        }
    }

    // UC12
    public void SortByState()
    {
        contacts.Sort(delegate (Contact c1, Contact c2)
        {
            return c1.State.CompareTo(c2.State);
        });

        Console.WriteLine("\nSorted By State:\n");

        foreach (Contact person in contacts)
        {
            Console.WriteLine(person);
        }
    }

    // UC12
    public void SortByZip()
    {
        contacts.Sort(delegate (Contact c1, Contact c2)
        {
            return c1.Zip.CompareTo(c2.Zip);
        });

        Console.WriteLine("\nSorted By Zip:\n");

        foreach (Contact person in contacts)
        {
            Console.WriteLine(person);
        }
    }

    // UC13
    public void WriteToFile()
    {
        string path =
        @"D:\Maatrum training\AddressBookSystem\Data\addressbook.txt";

        StreamWriter writer = new StreamWriter(path);

        foreach (Contact person in contacts)
        {
            writer.WriteLine(person);
            writer.WriteLine("----------------------");
        }

        writer.Close();

        Console.WriteLine("Data Written To TXT File");
    }

    // UC13
    public void ReadFromFile()
    {
        string path =
        @"D:\Maatrum training\AddressBookSystem\Data\addressbook.txt";

        StreamReader reader = new StreamReader(path);

        string data = reader.ReadToEnd();

        Console.WriteLine(data);

        reader.Close();
    }

    // UC14
    public void WriteToCSV()
    {
        string path =
        @"D:\Maatrum training\AddressBookSystem\Data\addressbook.csv";

        StreamWriter writer = new StreamWriter(path);

        writer.WriteLine("FirstName,LastName,City,State");

        foreach (Contact person in contacts)
        {
            writer.WriteLine(
                person.FirstName + "," +
                person.LastName + "," +
                person.City + "," +
                person.State);
        }

        writer.Close();

        Console.WriteLine("CSV File Created");
    }

    // UC15
    public void WriteToJSON()
    {
        string path =
        @"D:\Maatrum training\AddressBookSystem\Data\addressbook.json";

        string jsonData =
            JsonSerializer.Serialize(contacts);

        File.WriteAllText(path, jsonData);

        Console.WriteLine("JSON File Created");
    }

    // UC15
    public void ReadFromJSON()
    {
        string path =
        @"D:\Maatrum training\AddressBookSystem\Data\addressbook.json";

        string jsonData =
            File.ReadAllText(path);

        Console.WriteLine(jsonData);
    }

    public void AddContactForTest(Contact person)
    {
        foreach (Contact contact in contacts)
        {
            if (contact.FirstName == person.FirstName)
            {
                return;
            }
        }

        contacts.Add(person);
    }

    public int GetContactCount()
    {
        return contacts.Count;
    }

    public bool SearchContact(string firstName)
    {
        foreach (Contact person in contacts)
        {
            if (person.FirstName == firstName)
            {
                return true;
            }
        }

        return false;
    }
}