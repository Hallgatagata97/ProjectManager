using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Repositories
{
    public interface ICegRepository<Cegek> where Cegek : class
    {
        Cegek GetCegtById(int id);
        IEnumerable<Cegek> GetAllCegData();

        void Insert(Cegek ceg);
        void Delete(Cegek ceg);
     
    }
}
