using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IJobRepository Job { get; }
        ICategoryRepository Category { get; }
        ILocationRepository Location { get; }
        void Save();
    }
}
