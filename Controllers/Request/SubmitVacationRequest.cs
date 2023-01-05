using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities.Enums;

namespace VacationToolAPI.Controllers.Request
{
    public class SubmitVacationRequest
    {
        public int NoOfDays { get; set; }
        public VacationTypeEnum VacationType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
