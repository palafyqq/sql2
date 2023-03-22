using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using ksyusha.Services;
using System.Data.SqlClient;
using KingIT_KravchenkoVasileva_ISiP321.Manager_C;
using ksyusha;
using System.Security.Policy;

namespace KingIT_KravchenkoVasileva_ISiP321.Manager_C
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class ManagerC : MaterialForm
    {
        DatabaseService database = new DatabaseService();
        int selectedRow;



        public ManagerC()
        {
            InitializeComponent();
        }




        private void Manager_C_Load(object sender, EventArgs e)
        {
            LoadDataTableTC();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvTC.Rows.Clear();

            string queryString = "Select * From TC";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

            }
            reader.Close();
        }
        private void LoadDataTableTC()
        {
            DgvTC();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTC searchForm = new SearchTC();
            searchForm.Show();
            this.Hide();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterTC filterForm = new FilterTC();
            filterForm.Show();
            this.Hide();

        }



        public void DgvTC()
        {

            Command load_tc = new Command();
            load_tc.LoadData("Select * From TC");
            dgvTC.DataSource = load_tc.MainTable;


        }






    }

}
