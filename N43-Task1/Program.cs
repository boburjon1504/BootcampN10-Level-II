

using System.Text;

var mutex = new Mutex(false,"Template");
await Task.Run(() =>
{
    mutex.WaitOne();
    var fileStream = File.Open(@"D:\BootcampN10-Level-II\BootcampN10-Level-II\N43-Task1\bin\Debug\net7.0\temp.txt", FileMode.Open, FileAccess.ReadWrite);
    fileStream.Write(Encoding.UTF8.GetBytes("Hello {{UserName}}"));
    Thread.Sleep(10000);
    fileStream.Close();
    mutex.ReleaseMutex();
});
