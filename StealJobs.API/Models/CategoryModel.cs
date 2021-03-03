using AutoMapper;
using AutoMapper.Configuration.Annotations;
using StealJobs.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StealJobs.API.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
