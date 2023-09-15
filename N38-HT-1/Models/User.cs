namespace N38_HT_1.Models;

public class User
{
    //id - guid, firstname, lastname, email address 
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }

    public User(Guid id, string firstName, string lastName, string emailAddress)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
    }
}
