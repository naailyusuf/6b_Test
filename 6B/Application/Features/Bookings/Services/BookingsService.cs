using Application.Features.Bookings.Services.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Bookings.Services
{
    public class BookingsService : IBookingService
    {
        public BookingsService() { }

        public bool AddBooking(Booking booking)
        {
            //Check if booking exists already
            // Add Booking if dont exist
            // update existing booking otherwise
            // if viewmodel is required use automapper to map back and forth

            return false;
        }
    }
}
