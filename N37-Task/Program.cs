//var student = new Strudent("bobur", "joraboyev");
//student.Deconstruct(out string firstName, out string lastName);
//Console.WriteLine(firstName);
//public abstract record Person(string FirstName,string LastName);
//public record Strudent(string FirstName,string LastName) : Person(FirstName,LastName);


//Console.WriteLine(Console.ReadKey().KeyChar);
var a = "";

Console.Write("Enter your password: ");
var password = "";
var key = Console.ReadKey(true);
while (key.Key != ConsoleKey.Enter)
{
    password += key;
    key = Console.ReadKey(true);
}
var password2 = "";
Console.WriteLine();
Console.Write("ENter to check: ");
var key2 = Console.ReadKey(true);
while (key2.Key != ConsoleKey.Enter)
{
    password2 += key2;
    key2 = Console.ReadKey(true);
}
Console.WriteLine(password==password2);