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
    public void EditContact(string firstName)
    {
        foreach (Contact person in contacts)
        {
            if (person.FirstName == firstName)
            {
                Console.Write("Enter New Address: ");
                person.Address = Console.ReadLine();

                Console.Write("Enter New City: ");
                person.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                person.State = Console.ReadLine();

                Console.Write("Enter New Zip: ");
                person.Zip = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Phone Number: ");
                person.PhoneNumber = Console.ReadLine();

                Console.Write("Enter New Email: ");
                person.Email = Console.ReadLine();

                Console.WriteLine("Contact Updated Successfully");
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
            Console.WriteLine("Contact Deleted Successfully");
        }
        else
        {
            Console.WriteLine("Contact Not Found");
        }
    }
}