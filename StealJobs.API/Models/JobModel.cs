using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StealJobs.API.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int CategoryId { get; set; }
        public int LocationId { get; set; }
        public int EmploymentTypeId { get; set; }

        public CategoryModel Category { get; set; }

        public LocationModel Location { get; set; }
    }
}
