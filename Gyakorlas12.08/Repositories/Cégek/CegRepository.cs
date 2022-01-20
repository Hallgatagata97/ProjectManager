using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Repositories
{
    public class CegRepository<Cegek> : ICegRepository<Cegek> where Cegek : class
    {
        protected readonly ProjectManagerDBEntities Context;

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
    }
}
