using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManager.Repositories
{
    public interface IProjektRepository<Projektek> where Projektek : class
        
    {
        string GetCoutOfOpenProjekt();
        string CountOfPendingProjects(Button btn);
        Projektek GetProjektById(int id);
        IEnumerable<Projektek> GetAllProjektData();
        string GetNewProjects(Button btn);

        void Insert(Projektek projekt);
        void Delete(Projektek projekt);
       
    }
}
