using Domain.VacationAggregate.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Enums;

namespace Domain.EmployeeAggregate
{
    public class VacationRequest
    {
        public long Id { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Days { get; private set; }
        public VacationTypeEnum VacationType { get; private set; }
        public VacationRequest()
            {

            }
        internal VacationRequest(SubmitVacationInput input)
        {
            this.Id = input.Id;
            this.StartDate = input.StartDate;
            this.EndDate = input.EndDate;
            this.Days = input.Days;
            this.VacationType = input.VacationType;

        }
    }

}
