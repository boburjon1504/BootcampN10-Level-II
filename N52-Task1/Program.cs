

using N52_Task1;
using N52_Task1.Extention;

var a = new Post
{
    Topic= new List<string>
    {
        "Nima gap",
        "Gap nima ekan"
    }
};
var b = new Post
{
    Topic = new List<string>
    {
        "Qale",
        "Hich gap"
    }
};

var c = a.Topic.ZipIntersectBy(b.Topic, post => post);

foreach (var (x,y) in c)
{
    Console.WriteLine($"{x} - {y}");
}