using Bogus;
using N39_Task1;

int idSeed = 1;
Faker<Student> Students = new Faker<Student>()
    .RuleFor(student => student.Id, id => idSeed)
    .RuleFor(student => student.FirstName, name => name.Person.FirstName)
    .RuleFor(student => student.LastName, name => name.Person.LastName)
    .RuleFor(student => student.Description, description => description.Lorem.Paragraph(10));
var a = Students.Generate();

try
{
    var b = 5;
    var c = 0;

    Console.WriteLine(b/c);
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
