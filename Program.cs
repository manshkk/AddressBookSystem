using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        AddressBook addressBook = new AddressBook();

        addressBook.AddContact();

        Console.Write("Enter First Name to Delete: ");
        string name = Console.ReadLine();

        addressBook.DeleteContact(name);
    }
}