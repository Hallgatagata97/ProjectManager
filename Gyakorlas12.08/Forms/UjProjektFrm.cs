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
        public UjProjektFrm()
        {
            InitializeComponent();
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
                Ceg_id = int.Parse(cegIdTbxTetel.Text),
                Statusz = "Új",
                Hatarido = hataridoDTPTetel.Value


            };
        }
    }
}
