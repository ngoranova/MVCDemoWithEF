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
    public class PortalService : EntityService<Portal>, IPortalService
    {
        
        public PortalService(IContext context)
            : base(context)
        {
            _context = context;
            _dbset = _context.Set<Portal>();
        }

        public Portal GetById(int Id)
        {
            return _dbset.FirstOrDefault(x => x.Id == Id);
        }

        public async Task<Portal> GetByIdAsync(int Id)
        {
            return await (_dbset.FirstOrDefaultAsync(x => x.Id == Id));
        }

        public override IEnumerable<Portal> GetAll()
        {
            return _context.Portals.ToList();
        }

        public ClientsModel GetAllClientsModel()
        {
            IEnumerable<Portal> portalList = _context.Portals.ToList();
            IEnumerable<PortalModel> clients = Mapper.Map<IEnumerable<PortalModel>>(portalList);
            return new ClientsModel() { Clients = clients };
        }

        public async Task<ClientsModel> GetAllClientsModelAsync()
        {
            IEnumerable<Portal> portalList = await( _context.Portals.ToListAsync());
            IEnumerable<PortalModel> clients = Mapper.Map<IEnumerable<PortalModel>>(portalList);
            return new ClientsModel() { Clients = clients };
        }
    }
}


