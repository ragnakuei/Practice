using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Movie
    {
        [Key]
        [DisplayName("編號")]
        public int id { get; set; }

        [Required]
        [DisplayName("電影名稱")]
        public string name { get; set; }

        [Required]
        [DisplayName("發行日期")]
        [DataType(DataType.Date)]
        public DateTime publish_date { get; set; }

        [Required]
        [DisplayName("片長")]
        [DataType(DataType.Duration)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}分")]
        public int duration { get; set; }
    }
}
