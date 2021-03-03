using AutoMapper;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext _repoContext;
        private readonly IMapper _mapper;
        private IJobRepository _job;
        private ICategoryRepository _category;
        private ILocationRepository _location;

        public IJobRepository Job
        {
            get
            {
                if (_job == null)
                {
                    _job = new JobRepository(_repoContext, _mapper);
                }
                return _job;
            }
        }

        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext, _mapper);
                }
                return _category;
            }
        }

        public ILocationRepository Location
        {
            get
            {
                if (_location == null)
                {
                    _location = new LocationRepository(_repoContext, _mapper);
                }
                return _location;
            }
        }
        public RepositoryWrapper(RepositoryContext repositoryContext, IMapper mapper)
        {
            _repoContext = repositoryContext;
            _mapper = mapper;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
