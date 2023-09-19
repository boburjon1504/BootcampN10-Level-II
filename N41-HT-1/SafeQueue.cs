
namespace N41_HT_1;
public class SafeQueue<T> : List<T>
{
    public T Dequeue()
    {
        T deletedItem= default;
        lock(this){
            if (!IsEmpty())
            {
                deletedItem = this.Last();
                Remove(deletedItem);
            }
        }
        return deletedItem;
    }
    public void Enquee(T item)
    {
        lock (this)
        {
            Add(item);
        }
    }
    public T Peek()
    {
        lock (this)
        {
            if (IsEmpty())
                throw new ArgumentException("There is no elements yet");
        }
        return this.Last();
    }
    public bool IsEmpty() => Count == 0;
}
