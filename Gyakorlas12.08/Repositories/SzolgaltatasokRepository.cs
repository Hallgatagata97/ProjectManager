using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Repositories
{
    class SzolgaltatasokRepository<Szolgaltatasok> : ISzolgaltatasRepository<Szolgaltatasok> where Szolgaltatasok : class
    {
        protected readonly ProjectManagerDBEntities Context;

        public SzolgaltatasokRepository(ProjectManagerDBEntities context)
        {
            Context = context;
        }
        public IEnumerable<Szolgaltatasok> GetAllSzolgaltatasData()
        {
            throw new NotImplementedException();
        }

        public Szolgaltatasok GetSzolgaltatasById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Szolgaltatasok szolgaltatas)
        {
            throw new NotImplementedException();
        }

        public void Update(Szolgaltatasok szolgaltatas)
        {
            throw new NotImplementedException();
        }
        public void Delete(Szolgaltatasok szolgaltatas)
        {
            throw new NotImplementedException();
        }
    }
}
