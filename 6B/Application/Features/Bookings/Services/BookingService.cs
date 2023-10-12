using Application.Features.Bookings.Interfaces;
using Application.Features.Bookings.Services.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Bookings.Services
{

    // Use a service and never repo directly.
    // Comes in handy later on when more business rules added / unit testing
    public class BookingService : IBookingService
    {
        private IRepository _repository;
        public BookingService(IRepository repository) {
        
            _repository = repository;
        }

        public bool AddBooking(Booking booking)
        {
            //Check if booking exists already
            // Add Booking if dont exist
            // update existing booking otherwise
            // if viewmodel is required use automapper to map back and forth



            return _repository.AddBooking(booking); 
        }
    }
}
