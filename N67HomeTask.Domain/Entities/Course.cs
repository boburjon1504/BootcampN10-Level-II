namespace N67HomeTask.Domain.Entities;

public class Course
{
    public Guid Id { get; set; }
    public Guid TeacherId { get; set; }
    public string Name { get; set; } = default!; 
    public int StudentsCount { get; set; }
}
