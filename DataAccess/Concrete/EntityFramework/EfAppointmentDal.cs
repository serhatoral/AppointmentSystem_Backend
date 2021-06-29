using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
  public  class EfAppointmentDal : EntityRepositoryBase<Appointment, AppointmentContext>, IAppointmentDal
    {
        public List<AppointmentDetailDto> GetAppointmentDetails()
        {
            using (AppointmentContext contex = new AppointmentContext())
            {
                var result = from a in contex.Appointment
                             join u in contex.User on a.UserId equals u.UserId
                             join c in contex.Consultant on a.ConsultantId equals c.ConsultantId

                             select new AppointmentDetailDto {AppointmentId= a.AppointmentId, AppointmentDate= a.AppointmentDate,
                                 UserName= u.UserName, UserSurname= u.UserSurname, UserEmail= u.UserEmail,
                                 ConsultantName= c.ConsultantName, ConsultantSurname= c.ConsultantSurname, ConsultantEmail= c.ConsultantEmail,
                                 
                             };
                return result.ToList();          
            }
        }
    }
}
