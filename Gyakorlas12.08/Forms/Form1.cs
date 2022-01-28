using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.ObjectModel;
using ProjektManager.Repositories;
using ProjektManager.Services;

namespace ProjektManager
{
    
    public partial class Form1 : Form
    {
        IProjektRepository<Projektek> projektRepository;
        
        
        ClickEventService buttons;
        DataService_Projekt data;
     
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            /* Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));*/

            //fejSzovegLbl.Text = foOldalBtn.Text;
            
            projektUgyfelTipusCbx.DataSource = Enum.GetValues(typeof(CegTipus));
            ugyfelUgyfelTipusCbx.DataSource = Enum.GetValues(typeof(CegTipus));
            this.projektRepository = new ProjektRepository<Projektek>(new ProjectManagerDBEntities());
            this.buttons = new ClickEventService();
            this.data = new DataService_Projekt(projektRepository);
            

            
        }
        #region Főoldal
        public void UjnyitottProjektekBetoltes()
        {
            ujprojektBtn.Text = data.GetNewProjects(ujprojektBtn);
            // label21.Text = data.GetNewProjects();
        }
        private void NyitottProjektekBetoltes()
        {

            nyitottProjektBtn.Text = data.CountOfOpenProjects();


        }
        private void FuggoProjektekBetoltes()
        {

            folyamatbanBtn.Text = data.CountOfPendingProjects(folyamatbanBtn);


        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagerDBDataSet2.statuszok' table. You can move, or remove it, as needed.
            this.statuszokTableAdapter.Fill(this.projectManagerDBDataSet2.statuszok);
            // TODO: This line of code loads data into the 'projectManagerDBDataSet2.cegek' table. You can move, or remove it, as needed.
            this.cegekTableAdapter.Fill(this.projectManagerDBDataSet2.cegek);


            buttons.ClickOnButton(foOldalBtn);
            NyitottProjektekBetoltes();
            UjnyitottProjektekBetoltes();
            FuggoProjektekBetoltes();
            // AtadasraVaroProjektekBetoltes();
            foOldalPnl.BringToFront();
            if (nyitottProjektBtn.Text.Length >= 2)
            {
                nyitottProjektBtn.BackColor = Color.Red;
            }
            if (ujprojektBtn.Text == "0")
            {
                ujprojektBtn.BackColor = Color.Gray;
            }
        }
        private void xBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        #region foOldalBtn
        private void foOldalBtn_Click(object sender, EventArgs e)
        {
            fejSzovegLbl.Text = foOldalBtn.Text;

            buttons.ClickOnButton(foOldalBtn);
            NyitottProjektekBetoltes();
            UjnyitottProjektekBetoltes();
            FuggoProjektekBetoltes();
            foOldalPnl.BringToFront();
        }
        private void foOldalBtn_Leave(object sender, EventArgs e)
        {

            buttons.LeaveButton(foOldalBtn);
        }


        #endregion
        #region Buttons
        private void projektekBtn_Click(object sender, EventArgs e)
        {
            buttons.LeaveButton(foOldalBtn);
            buttons.ClickOnButton(projektekBtn);
            fejSzovegLbl.Text = projektekBtn.Text;
            projektekPnl.BringToFront();

            projektUgyfelTipusCbx.DataSource = Enum.GetValues(typeof(CegTipus));


        }

        private void ugyfelekBtn_Click(object sender, EventArgs e)
        {
            buttons.LeaveButton(foOldalBtn);

            buttons.ClickOnButton(ugyfelekBtn);
            fejSzovegLbl.Text = ugyfelekBtn.Text;
            ugyfelekPnl.BringToFront();
        }

        private void szolgaltatasokBtn_Click(object sender, EventArgs e)
        {
            buttons.LeaveButton(foOldalBtn);
            buttons.ClickOnButton(szolgaltatasokBtn);
            fejSzovegLbl.Text = szolgaltatasokBtn.Text;
            szolgaltatasPnl.BringToFront();
        }

        private void projektekBtn_Leave(object sender, EventArgs e)
        {
            buttons.LeaveButton(projektekBtn);
        }

        private void ugyfelekBtn_Leave(object sender, EventArgs e)
        {
            buttons.LeaveButton(ugyfelekBtn);
        }

        private void szolgaltatasokBtn_Leave(object sender, EventArgs e)
        {
            buttons.LeaveButton(szolgaltatasokBtn);
        }



        private void nyitottProjektBtn_Click(object sender, EventArgs e)
        {
            // LBFeltoltesNyitottPr();



        }
        #endregion

        private void UjProjektBtn_Click(object sender, EventArgs e)
        {
            UjProjektFrm frm = new UjProjektFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                buttons.ClickOnButton(projektekBtn);
            }
        }

        private void UjUgyfelBtn_Click(object sender, EventArgs e)
        {
            UjUgyfelFrm frm = new UjUgyfelFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ujUgyfelBtn.Text = "Új ügyfél";
            }
        }

        private void ugyfelModositasBtn_Click(object sender, EventArgs e)
        {
            UjUgyfelFrm frm = new UjUgyfelFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ujUgyfelBtn.Text = "Új ügyfél";
            }
        }

        private void ujSzolgaltatasBtn_Click(object sender, EventArgs e)
        {
            UjSzolgaltatasFrm frm = new UjSzolgaltatasFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ujSzolgaltatasBtn.Text = "Új szolgáltatás";
            }


        }

        private void szolgaltatasModositasBtn_Click(object sender, EventArgs e)
        {
            UjSzolgaltatasFrm frm = new UjSzolgaltatasFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ujSzolgaltatasBtn.Text = "Új szolgáltatás";
            }
        }

        private void projektModositasBtn_Click(object sender, EventArgs e)
        {
            UjProjektFrm frm = new UjProjektFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                buttons.ClickOnButton(projektekBtn);
            }
        }
        #endregion

        #region Projektek
        public void PanelKezelo()
        {
            
            if (projektekPnl.Visible)
            {

            }
        }

        #endregion

    }
}
