
using Domain;
using Infrastructure.DataBase.Context;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.UOW
{
    public class VacationToolUOW
    {
        private readonly VacationToolContext Context;

       
        #region Repos.
        public VacationRepositary VacationRep { get; set; }
      
        #endregion

  

        public VacationToolUOW(VacationToolContext _Context)
        {
            this.Context = _Context;


            #region Repos.
            this.VacationRep = new VacationRepositary(Context);
          
            #endregion
        }


        public virtual void SaveChanges()
        {
            Context.SaveChanges();
            
        }


        




    }
}
