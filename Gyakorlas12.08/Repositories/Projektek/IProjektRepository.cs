using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManager.Repositories
{
    public interface IProjektRepository<Projektek> where Projektek : class
        
    {
        string GetCoutofProjekt();
        Projektek GetProjektById(int id);
        IEnumerable<Projektek> GetAllProjektData();

        void Insert(Projektek projekt);
        void Delete(Projektek projekt);
       
    }
}
