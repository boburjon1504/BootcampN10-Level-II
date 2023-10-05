using OnlineMarket.Models;

namespace OnlineMarket.Services.Interfaces;

public interface IEntityService<T> where T : class
{
    ValueTask<IEnumerable<T>> GetAsync();
    ValueTask<T> GetByIdAsync(Guid id);
    ValueTask<T> CreateAsync(T user);
    ValueTask<T> UpdateAsync(T user);
    ValueTask<T> DeleteAsync(Guid id);
} 
