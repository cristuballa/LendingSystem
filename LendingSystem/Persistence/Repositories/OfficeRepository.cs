using LendingSystem.Core.Domain;
using LendingSystem.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace LendingSystem.Persistence.Repositories
{

    public class OfficeRepository : Repository<Office>, IOfficeRepository
    {
        public OfficeRepository(LendingContext context)
            : base(context)
        {
        }

        public IEnumerable<Office> GetTopSellingCourses(int count)
        {
            return LendingContext.Offices
                .Where(o=>o.IsDeleted==1)
                .OrderByDescending(c => c.Name)
                .Take(count).ToList();
        }


        public LendingContext LendingContext
        {
            get { return Context as LendingContext; }
        }
    }
}