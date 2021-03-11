using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Traveltour.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Firstname { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Othername { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Gender { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DOB { get; set; }
    }
}