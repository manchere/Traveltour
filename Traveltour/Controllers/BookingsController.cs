using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Traveltour.Data;

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
        public IEnumerable<Booking> GetAllBookings()
        {
            return _context.Bookings.ToArray();
        }
    }
}