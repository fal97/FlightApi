using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace FlightApi.Controllers
{
    public class FlightController : ApiController
    {
        private IFlightService _IFileService;

        public FlightController(IFlightService service)
        {
            _IFileService = service;
        }

        [HttpGet]
        public List<FlightEntity> GetFlightEntities()
        {
            List<FlightEntity> flights = new List<FlightEntity>();

            flights = _IFileService.GetAll();

            return flights;

        }



        [HttpPost]
        public void PostFlightEntities(FlightEntity flight)
        {
            _IFileService.AddFlightEntity(flight);

        }
    }
}
