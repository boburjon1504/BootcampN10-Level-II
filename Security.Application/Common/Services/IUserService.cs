

using Security.Domain.Dtos;
using Security.Domain.Entities;

namespace Security.Application.Common.Services;

public interface IUserService
{
    IQueryable<User> Get();
    ValueTask<User> GetByIdAsync(Guid id);
    ValueTask<User> CreateAsync(RegistrationDetails user);
    ValueTask<User> UpdateAsync(RegistrationDetails user);
    ValueTask<User> DeleteAsync(Guid id);
}
