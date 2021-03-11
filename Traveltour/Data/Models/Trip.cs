using System;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Traveltour.Data
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Destination { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateStarted { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateCompleted { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Location { get; set; }

        [Column(TypeName = "int")]
        public int TourId { get; set; }
    }
}
