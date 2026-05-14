using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        Dictionary<string, AddressBook> addressBooks =
            new Dictionary<string, AddressBook>();

        Console.Write("Enter Address Book Name: ");
        string bookName = Console.ReadLine();

        AddressBook addressBook = new AddressBook();

        char choice;

        do
        {
            addressBook.AddContact();

            Console.Write("Add More Contact? (y/n): ");
            choice = Convert.ToChar(Console.ReadLine());

        } while (choice == 'y' || choice == 'Y');

        addressBooks.Add(bookName, addressBook);

        Console.WriteLine("\nContacts Added Successfully\n");

        addressBook.DisplayContacts();

        Console.Write("\nEnter City to Search: ");
        string city = Console.ReadLine();

        addressBook.SearchByCity(city);

        Console.Write("\nEnter City to Count Contacts: ");
        string cityName = Console.ReadLine();

        addressBook.CountByCity(cityName);
    }
}