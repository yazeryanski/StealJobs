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
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public LocationController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public IActionResult ListAll()
        {
            var locations = _repository.Location.FindAll<LocationModel>().ToList();
            return Ok(locations);
        }
    }
}
