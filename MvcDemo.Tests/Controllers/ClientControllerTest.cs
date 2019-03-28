using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using MvcDemo.Controllers;
using MvcDemo.Service;
using MvcDemo.Common.Models;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace MvcDemo.Tests.Controllers
{
    [TestClass]
    public class ClientControllerTest
    {
        private Mock<IPortalService> _portalServiceMock;
        ClientController objController;
        IEnumerable<PortalModel> clients;

        [TestInitialize]
        public void Initialize()
        {

            _portalServiceMock = new Mock<IPortalService>();
            objController = new ClientController(_portalServiceMock.Object);
            clients = new List<PortalModel>() {
                                               new PortalModel() { Id = 1, PortalName = "Client one" },
                                               new PortalModel() { Id = 2, PortalName = "Client two" },
                                               new PortalModel() { Id = 3, PortalName = "Client three" }
                                              };
 
        }


        [TestMethod]
        public async Task Index()
        {
            
            //Arrange
            _portalServiceMock.Setup(x => x.GetAllClientsModelAsync()).ReturnsAsync(new ClientsModel() { Clients = clients });

            //Act
            var result = await objController.Index();
            Assert.IsNotNull(result);
            var model = (ClientsModel)((ViewResult)result).Model as ClientsModel;

            var modelClients = model.Clients.ToList();
            
            
            //Assert
            Assert.AreEqual(modelClients.Count, 3);
            Assert.AreEqual("Client one", modelClients[0].PortalName);
            Assert.AreEqual("Client two", modelClients[1].PortalName);
            Assert.AreEqual("Client three", modelClients[2].PortalName);
            Assert.IsNotNull(model);

        }

        


    }
}
