using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StealJobs.API.Models
{
    public class SearchModel
    {
       public List<JobModel> Data { get; set; }
       public int Count { get; set; }
    }
}
