using Domain.VacationAggregate.Inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmployeeAggregate
{
 [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public string MobilePhone { get; private set; }
        public int AnnualBalance { get; private set; }
        public int SickBalance { get; private set; }

        public void Update(int annualBalance,int sickBalance)
        {
            this.AnnualBalance = annualBalance;
            this.SickBalance = sickBalance;
        }
      
    }
}
