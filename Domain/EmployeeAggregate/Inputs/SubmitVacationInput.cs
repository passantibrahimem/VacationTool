using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Enums;

namespace Domain.VacationAggregate.Inputs
{
   public class SubmitVacationInput
    {
        public long Id { get;  set; }
        public long EmployeeId { get;  set; }
        public DateTime StartDate { get;  set; }
        public DateTime EndDate { get;  set; }
        public int Days { get;  set; }
        public VacationTypeEnum VacationType { get;  set; }
    }
}
