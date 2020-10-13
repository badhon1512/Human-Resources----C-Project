using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRUpdate.DB;

namespace HRUpdate
{
   
    public partial class UCSalary : UserControl
    {
      //  private DataAccess Data { set; get; }
        public UCSalary()
        {
            InitializeComponent();
           // this.Data = new DataAccess();
            this.cmbMonth.Text = System.DateTime.Now.ToString("MMMM");
            this.PupulateDataGridView();

        }

        private void PupulateDataGridView()
        {
            try {
                this.dgvMonthlySalary.DataSource = DataAccess.ExecuteQuery("select* from monthlySalary where _MonthName = '" + this.cmbMonth.Text + "'");

            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PupulateDataGridView();
        }
    }
}
