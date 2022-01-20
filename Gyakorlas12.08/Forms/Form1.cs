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

namespace ProjektManager
{
    
    public partial class Form1 : Form
    {
        IProjektRepository<Projektek> projektRepository;
        ICegRepository<Cegek> cegRepository;
        ISzolgaltatasRepository<Szolgaltatasok> szolgaltatasRepository;
     
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
           /* Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));*/
            
            fejSzovegLbl.Text = foOldalBtn.Text;
            projektUgyfelTipusCbx.DataSource = Enum.GetValues(typeof(CegTipus));
            ugyfelUgyfelTipusCbx.DataSource = Enum.GetValues(typeof(CegTipus));
            this.projektRepository = new ProjektRepository<Projektek>();

            
        }

        /*public void UjnyitottProjektekBetoltes()
        {
            /* using (SqlConnection kapcsolat = new SqlConnection())
             {
                 kapcsolat.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectManagerDBEntities"].ConnectionString;

                 SqlCommand parancs =
                 new SqlCommand("select count(1) as mennyiseg FROM Projektek WHERE Projektek.statusz = 'új'", kapcsolat);
                 kapcsolat.Open();

                 SqlDataReader reader = parancs.ExecuteReader();

                 while (reader.Read())
                 {
                     ujprojektBtn.Text = (reader["mennyiseg"].ToString());

                 }
                 reader.Close();
             }
           
            
           


        }*/
       /* private void NyitottProjektekBetoltes()
        {
            
            using (SqlConnection kapcsolat = new SqlConnection())
            {

                var context = new ProjectManagerDBEntities();
              
              
                kapcsolat.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectManagerDBEntities"].ConnectionString;
                SqlCommand parancs =
                new SqlCommand("select count(1) as mennyiseg FROM Projektek WHERE Projektek.statusz = 'Új' OR Projektek.statusz = 'Folyamat' OR Projektek.statusz = 'Elkészült' OR Projektek.statusz = 'Átadásra'", kapcsolat);
                kapcsolat.Open();

                SqlDataReader reader = parancs.ExecuteReader();

                while (reader.Read())
                {
                    nyitottProjektBtn.Text = (reader["mennyiseg"].ToString());

                }
                reader.Close();
            }
        }*/
        private void FuggoProjektekBetoltes()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConstr"].ConnectionString);
            con.Open();
          
            
                folyamatbanBtn.Text = projektRepository.GetCoutofProjekt();
           
            
            /*

            {
                kapcsolat.ConnectionString = ConfigurationManager.ConnectionStrings["DBConstr"].ConnectionString;
                SqlCommand parancs =
                new SqlCommand("select count(1) as mennyiseg FROM Projektek WHERE Projektek.statusz = 'Folyamat'", kapcsolat);
                kapcsolat.Open();

                SqlDataReader reader = parancs.ExecuteReader();

                while (reader.Read())
                {
                    folyamatbanBtn.Text = (reader["mennyiseg"].ToString());

                }
                reader.Close();
            }*/
        }
        /*private void AtadasraVaroProjektekBetoltes()
        {
            using (SqlConnection kapcsolat = new SqlConnection("ProjectManagerDBEntities"))
            {
                kapcsolat.ConnectionString = ConfigurationManager.ConnectionStrings["DBConstr"].ConnectionString;
                SqlCommand parancs =
                new SqlCommand("select count(1) as mennyiseg FROM Projektek WHERE Projektek.statusz = 'Átadásra'", kapcsolat);
                kapcsolat.Open();

                SqlDataReader reader = parancs.ExecuteReader();

                while (reader.Read())
                {
                    atadasraBtn.Text = (reader["mennyiseg"].ToString());

                }
                reader.Close();
            }
        }*/
        /*private void LejartProjektekBetoltes()
        {
            using (SqlConnection kapcsolat = new SqlConnection())
            {
                kapcsolat.ConnectionString = ConfigurationManager.ConnectionStrings["DBConstr"].ConnectionString;
                SqlCommand parancs =
                new SqlCommand("select count(1) as mennyiseg FROM [dbo].[Projektek] WHERE hatarido < CURRENT_TIMESTAMP AND Projektek.statusz = 'Új' OR Projektek.statusz = 'Folyamat';", kapcsolat);
                kapcsolat.Open();

                SqlDataReader reader = parancs.ExecuteReader();

                while (reader.Read())
                {
                    lejartBtn.Text = (reader["mennyiseg"].ToString());

                }
                reader.Close();
            }
        }*/
       /* private void LBFeltoltesNyitottPr()
        {
            using (SqlConnection kapcsolat = new SqlConnection())
            {
                kapcsolat.ConnectionString = ConfigurationManager.ConnectionStrings["DBConstr"].ConnectionString;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Projektek.id, Projektek.megnevezes, Projektek.hatarido FROM Projektek", kapcsolat);

                DataSet adatok = new DataSet();
                adapter.Fill(adatok, "Projektek");
                //projektekLbx.DataSource = adatok;
                listBox1.DataSource = adatok;
                
                
            }
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
         

            foOldalBtn.BackColor = Color.FromArgb(70, 40, 90);
            //NyitottProjektekBetoltes();
           // UjnyitottProjektekBetoltes();
            FuggoProjektekBetoltes();
           // AtadasraVaroProjektekBetoltes();
            foOldalPnl.BringToFront();




        }
        private void xBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        #region foOldalBtn
        private void foOldalBtn_Click(object sender, EventArgs e)
        {
            fejSzovegLbl.Text = foOldalBtn.Text;
      
            foOldalBtn.BackColor = Color.FromArgb(70, 40, 90);
           // NyitottProjektekBetoltes();
           // UjnyitottProjektekBetoltes();
            FuggoProjektekBetoltes();
           // AtadasraVaroProjektekBetoltes();
            foOldalPnl.BringToFront();
        }
        private void foOldalBtn_Leave(object sender, EventArgs e)
        {
            foOldalBtn.BackColor = Color.FromArgb(25, 15, 35);
        }


        #endregion
        #region buttons
        private void projektekBtn_Click(object sender, EventArgs e)
        {
            foOldalBtn.BackColor = Color.FromArgb(25, 15, 35);
            projektekBtn.BackColor = Color.FromArgb(70, 40, 90);
            fejSzovegLbl.Text = projektekBtn.Text;
            projektekPnl.BringToFront();


        }

        private void ugyfelekBtn_Click(object sender, EventArgs e)
        {
            foOldalBtn.BackColor = Color.FromArgb(25, 15, 35);
            ugyfelekBtn.BackColor = Color.FromArgb(70, 40, 90);
            fejSzovegLbl.Text = ugyfelekBtn.Text;
             ugyfelekPnl.BringToFront();
        }

        private void szolgaltatasokBtn_Click(object sender, EventArgs e)
        {
            foOldalBtn.BackColor = Color.FromArgb(25, 15, 35);
            szolgaltatasokBtn.BackColor = Color.FromArgb(70, 40, 90);
            fejSzovegLbl.Text = szolgaltatasokBtn.Text;
            szolgaltatasPnl.BringToFront();
        }

        private void projektekBtn_Leave(object sender, EventArgs e)
        {
            projektekBtn.BackColor = Color.FromArgb(25, 15, 35);
        }

        private void ugyfelekBtn_Leave(object sender, EventArgs e)
        {
            ugyfelekBtn.BackColor = Color.FromArgb(25, 15, 35);
        }

        private void szolgaltatasokBtn_Leave(object sender, EventArgs e)
        {
            szolgaltatasokBtn.BackColor = Color.FromArgb(25, 15, 35);
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
                projektekBtn.BackColor = Color.FromArgb(70, 40, 90);
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
                projektekBtn.BackColor = Color.FromArgb(70, 40, 90);
            }
        }
    }
}
