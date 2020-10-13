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
    public partial class UCHRDepertmentInformation : UserControl
    {
       // private DataAccess Data { set; get; }
        public UCHRDepertmentInformation()
        {
            InitializeComponent();
           // this.Data = new DataAccess();
        }//

        private void UCHRDepertmentInformation_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblStaff.Text = DataAccess.CountMethod("select count(*) from employee where job = 'staff' and status='active';").ToString();
                //this.lblSe.Text = Data.CountMethod("select count(*) from employee where job = 'se' and status='active';").ToString();
                this.lblEmpTotal.Text = DataAccess.CountMethod("select count(*) from employee where depertmentid = 'hr-01' and status='active';").ToString();
                this.lblManager.Text = DataAccess.SingleVarification("select name from employee where job='manager' and status='active'");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
    }
}
