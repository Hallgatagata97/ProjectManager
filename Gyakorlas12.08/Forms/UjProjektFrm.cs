using ProjektManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManager
{
    public partial class UjProjektFrm : Form
    {
        ICegRepository<Cegek> cegRepository;
        public UjProjektFrm()
        {
            InitializeComponent();
            this.cegRepository = new CegRepository<Cegek>(new ProjectManagerDBEntities());
          
        }

        private void projektModositasBtn_Click(object sender, EventArgs e)
        {
            rendelesadatokPnl.BringToFront();
           
        }

        private void mentesBtn_Click(object sender, EventArgs e)
        {
            var context = new ProjectManagerDBEntities();
            var projekt = new Projektek()
            {
                Megnevezes = megnevezesTbx.Text,
                Ceg_id = int.Parse(cegIdTbx.Text),
                Statusz = "Új",
                Hatarido = hataridoDTP.Value


            };
        }

        private void UjProjektFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagerDBDataSet2.szolgaltatasok' table. You can move, or remove it, as needed.
            this.szolgaltatasokTableAdapter.Fill(this.projectManagerDBDataSet2.szolgaltatasok);

        }

        
        private string  CegAdatFeltoltes()
        {
            cegRepository.GetAdoszam(AdoszamTbx, int.Parse(cegIdTbx.Text));
            return AdoszamTbx.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdoszamTbx.Text = CegAdatFeltoltes();
        }
    }
}
