using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        AddressBook addressBook = new AddressBook();

        char choice;

        do
        {
            addressBook.AddContact();

            Console.Write("Do you want to add another contact? (y/n): ");
            choice = Convert.ToChar(Console.ReadLine());

        } while (choice == 'y' || choice == 'Y');

        Console.WriteLine("\nAll Contacts:\n");

        addressBook.DisplayContacts();
    }
}