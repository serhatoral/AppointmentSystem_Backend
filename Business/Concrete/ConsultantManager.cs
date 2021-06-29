using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class ConsultantManager : IConsultantService
    {
        IConsultantDal _consultantDal;

        public ConsultantManager(IConsultantDal consultantDal)
        {
            _consultantDal = consultantDal;
        }

        
        public IResult Add(Consultant consultant)
        {
            _consultantDal.Add(consultant);
            return new SuccessResult();
        }

        public IResult Delete(Consultant consultant)
        {
            _consultantDal.Delete(consultant);
            return new SuccessResult();
        }

        public IDataResult<List<Consultant>> GetAll()
        {
            return new SuccessDataResult<List<Consultant>>(_consultantDal.GetAll());
        }

        public IDataResult<Consultant> GetById(int consultantId)
        {
            return new SuccessDataResult<Consultant>(_consultantDal.Get(p=>p.ConsultantId == consultantId )) ;
        }

        public IResult Update(Consultant consultant)
        {
            _consultantDal.Update(consultant);
            return new SuccessResult();
        }
    }
}
