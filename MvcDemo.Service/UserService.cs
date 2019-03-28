using AutoMapper;
using MvcDemo.Common.Entities;
using MvcDemo.Common.Models;
using MvcDemo.DataAccess;
using MvcDemo.Service.Common;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MvcDemo.Service
{
    public class UserService : EntityService<User>, IUserService
    {
        public UserService(IContext context)
            : base(context)
        {
            _context = context;
            _dbset = _context.Set<User>();
        }

        public User GetById(int Id)
        {
            return _dbset.FirstOrDefault(x => x.Id == Id);
        }

        public async Task<User> GetByIdAsync(int Id)
        {
            return await (_dbset.FirstOrDefaultAsync(x => x.Id == Id));
        }

        public override IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        
        public UsersModel GetAllUserRegisteredForCourse(int courseId) {
            var results = from r in _context.Registrations
                          join u in _context.Users on r.UserId equals u.Id
                          where (r.CoursePortalId == courseId)
                          select new UserModel
                          {
                              Id = u.Id,
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              RegistrationTime = r.RegistrationTime
                          };

            return new UsersModel()
            {
                Users = results.ToList(), 
                Course = Mapper.Map<CoursePortalModel>(_context.CoursePortals.FirstOrDefault(x=>x.Id == courseId))
            };             

        }


        public async Task<UsersModel> GetAllUserRegisteredForCourseAsync(int courseId)
        {
            var results = from r in _context.Registrations
                          join u in _context.Users on r.UserId equals u.Id
                          where (r.CoursePortalId == courseId)
                          select new UserModel
                          {
                              Id = u.Id,
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              RegistrationTime = r.RegistrationTime
                          };

            return new UsersModel()
            {
                Users = await results.ToListAsync(),
                Course = Mapper.Map<CoursePortalModel>(await _context.CoursePortals.FirstOrDefaultAsync(x => x.Id == courseId))
            };

        }

    }
}


