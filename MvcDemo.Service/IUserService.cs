using MvcDemo.Service.Common;
using MvcDemo.Common.Entities;
using System.Collections.Generic;
using MvcDemo.Common.Models;
using System.Threading.Tasks;

namespace MvcDemo.Service
{

    public interface IUserService : IEntityService<User>
    {
        User GetById(int Id);
        Task<User> GetByIdAsync(int Id);
        UsersModel GetAllUserRegisteredForCourse(int courseId);
        Task<UsersModel> GetAllUserRegisteredForCourseAsync(int courseId);
    }
}
