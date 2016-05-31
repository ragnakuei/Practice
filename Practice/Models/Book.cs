using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Book
    {
        [Key]
        [DisplayName("編號")]
        public int id { get; set; }

        [Required]
        [DisplayName("書名")]
        public string name { get; set; }

        [Required]
        [DisplayName("發行日期")]
        [DataType(DataType.Date)]
        public DateTime publish_date { get; set; }
    }
}
