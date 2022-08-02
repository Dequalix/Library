using Library.API.DTO;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IServices _services;

        public ReservationController(IServices services)
        {
            _services = services;
        }

        [HttpGet("list")]
        public List<ReservationDTO> List()
        {
            return _services.ReservationList();
        }

        [HttpGet("find")]
        public List<ReservationDTO> Find(string search)
        {
            return _services.FindReservation(search);
        }

        [HttpPost("addreservation")]
        public void SaveReservation(List<ReservationDTO> reservationList)
        {
            _services.SaveReservation(reservationList);
        }
        
    }
}
