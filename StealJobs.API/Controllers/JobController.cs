using AutoMapper;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StealJobs.API.Models;
using StealJobs.Entities;
using StealJobs.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StealJobs.API.Controllers
{
    [Route("api/job")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public JobController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllJobs()
        {
            var jobs = _repository.Job.FindAll<JobModel>();
            return Ok(jobs);
        }


        [HttpGet("search")]
        public IActionResult Search([FromQuery(Name = "category")]int categoryId, [FromQuery(Name = "location")] int locationId, [FromQuery(Name = "q")] string keyword)
        {
            var jobs = _repository.Job.FindAll<JobModel>();

            if (categoryId > 0)
            {
                jobs = jobs.Where(j => j.CategoryId == categoryId);
            }

            if (locationId > 0)
            {
                jobs = jobs.Where(j => j.LocationId == locationId);
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                jobs = jobs.Where(j => j.Title.Contains(keyword));
            }

            var foundJobs = jobs.ToList();

            if (foundJobs.Count == 0)
            {
                return NotFound();
            }
            else
            {
                SearchModel model = new SearchModel
                {
                    Data = foundJobs,
                    Count = foundJobs.Count
                };

                return Ok(model);
            }
        }
    }
}
