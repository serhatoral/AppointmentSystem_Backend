using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
  public  class EfUserDal : EntityRepositoryBase<User, AppointmentContext> , IUserDal
    {

    }
}
