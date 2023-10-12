using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Bookings.Validation
{
    public class BookingFormValidator : AbstractValidator<Booking>
    {
            public BookingFormValidator()
            {
            

            // add all validation rules here instead of using attributes.
            // can use conditionals - cant do it out of box with annotations
                RuleFor(p => p.Name)
                    .NotEmpty().WithMessage("You must enter your name");

            RuleFor(p => p.BookingDate)
                   .NotNull().WithMessage("You must enter your booking date");

            RuleFor(p => p.Flexibility)
                  .NotNull().WithMessage("You must select flexibility");

            RuleFor(p => p.VehicleSize)
                 .NotNull().WithMessage("You must select vehicle size");

            RuleFor(p => p.ContactNumber)
               .NotNull().WithMessage("You must enter contact number");

            RuleFor(p => p.EmailAddress)
               .NotNull().WithMessage("You must enter email address");

        }
        }
    }

