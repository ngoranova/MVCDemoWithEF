using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using MvcDemo.Common.Entities;
using MvcDemo.Service.Common;
using MvcDemo.DataAccess;
using MvcDemo.Common.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MvcDemo.Service
{
    public class CoursePortalService:EntityService<CoursePortal>, ICoursePortalService
    {
        
        public CoursePortalService(IContext context)
            : base(context)
        {
            _context = context;
            _dbset = _context.Set<CoursePortal>();
        }

        public CoursePortal GetById(int Id)
        {
            return _dbset.FirstOrDefault(x => x.Id == Id);
        }
        public async Task<CoursePortal> GetByIdAsync(int Id)
        {
            return await (_dbset.FirstOrDefaultAsync(x => x.Id == Id));
        }

        public override IEnumerable<CoursePortal> GetAll()
        {
            return _context.CoursePortals.ToList();
        }

        public CoursesModel GetAllCoursesModelPerPortalId(int portalId) {
            IEnumerable<CoursePortal> coursePortalList = _context.CoursePortals.Where(x => x.PortalId == portalId).ToList();
            IEnumerable<CoursePortalModel> courses = Mapper.Map<IEnumerable<CoursePortalModel>>(coursePortalList);

            return new CoursesModel() {Courses=courses,
                                       Client = Mapper.Map<PortalModel>( _context.Portals.FirstOrDefault(x=>x.Id == portalId))};

        }


        public async Task<CoursesModel> GetAllCoursesModelPerPortalIdAsync(int portalId) {
            IEnumerable<CoursePortal> coursePortalList = await (_context.CoursePortals.Where(x => x.PortalId == portalId).ToListAsync());
            IEnumerable<CoursePortalModel> courses = Mapper.Map<IEnumerable<CoursePortalModel>>(coursePortalList);

            return new CoursesModel()
            {
                Courses = courses,
                Client = Mapper.Map<PortalModel>(await _context.Portals.FirstOrDefaultAsync(x => x.Id == portalId))
            };


        }

    }
}


