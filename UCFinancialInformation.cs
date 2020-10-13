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
    public partial class UCFinancialInformation : UserControl
    {
       // private DataAccess Data{set;get;}
        public UCFinancialInformation()
        {
            InitializeComponent();
           // this.Data = new DataAccess();
            this.PupulateDataGridView();
        }

        private void PupulateDataGridView()
        {
            try
            {
                // this.dgvFinancialInfo.DefaultCellStyle.
                this.dgvFinancialInfo.AutoGenerateColumns = false;

                this.dgvFinancialInfo.DataSource = DataAccess.ExecuteQuery("select * from AllFinancialInformation");
                this.dgvFinancialInfo.ClearSelection();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
