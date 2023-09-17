
using N40_Task1.Models;

namespace N40_Task1.Interface;
public interface IStudentService
{
    Student Create(Student student);
    Student Update(Student student);
    bool Delete(Student student);
    Student GetById(Student student);
    IEnumerable<Student> GetAll();


}
