using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ksyusha.Services;
using ksyusha;
using MaterialSkin.Controls;
namespace KingIT_KravchenkoVasileva_ISiP321.Manager_C
{
    public partial class SearchTC : MaterialForm
    {
        DatabaseService database = new DatabaseService();
        
        public SearchTC()
        {
            InitializeComponent();
        }
        
        private void SearchTC_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchTC_Click(object sender, EventArgs e)
        {
            Command search_tc = new Command();
            search_tc.LoadData("Select * From TC Where TitleTC = '" + txtNameTC.Text + "'");
            if (search_tc.MainTable.Rows.Count > 0)
            {
                LoadSearchTC();
                
            }
            else
            {
                MessageBox.Show("такого ТЦ нет, проверьте поиск,возможно вы ошиблись");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ManagerC managForm = new ManagerC();
            managForm.Show();
            this.Hide();
        }

        private void txtNameTC_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadSearchTC()
        {
           

        }
        
        
    }
}
