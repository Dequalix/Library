using Library.API.DTO;
using Library.API.Models;
using Library.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationController(IReservationRepository reservationRepository)
        {
            this._reservationRepository = reservationRepository;
        }

        [HttpGet("list")]
        public List<ReservationDTO> ReservationList()
        {
            return this._reservationRepository.List().Select(reservation => Mapper.ToReservationDto(reservation)).ToList();
        }

        [HttpGet("findreservationbyuser")]
        public List<ReservationDTO> FindReservationByUser(string user)
        {

            return this._reservationRepository.SearchOnUser(user).Select(reservation => Mapper.ToReservationDto(reservation)).ToList();
        }

        [HttpGet("findreservationbybook")]
        public List<ReservationDTO> FindReservationBook(string book)
        {
            return this._reservationRepository.SearchOnBook(book).Select(reservation => Mapper.ToReservationDto(reservation)).ToList();
        }

        [HttpPost("addreservation")]
        public void SaveReservation(List<ReservationDTO> reservationList)
        {
            reservationList.ForEach(reservation => this._reservationRepository.SaveReservation(Mapper.ToReservation(reservation)));
        }

        
    }

   
}
