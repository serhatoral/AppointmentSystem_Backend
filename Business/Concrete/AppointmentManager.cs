using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public IResult Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
            return new SuccessResult();
        }

        public IResult Delete(Appointment appointment)
        {
            _appointmentDal.Delete(appointment);
            return new SuccessResult();
        }

        public IDataResult<List<Appointment>> GetAll()
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll());
        }

        public IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails()
        {
            return new SuccessDataResult<List<AppointmentDetailDto>>(_appointmentDal.GetAppointmentDetails(), Messages.AppointmentDetailsListed);
        }

        public IDataResult<Appointment> GetById(int appointmentId)
        {
            return new SuccessDataResult<Appointment>(_appointmentDal.Get(p=> p.AppointmentId == appointmentId));
        }

        public IResult Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
            return new SuccessResult();
        }
    }
}
