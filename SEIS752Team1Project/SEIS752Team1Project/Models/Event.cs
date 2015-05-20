using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SEIS752Team1Project.Models
{
    public class Event
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
       
        [DataType(DataType.ImageUrl)]
        [StringLength(1024)]
        public string Url { get; set; }
    }
}