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
    public partial class UCSelfInformation : UserControl
    {

      //  private DataAccess Data { get; set; }
        //   private string Id { set; get; }
        private DataTable Dt { set; get; }
       
        public UCSelfInformation(string id)
        {
            InitializeComponent();
          //  Data = new DataAccess();

            //this.Id = id;
            try
            {
                string sql = "Select * from employee where id='" + id + "'";
                Dt = DataAccess.ExecuteQuery(sql);
                this.lblId.Text = Dt.Rows[0][0].ToString();
                this.lblName.Text = Dt.Rows[0][1].ToString();
                this.lblDept.Text = Dt.Rows[0][8].ToString();
                this.lblJob.Text = Dt.Rows[0][2].ToString();
                this.lblEmail.Text = Dt.Rows[0][9].ToString();
                this.lblSalary.Text = Dt.Rows[0][3].ToString();
            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }



        }
    }
   

    }

