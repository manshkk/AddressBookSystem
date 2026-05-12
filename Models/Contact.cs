public class Contact
{
    public string FirstName;
    public string LastName;
    public string Address;
    public string City;
    public string State;
    public int Zip;
    public string PhoneNumber;
    public string Email;

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}\n" +
               $"Address: {Address}\n" +
               $"City: {City}\n" +
               $"State: {State}\n" +
               $"Zip: {Zip}\n" +
               $"Phone: {PhoneNumber}\n" +
               $"Email: {Email}";
    }
}