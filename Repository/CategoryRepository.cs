using AutoMapper;
using Contracts;
using StealJobs.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext, IMapper mapper) : base(repositoryContext, mapper)
        {

        }
    }
}
