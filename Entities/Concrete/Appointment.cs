using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Appointment : IEntity
    {
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public int ConsultantId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
