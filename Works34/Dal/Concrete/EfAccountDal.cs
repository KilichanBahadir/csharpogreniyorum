using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Core.DataAccess.EntityFramework;
using Works34.Dal.Abstract;
using Works34.Dal.Concrete.EntityFramework;
using Works34.Entities;

namespace Works34.Dal.Concrete
{
    public class EfAccountDal : EfEntityRepositoryBase<Account>, IAccountDal
    {
        private CRMDbContext _crmDbContext;
        public EfAccountDal(CRMDbContext crmDbContext) : base(crmDbContext)
        {
            _crmDbContext = crmDbContext;
        }
    }
}
