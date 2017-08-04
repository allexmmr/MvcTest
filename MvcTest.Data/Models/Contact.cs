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
        [StringLength(100, ErrorMessage = "The First Name field cannot be longer than 100 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The Last Name field cannot be longer than 100 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(20, ErrorMessage = "The Knickname field cannot be longer than 20 characters.")]
        public string Knickname { get; set; }

        [Required]
        [Display(Name = "Display As")]
        public DisplayAsEnum DisplayAs { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}