using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StealJobs.Entities.Model
{
    [Table("location")]
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        public string Region { get; set; }

        public string City { get; set; }

    }
}
