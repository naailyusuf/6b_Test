using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Bookings.Services.Interfaces
{
    public interface IBookingService
    {
        bool AddBooking(Booking booking);
    }
}
