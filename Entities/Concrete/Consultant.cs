using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Consultant : IEntity
    {
        public int ConsultantId { get; set; }
        public string ConsultantName { get; set; }
        public string ConsultantSurname { get; set; }
        public int ConsultantAge { get; set; }
        public string ConsultantEmail { get; set; }
    }
}
