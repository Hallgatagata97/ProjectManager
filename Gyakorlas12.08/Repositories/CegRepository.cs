using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManager.Repositories
{
    public class CegRepository<Cegek> : ICegRepository<Cegek> where Cegek : class
    {
        protected readonly ProjectManagerDBEntities Context;
  

        public CegRepository(ProjectManagerDBEntities context)
        {
            Context = context;
        }

        public IEnumerable<Cegek> GetAllCegData()
        {
            return Context.Set<Cegek>().ToList();
        }

        public Cegek GetCegtById(int id)
        {
            return Context.Set<Cegek>().Find(id);
        }

        public void Insert(Cegek ceg)
        {
            Context.Set<Cegek>().Add(ceg);
        }

       
        public void Delete(Cegek ceg)
        {
            Context.Set<Cegek>().Remove(ceg);
        }

        public string GetAdoszam(TextBox tbx,int id)
        {

           tbx.Text = Context.cegek.SqlQuery($"SELECT [adoszam] AS [adoszam] FROM [cegek] WHERE [id] = {id}").ToString();
            
            return tbx.Text;
               /* .Where(p => p.id == id)
                .Select (p => p.adoszam).ToString();
                .
                .Select(result => new 
                {
                    result.adoszam
                }).ToString();*/
                
            //return tbx.Text;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
