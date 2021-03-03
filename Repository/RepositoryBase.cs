using AutoMapper;
using AutoMapper.QueryableExtensions;
using Contracts;
using Microsoft.EntityFrameworkCore;
using Repository.Converters;
using Repository.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<TEntitiy> : IRepositoryBase<TEntitiy> where TEntitiy : class
    {
        protected RepositoryContext RepositoryContext { get; set; }
        private readonly IMapper _mapper;

        public RepositoryBase(RepositoryContext repositoryContext, IMapper mapper)
        {
            this.RepositoryContext = repositoryContext;
            _mapper = mapper;
        }

        public IQueryable<T> FindAll<T>()
        {
            return this.RepositoryContext.Set<TEntitiy>().AsNoTracking().ProjectTo<T>(_mapper.ConfigurationProvider);
        }

        public IQueryable<T> FindByCondition<T>(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<TEntitiy>().AsNoTracking().ProjectTo<T>(_mapper.ConfigurationProvider).Where(expression);
        }

        public void Create(TEntitiy entity)
        {
            this.RepositoryContext.Set<TEntitiy>().Add(entity);
        }

        public void Update(TEntitiy entity)
        {
            this.RepositoryContext.Set<TEntitiy>().Update(entity);
        }

        public void Delete(TEntitiy entity)
        {
            this.RepositoryContext.Set<TEntitiy>().Remove(entity);
        }
    }
}
