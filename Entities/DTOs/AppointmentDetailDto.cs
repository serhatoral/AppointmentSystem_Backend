using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public class AppointmentDetailDto : IDto
    {
        public int AppointmentId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public string ConsultantName { get; set; }       
        public string ConsultantSurname { get; set; }
        public string ConsultantEmail { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
