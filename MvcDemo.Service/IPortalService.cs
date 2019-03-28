using MvcDemo.Service.Common;
using MvcDemo.Common.Entities;
using MvcDemo.Common.Models;
using System.Threading.Tasks;

namespace MvcDemo.Service
{

    public interface IPortalService : IEntityService<Portal>
    {
        Portal GetById(int Id);
        Task<Portal> GetByIdAsync(int Id);
        ClientsModel GetAllClientsModel();
        Task<ClientsModel> GetAllClientsModelAsync();
    }
}
