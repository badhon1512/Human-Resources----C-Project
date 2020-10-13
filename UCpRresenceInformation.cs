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
    public partial class UCPrresenceInformation : UserControl
    {
        //private DataAccess Data { set; get; }
        public UCPrresenceInformation()
        {
            InitializeComponent();
            // this.Data = new DataAccess();
            this.PopolateDataGridView("select * from monthlyPresence");
        }
        private void PopolateDataGridView(string sql)
        {
            this.dgvPresenceInfo.DataSource = DataAccess.ExecuteQuery(sql);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        
            try
            {
            this.PopolateDataGridView("select * from monthlyPresence where _monthName='"+this.cmbMonth.Text+"'");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }


        }
    }
}
