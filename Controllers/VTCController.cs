using Microsoft.AspNetCore.Mvc;
using VTC.Models;
using VTC.packages;

namespace VTC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VTCController : Controller
    {
        private readonly PKG_Reservation _pkg_reservation;
        public VTCController(PKG_Reservation pkg_reservation )
        {
            _pkg_reservation = pkg_reservation;
            
        }

        [HttpPost("Book_Reservation")]
        public IActionResult Book_Reservation([FromBody] Reservation reservation)
        {
            try
            {
                _pkg_reservation.Book_Reservation(reservation);
                return Ok(new { message = "Reservation booked succesfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}
