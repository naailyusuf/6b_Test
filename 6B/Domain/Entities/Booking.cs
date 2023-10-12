using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BookingDate { get; set; }

        public int Flexibility { get; set; }

        public int VehicleSize { get; set; }

        public string ContactNumber { get; set; }

        public string EmailAddress { get; set; }
    }
}
