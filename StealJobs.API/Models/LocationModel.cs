using AutoMapper;
using AutoMapper.Configuration.Annotations;
using StealJobs.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StealJobs.API.Models
{
    public class LocationModel
    {
        public int LocationId { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string City { get; set; }
    }
}
