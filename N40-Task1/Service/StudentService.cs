using N40_Task1.Data.Config;
using N40_Task1.Interface;
using N40_Task1.Models;
namespace N40_Task1.Service;
public class StudentService : IStudentService
{
    private readonly List<Student> _students;
    public StudentService() => _students = new List<Student>();
    public Student Create(Student student)
    {
        _students.Add(student);
        return student;
    }

    public bool Delete(Student student)
    {
        var deletedUser = _students.FirstOrDefault(stud => stud.Id == student.Id);
        if (deletedUser is null)
            return false;
        _students.Remove(deletedUser);
        return true;
    }

    public IEnumerable<Student> GetAll()
    {
        var source = File.ReadAllText(Constants.SUDENTS_DB);
        if (source.Length == 0)
            return _students;
        return _students;
    }

    public Student GetById(Student student)
    {
        return _students.FirstOrDefault(stud => stud.Id == student.Id);
    }

    public Student Update(Student student)
    {
        var updatedUser = _students.FirstOrDefault(stud => stud.Id == student.Id);
        updatedUser = student;
        return updatedUser;
    }
}