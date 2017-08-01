using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MvcTest.Common.Domain.Enums;

namespace MvcTest.Data.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Knickname { get; set; }

        [Required]
        public DisplayAsEnum DisplayAs { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}