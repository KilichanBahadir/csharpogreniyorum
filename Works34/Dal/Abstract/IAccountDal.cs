using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Core.DataAccess;
using Works34.Entities;

namespace Works34.Dal.Abstract
{
    public interface IAccountDal:IEntityRepository<Account>
    {
    }
}
