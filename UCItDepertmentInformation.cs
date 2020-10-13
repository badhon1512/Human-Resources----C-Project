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
    public partial class UCItDepertmentInformation : UserControl
    {
       // private DataAccess Data { get; set; }
        public UCItDepertmentInformation()
        {
            InitializeComponent();
           // Data = new DataAccess();
        }

        private void UCItDepertmentInformation_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblJse.Text = DataAccess.CountMethod("select count(*) from employee where job = 'jse' and status='active';").ToString();
                this.lblSe.Text = DataAccess.CountMethod("select count(*) from employee where job = 'se' and status='active';").ToString();
                this.lblEmpTotal.Text = DataAccess.CountMethod("select count(*) from employee where depertmentid = 'it-01' and status='active';").ToString();
                this.lblDeptHead.Text = DataAccess.SingleVarification("select name from employee where job='depertment head' and status='active'");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
    }
}
