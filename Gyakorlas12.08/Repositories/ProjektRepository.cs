using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManager.Repositories
{


    public class ProjektRepository<Projektek> : IProjektRepository<Projektek> where Projektek : class
    {

        protected readonly ProjectManagerDBEntities Context;

        public ProjektRepository(ProjectManagerDBEntities context)
        {
            Context = context;
        }

        public string GetCoutOfOpenProjekt()
        {
            /*using (var ctx = new ProjectManagerDBEntities())
            {
                var projektek = ctx.projektek
                                .Where(p => p.Statusz == "Új");//.FirstOrDefault();
                return projektek.ToString();
            }*/
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

        public string GetNewProjects(Button btn)
        {
            
                btn.Text = Context.projektek .Where(p => p.Statusz == "Új")
                .Count().ToString();

            return btn.Text;
            //return projektek;//.ToString();

        }

        public string CountOfPendingProjects(Button btn)
        {
            btn.Text = Context.projektek.Where(p => p.Statusz == "Foly")
                            .Count().ToString();

            return btn.Text;
        }
    }
}

