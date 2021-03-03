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
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public CategoryController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public IActionResult ListAll()
        {
            var categories = _repository.Category.FindAll<CategoryModel>().ToList();
            return Ok(categories);
        }
    }
}
