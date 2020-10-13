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
    public partial class UCLeaveApplication : UserControl
    {
        private string Id { set; get; }
        private int Pending { set; get; } 
        private int LeaveDays { set; get; }
       // private DataAccess Data { set; get; }
        public UCLeaveApplication(string id)
        {
            InitializeComponent();
            this.Id = id;
          //  this.Data = new DataAccess();
            this.cmbCause.Text = "Personal issue";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UCLeaveApplication_Load(object sender, EventArgs e)
        {
            try
            {
                this.dtpFrom.MinDate = DateTime.Now.Date;
                this.dtpTo.MinDate = DateTime.Now.Date;
                string sql = "select IsNull(sum(duration),0) from leaveStatus where id = '" + this.Id + "' and finalStatus='accept' and Month(toDate)= MONTH(CURRENT_TIMESTAMP)";
                this.LeaveDays = DataAccess.CountMethod(sql);
                this.lblLeave.Text = this.LeaveDays.ToString() + " days ";
                string sqlPending = "select IsNull(sum(duration),0) from leaveStatus where id = '" + this.Id + "' and finalStatus='pending' and Month(toDate)= MONTH(CURRENT_TIMESTAMP)";
                this.Pending = DataAccess.CountMethod(sqlPending);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            //  MessageBox.Show(this.Padding.ToString());


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try { 
            TimeSpan diff = this.dtpTo.Value -this.dtpFrom.Value;
            int days = diff.Days + 1;
           // MessageBox.Show(days.ToString());
            string sqlleave = "select IsNull(sum(duration),0) from leaveStatus where id = '" + this.Id + "' and finalStatus='accept' and Month(toDate)= MONTH(CURRENT_TIMESTAMP)";
            this.LeaveDays = DataAccess.CountMethod(sqlleave);
           // MessageBox.Show(this.LeaveDays.ToString());
                
            this.lblLeave.Text = this.LeaveDays.ToString() + " days ";
            string sqlPending = "select IsNull(sum(duration),0) from leaveStatus where id = '" + this.Id + "' and finalStatus='pending' and Month(toDate)= MONTH(CURRENT_TIMESTAMP)";
            this.Pending =Convert.ToInt32( DataAccess.SingleVarification(sqlPending));
                //   MessageBox.Show(this.Padding.ToString());
                if (this.LeaveDays >= 5)
                {
                    MessageBox.Show("No leave available for this month");
                    // this.btnSubmit.Enabled = false;
                }
                else if (this.LeaveDays + days > 5)
                {
                    MessageBox.Show("You have  only " + (5 - LeaveDays) + " days leave remain");
                }
                //else if(Leave)




                else if (this.dtpFrom.Value.Date > this.dtpTo.Value.Date)
                {
                    MessageBox.Show("Invalid Date Selection");
                }
                else if (this.dtpFrom.Value.Month != this.dtpTo.Value.Month)
                {
                    MessageBox.Show("You can't take leave advance for next month");
                }

                else if (this.Pending >= 0)
                    MessageBox.Show("Already your leave application is pending, please contact with HR");
                //  else if(this.dtpTo.Value.Date-this.dtpFrom.Value.Date>5)
                else
                {
                    string depertment;
                    string sqldept = "select depertmentid from employee where id='" + this.Id + "'";
                    depertment = DataAccess.SingleVarification(sqldept);


                    // MessageBox.Show(days.ToString());
                    days++;
                    try
                    {
                        string sql = "insert into leaveStatus values('" + this.Id + "','" + this.cmbCause.Text + "','pending','pending','unseen','" + this.dtpFrom.Text + "','" + this.dtpTo.Text + "'," + days + ",'" + depertment + "','pending')";

                        int result = DataAccess.ExecuteUpdate(sql);
                        if (result >= 1)
                            MessageBox.Show("Leave Application Submitted Successfully..");
                        else
                            MessageBox.Show("Leave Application Submitted Not Successfully..");
                    }
                    catch (Exception ea)
                    {
                        MessageBox.Show(ea.Message);
                    }

                }




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
