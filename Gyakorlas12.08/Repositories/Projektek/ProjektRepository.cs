using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Repositories
{


    public class ProjektRepository<Projektek> : IProjektRepository<Projektek> where Projektek : class
    {
        
        protected readonly ProjectManagerDBEntities Context;

        public ProjektRepository(ProjectManagerDBEntities context)
        {
            Context = context;
        }

        public string GetCoutofProjekt()
        {
          return Context.projektek.Count().ToString();

        }

        public IEnumerable<Projektek> GetAllProjektData()
        {
           
            return Context.Set<Projektek>().ToList();
        }

        public Projektek GetProjektById(int id)
        {
            return Context.Set<Projektek>().Find(id);
        }

        public void Insert(Projektek projekt)
        {
            Context.Set<Projektek>().Add(projekt);
        }

      
        public void Delete(Projektek projekt)
        {
            Context.Set<Projektek>().Remove(projekt);
        }

        
    }
}
