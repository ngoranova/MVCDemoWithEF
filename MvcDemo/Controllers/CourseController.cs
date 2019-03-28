using MvcDemo.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class CourseController : Controller
    {

        ICoursePortalService _courcePortalService;
        public CourseController(ICoursePortalService courcePortalService)
        {
            _courcePortalService = courcePortalService;
        }
       
        //public ActionResult Index(int id)
        //{
        //    CoursesModel courseModel = _courcePortalService.GetAllCoursesModelPerPortalId(id);
        //    return View(courseModel);
        //}

        public async Task<ActionResult> Index(int id)
        {
          
            return View(await _courcePortalService.GetAllCoursesModelPerPortalIdAsync(id));
        }

    }
}