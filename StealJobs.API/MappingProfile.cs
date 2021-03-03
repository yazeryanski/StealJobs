using AutoMapper;
using StealJobs.API.Models;
using StealJobs.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StealJobs.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Job, JobModel>();
            CreateMap<Category, CategoryModel>();
            CreateMap<Location, LocationModel>();
        }
    }
}
