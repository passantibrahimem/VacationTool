using Domain.EmployeeAggregate;
using Domain.VacationAggregate;
using Infrastructure.DataBase.Context;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class VacationRepositary : BaseRepository
    {
        public VacationRepositary(VacationToolContext _context)
           : base(_context)
        {
        }
        public long GetVacationKey()
        {
            return Context.GetNextSequenceValue(SequenceKeys.VacationKeySequence);
        }
        public Employee FindEmployeebyId(long id)
        {
           return Context.Employees.Where(s=>s.Id==id).FirstOrDefault();

        }
        public void AddVacation(VacationRequest vacation)
        {
            Context.VacationRequests.Add(vacation);
        }
    }
}
