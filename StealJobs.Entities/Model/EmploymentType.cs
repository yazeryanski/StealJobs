using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StealJobs.Entities.Model
{
    [Table("employmentType")]
    public class EmploymentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Employment type name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string TypeName { get; set; }
    }
}
