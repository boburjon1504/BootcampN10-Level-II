using System.Collections;

namespace N39_Task1;

public class N10Collection : IEnumerable<Student>
{
    private List<Student> _students;

    public N10Collection()
    {
        _students = new List<Student>();
    }

    public IEnumerator<Student> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
