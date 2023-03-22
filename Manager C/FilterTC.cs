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

namespace KingIT_KravchenkoVasileva_ISiP321.Manager_C
{
    public partial class FilterTC : MaterialForm
    {
        public FilterTC()
        {
            InitializeComponent();
        }

        private void FilterTC_Load(object sender, EventArgs e)
        {

        }

        private void materialCheckbox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ManagerC managForm = new ManagerC();
            managForm.Show();
            this.Hide();
        }

        private void cbPlan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbBuild_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbMake_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
