using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Bookings.Interfaces;
using Domain.Entities;

namespace Persistence.Repositories
{
    public class Repository: IRepository {

        private DBContext _entities;
        private IServiceProvider _serviceProvider;

        public IConfigurationRoot Configuration { get; }


        public Repository(DBContext entity, IServiceProvider serviceProvider)
        {
            _entities = entity;
            _serviceProvider = serviceProvider;
        }

        public bool AddBooking(Booking newBooking)
        {
            // add new booking to entities and return whether succesfull

            _entities.Bookings.Add(newBooking);
            _entities.SaveChanges();

            return false;
        }
    }
}
