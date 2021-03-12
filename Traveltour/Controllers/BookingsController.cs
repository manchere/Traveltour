using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Traveltour.Data;
using Traveltour.Data.Classes;


namespace Bookings.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookingsController : ControllerBase
    {
        private readonly TraveltourDBContext _context;

        public BookingsController(TraveltourDBContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookings([FromQuery] BookingQueryParameters queryParameters)
        {
            IQueryable<Booking> bookings = _context.Bookings;

            if (queryParameters.MinPrice != null && queryParameters.MaxPrice != null)
            {
                bookings = bookings.Where(b => b.Price >= queryParameters.MinPrice.Value && b.Price <= queryParameters.MaxPrice.Value);
            }

            if (!string.IsNullOrEmpty(queryParameters.BookingType))
            {
                bookings = bookings.Where(b => b.BookingType == queryParameters.BookingType);
            }


            bookings = bookings.Skip(queryParameters.Size * queryParameters.Page - 1)
            .Take(queryParameters.Size);

            return Ok(await bookings.ToArrayAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBookingById(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if(booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }
    }
}