using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(250)]
        public string Address { get; set; }

        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        public int GenreId { get; set; }

        public decimal LibraryMembershipFee { get; set; }

        public bool IsStudent { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.ImageUrl)]

        public string ImageUrl { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [ScaffoldColumn(true)]

        public HttpPostedFileBase ImageUpload { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual IList<Book> Books { get; set; } = new List<Book>();
    }
}