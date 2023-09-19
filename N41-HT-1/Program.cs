
using N41_HT_1;

var queue = new SafeQueue<int>();
try
{
    var tasks = new List<Task>
    {
        new(()=>queue.Enquee(10)),
        new(()=>queue.Dequeue()),
        new(()=>queue.Dequeue()),
        //new(()=>queue.Enquee(10)),
        new(()=>queue.Enquee(10)),
    };

    Parallel.ForEach(tasks, task => task.Start());
    await Task.WhenAll(tasks);
    queue.ForEach(Console.WriteLine);
}catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}