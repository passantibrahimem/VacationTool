using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationToolAPI.Controllers.Request;
using Domain.VacationAggregate;
using Infrastructure.UOW;
using Domain.VacationAggregate.Inputs;
using VacationToolAPI.Controllers.Response;
using Utilities.Enums;
using Domain.EmployeeAggregate;

namespace VacationToolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacationController : Controller
    {

        private readonly VacationToolUOW UOW;


        public VacationController(VacationToolUOW uow)
        {
            UOW = uow;
        }

        [HttpPost("SubmitVacation")]
        public ActionResult SubmitVacation(SubmitVacationRequest req)
        {
            var id = 1;  //will get by userid who login into the system
            var employee = UOW.VacationRep.FindEmployeebyId(id);
            var submitVacationInput = new SubmitVacationInput
            {
                Id = UOW.VacationRep.GetVacationKey(),
                StartDate = req.StartDate,
                EndDate = req.EndDate,
                Days = req.NoOfDays,
                VacationType = req.VacationType,
                EmployeeId=employee.Id
            };
            var response = new EmployeeBalance
            {
                AnnualBalance = req.VacationType == VacationTypeEnum.Annual ? employee.AnnualBalance - req.NoOfDays : employee.AnnualBalance,
                SickBalance = req.VacationType == VacationTypeEnum.Sick ? employee.SickBalance - req.NoOfDays : employee.SickBalance

            };
            var vacation = new VacationRequest();
            UOW.VacationRep.AddVacation(vacation);
            vacation.CreateVacationRequest(submitVacationInput);
            UOW.SaveChanges();


            return Ok(response);
        }
    }
}
