namespace ToDoList.Services.Interfaces;

public interface IEntityBaseService<T>
{
    IQueryable<T> Get();
    ValueTask<T> GetByIdAsync(Guid id);
    ValueTask<T> CreateAsync(T entity);
    ValueTask<T> UpdateAsync(T entity);
    ValueTask<T> DeleteAsync(Guid id);
    
}
