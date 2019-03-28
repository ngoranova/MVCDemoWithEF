using MvcDemo.Common.Models;
using MvcDemo.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class UserController : Controller
    {


        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //public ActionResult Index(int id)
        //{
        //    UsersModel usersModel = _userService.GetAllUserRegisteredForCourse(id);
        //    return View(usersModel);
        //}

        public async Task<ActionResult> Index(int id)
        {
            return View(await _userService.GetAllUserRegisteredForCourseAsync(id));
        }
    }
}