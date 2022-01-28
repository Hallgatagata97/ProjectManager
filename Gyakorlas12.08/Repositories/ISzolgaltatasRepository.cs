using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Repositories
{
    public interface ISzolgaltatasRepository<Szolgaltatasok> where Szolgaltatasok : class
    {
        Szolgaltatasok GetSzolgaltatasById(int id);
        IEnumerable<Szolgaltatasok> GetAllSzolgaltatasData();

        void Insert(Szolgaltatasok szolgaltatas);
        void Delete(Szolgaltatasok szolgaltatas);
        void Update(Szolgaltatasok szolgaltatas);
    }
}
