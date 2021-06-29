using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IConsultantService
    {
        IDataResult<List<Consultant>> GetAll();
        IDataResult<Consultant> GetById(int consultantId);
        IResult Add(Consultant consultant);
        IResult Update(Consultant consultantr);
        IResult Delete(Consultant consultant);
    }
}
