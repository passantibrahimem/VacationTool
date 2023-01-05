using Domain.EmployeeAggregate;
using Domain.VacationAggregate.Inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Enums;

namespace Domain.VacationAggregate
{
    [Table("VacationRequest")]
  public  class VacationRequest
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; private set; }
        [ForeignKey("Employee")]
        public long EmployeeId { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public long Days { get; private set; }
        public VacationTypeEnum VacationType { get; private set; }

        public virtual Employee Employee { get; private set; }


        public void CreateVacationRequest(SubmitVacationInput input)
        {
            this.Id = input.Id;
            this.EmployeeId = input.EmployeeId;
            this.Days = input.Days;
            this.StartDate = input.StartDate;
            this.EndDate = input.EndDate;
            this.VacationType = input.VacationType;
        }

    }
}
