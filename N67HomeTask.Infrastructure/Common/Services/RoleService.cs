using N67HomeTask.Application.Common.Services;
using N67HomeTask.Persistence.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N67HomeTask.Infrastructure.Common.Services
{
    public class RoleService : IRoleService
    {
        private readonly AppDataContext _dbContext;

        public RoleService(AppDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Guid> GetStudents()
        {
            return _dbContext.Roles.ToList()
                .Where(role => role.Name.Contains("stud", StringComparison.OrdinalIgnoreCase))
                .Select(role=>role.UserId);
        }

        public IEnumerable<Guid> GetTeachers()
        {
            return _dbContext.Roles.ToList()
                .Where(role => role.Name.Contains("teach", StringComparison.OrdinalIgnoreCase))
                .Select(role => role.UserId);
        }
    }
}
