using Application.Features.Bookings.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _6B.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingsController : ControllerBase
    {

        private readonly ILogger<BookingsController> _logger;
        private IBookingService _bookingService;

        public BookingsController(ILogger<BookingsController> logger, IBookingService bookingService)
        {
            _logger = logger;
            _bookingService = bookingService;
        }

        [HttpPost("AddBooking")]
        public async Task<bool> AddBooking(Booking booking)
        {
           return _bookingService.AddBooking(booking);
        }
    }
}