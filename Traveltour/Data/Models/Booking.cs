using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Traveltour.Data
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateOfBooking { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string BookingType { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string BookingStatus { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }

        [Column(TypeName = "int")]
        public int UserId  { get; set; }

        public virtual User User { get; set; }

        
    }
}