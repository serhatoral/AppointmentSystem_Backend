using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IAppointmentService
    {
        IDataResult<List<Appointment>> GetAll();
        IDataResult<Appointment> GetById(int appointmentId);
        IResult Add(Appointment appointment);
        IResult Update(Appointment appointment);
        IResult Delete(Appointment appointment);
        IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails();


    }
}
