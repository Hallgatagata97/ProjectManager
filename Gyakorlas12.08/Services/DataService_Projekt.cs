using ProjektManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManager.Services
{
    public class DataService_Projekt
    {
        IProjektRepository<Projektek> projektRepository;
       

        public DataService_Projekt(IProjektRepository<Projektek> projektRepository)
        {
            this.projektRepository = projektRepository;
            
        }

        public string CountOfOpenProjects()
        {
            return projektRepository.GetCoutOfOpenProjekt().ToString();
        }

        public string GetNewProjects(Button btn)
        {
            return projektRepository.GetNewProjects(btn).ToString();
        }
        public string CountOfPendingProjects(Button btn)
        {
            return projektRepository.CountOfPendingProjects(btn).ToString();
        }
    }
}
