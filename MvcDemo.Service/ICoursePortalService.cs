using MvcDemo.Service.Common;
using MvcDemo.Common.Entities;
using System.Collections.Generic;
using MvcDemo.Common.Models;
using System.Threading.Tasks;

namespace MvcDemo.Service
{

    public interface ICoursePortalService : IEntityService<CoursePortal>
    {
        CoursePortal GetById(int Id);
        Task<CoursePortal> GetByIdAsync(int Id);
        CoursesModel GetAllCoursesModelPerPortalId(int portalId);
        Task<CoursesModel> GetAllCoursesModelPerPortalIdAsync(int portalId);
    }
}
