public abstract record Person(string FirstName,string LastName);
public record Strudent(string FirstName,string LastName) : Person(FirstName,LastName);
