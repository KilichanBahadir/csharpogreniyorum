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
    public class EfContactDal : EfEntityRepositoryBase<Contact>, IContactDal
    {
        private CRMDbContext _crmDbContext;
        public EfContactDal(CRMDbContext crmDbContext) : base(crmDbContext)
        {
            _crmDbContext = crmDbContext;
        }
    }

}

