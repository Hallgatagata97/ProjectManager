using ProjektManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManager.Services
{
    public class DataService_Cegek
    {
        ICegRepository<Cegek> cegRepository;

        public DataService_Cegek(ICegRepository<Cegek> cegRepository)
        {
            this.cegRepository = cegRepository;
        }

        public IEnumerable<Cegek> GetAllCegData()
        {
            return cegRepository.GetAllCegData();

        }

        public string GetAdoszam(TextBox tbx, int id)
        {
           cegRepository.GetAdoszam(tbx, id);
            return tbx.Text;
        }

    }
}
