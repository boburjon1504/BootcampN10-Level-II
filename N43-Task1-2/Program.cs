
var mutex = new Mutex(false, "Template");
await Task.Run(() =>
{
    mutex.WaitOne();
    var template = File.ReadAllText(@"D:\BootcampN10-Level-II\BootcampN10-Level-II\N43-Task1\bin\Debug\net7.0\temp.txt");
    template = template.Replace("{{UserName}}", "Assa");
    File.WriteAllText(@"D:\BootcampN10-Level-II\BootcampN10-Level-II\N43-Task1\bin\Debug\net7.0\temp.txt", template);
    mutex.ReleaseMutex();
});