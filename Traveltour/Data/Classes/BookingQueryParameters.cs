using System;

namespace Traveltour.Data.Classes
{
    public class BookingQueryParameters : QueryParameters
    {
        public string BookingType { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}