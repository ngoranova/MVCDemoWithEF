using MvcDemo.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class ClientController : Controller
    {

        IPortalService _portalService;
       

        public ClientController(IPortalService portalService)
        {
            _portalService = portalService;
          
        }
               
        public async Task<ActionResult> Index()
        {

            return View(await _portalService.GetAllClientsModelAsync());
        }

        
    }
}

