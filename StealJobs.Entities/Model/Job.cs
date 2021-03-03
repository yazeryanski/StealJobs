using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StealJobs.Entities.Model
{
    [Table("job")]
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Job Title is required")]
        [StringLength(100, ErrorMessage = "Title can't be longer than 100 characters")]
        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public Location Location { get; set; }

        [ForeignKey(nameof(EmploymentType))]
        public int EmploymentTypeId { get; set; }
        public EmploymentType EmploymentType { get; set; }

    }
}
