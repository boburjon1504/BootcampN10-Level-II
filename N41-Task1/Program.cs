using System.Text;



/*
 * var placeholder = new StringBuilder();
            var isStartedToGather = false;
            Console.WriteLine(body);
            for (int i = 0; i < body.Length; i++)
            {
                if (body[i] == '{')
                {
                    i += 1;
                    placeholder = new StringBuilder();
                    placeholder.Append("{{");
                    isStartedToGather = true;
                }
                else if (body[i] == '}')
                {
                    i += 1;
                    placeholder.Append("}}");
                    isStartedToGather = false;
                    yield return placeholder.ToString();
                }
                else if (isStartedToGather)
                {
                    placeholder.Append(body[i]);
                }

            }
 */
var a = new A();
var b = a.GetPlaceholders("{{Nima gap}} ishlar yaxshimi {{Uydagilar}} yaxshimi");
b.ToList().ForEach(Console.WriteLine);
class A
{
    public IEnumerable<string> GetPlaceholders(string body)
    {
        var placeholder = new StringBuilder();
        var isStartedToGather = false;
        Console.WriteLine(body);
        for (int i = 0; i < body.Length; i++)
        {
            if (body[i] == '{')
            {
                i += 1;
                placeholder = new StringBuilder();
                placeholder.Append("{{");
                isStartedToGather = true;
            }
            else if (body[i] == '}')
            {
                i += 1;
                placeholder.Append("}}");
                isStartedToGather = false;
                yield return placeholder.ToString();
            }
            else if (isStartedToGather)
            {
                placeholder.Append(body[i]);
            }

        }
    }
}
//var a = GetPlaceholders("{{FirstName}} nima gap");
//a.ForEach(Console.WriteLine);
//static List<string> GetPlaceholders(string body)
//{
//    var placeholders = new List<string>();
//    var placeholder = new StringBuilder();
//    var isStartedToGather = false;
//    Console.WriteLine(body);
//    for (int i = 0; i < body.Length; i++)
//    {
//        if (body[i] == '{')
//        {
//            i += 1;
//            placeholder.Append("{{");
//            isStartedToGather= true;
//        }
//        else if (body[i] == '}')
//        {
//            i += 1;
//            placeholder.Append("}}");
//            placeholders.Add(placeholder.ToString());
//            placeholder = new StringBuilder();
//            isStartedToGather = false;
//        }
//        else if (isStartedToGather)
//        {
//            placeholder.Append(body[i]);
//        }
        
//    }
//    return placeholders;
//}