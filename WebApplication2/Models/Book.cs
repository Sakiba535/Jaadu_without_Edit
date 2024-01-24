using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }


        [Column(TypeName = "datetime2")]
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BorrowingDate { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.Date)]
        [DisplayName("End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }

        public int StudentID { get; set; }
    }
}