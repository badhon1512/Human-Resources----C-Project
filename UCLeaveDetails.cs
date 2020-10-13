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
    public partial class UCLeaveDetails : UserControl
    {
        //private DataAccess Data { set; get; }
        private DataTable Dt { set; get; }
        private string Sql { set; get; }
        private string Job { set; get; }
        public UCLeaveDetails(string job)
        {
            InitializeComponent();
          //  this.Data =new DataAccess();
            //this.Data = new DataTable();
            this.Job = job;
        }
        private void PopulateDataGridView(string sql)
        {
            //string sql = " select * from leavestatus where deptStatus = 'pending'";
            try
            {
                this.Dt = DataAccess.ExecuteQuery(sql);

                this.dgvLeave.AutoGenerateColumns = false;
                this.dgvLeave.DataSource = this.Dt;
            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void UCLeaveDetails_Load(object sender, EventArgs e)
        {
            if(this.Job=="manager")
                this.Sql = "select * from leavestatus where deptStatus = 'pending' and depertment='hr-01'";
            else if(this.Job=="depertment head")
                this.Sql = "select * from leavestatus where deptStatus = 'pending' and depertment='it-01'";
            else if(this.Job=="hr")
                this.Sql = "select * from leavestatus where deptStatus = 'accept'";

            this.cmbStatus.Text = "Pending";


            this.PopulateDataGridView(this.Sql);

        }

        private void dgvLeave_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex == 1)
                {
                   // MessageBox.Show("Yes");
                }
                // you now have the selected row with the context menu showing for the user to delete etc.
            }
        }

        private void dgvLeave_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
           
           
                this.dgvLeave.ClearSelection();
           
          //  MessageBox.Show(id.ToString());
            if(this.cmbStatus.Text=="Pending")
            {
                int rowSelected = e.RowIndex;
                
                if (e.RowIndex != -1)
                {
                    var applicationNo = this.dgvLeave.Rows[e.RowIndex].Cells["applicationNo"].Value;
                    var leaveid = this.dgvLeave.Rows[e.RowIndex].Cells["id"].Value;
                    this.dgvLeave.Rows[rowSelected].Selected = true;
                   string status= CustomMessageBox.Show("Leave Application", "What do you want", "Accept", "Reject");

                    try
                    {
                        if (status == "Yes")
                        {
                            DialogResult confirm = MessageBox.Show("confirmation of application no " + applicationNo + "'s acceptation?", "Confirmation", MessageBoxButtons.YesNo);
                            if (confirm == DialogResult.Yes)
                            {
                                if (this.Job == "hr")
                                {



                                    this.Sql = "UPDATE leaveStatus SET finalStatus='accept' where applicationNo=" + applicationNo + "";
                                  DataAccess.ExecuteUpdate("insert into notification values('" + leaveid + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "', 'Leave application accepted', 'unseen')");

                                }
                                else
                                    this.Sql = "UPDATE leaveStatus SET deptStatus='accept' where applicationNo=" + applicationNo + "";


                                int count = DataAccess.ExecuteUpdate(this.Sql);
                                if (count > 0)
                                {
                                    MessageBox.Show("Application Accepted Successfully");
                                    if (this.Job == "hr")
                                        this.Sql = " select * from leavestatus where deptStatus = 'accept' and finalStatus='pending'";
                                    else if (this.Job == "manager")
                                        this.Sql = " select * from leavestatus where deptStatus = 'pending' and depertment='hr-01'";
                                    else if (this.Job == "depertment head")
                                        this.Sql = " select * from leavestatus where deptStatus = 'pending' and depertment='it-01'";
                                    this.PopulateDataGridView(this.Sql);
                                }
                                    
                                else
                                    MessageBox.Show("Application Accepted Failure"); 

                            }
                        }
                        else if (status == "No")
                        {
                            DialogResult confirm = MessageBox.Show("confirmation of application no " + applicationNo + "'s rejection?", "Confirmation", MessageBoxButtons.YesNo);
                            if (confirm == DialogResult.Yes)
                            {
                                this.Sql = "UPDATE leaveStatus SET deptStatus ='reject' where applicationNo=" + applicationNo + "";

                                int count = DataAccess.ExecuteUpdate(this.Sql);
                                if (count > 0)
                                {
                                    MessageBox.Show("Application Rejected Successfully");
                                    if (this.Job == "hr")
                                        this.Sql = " select * from leavestatus where deptStatus = 'accept' and finalStatus='pending'";
                                    else if (this.Job == "manager")
                                        this.Sql = " select * from leavestatus where deptStatus = 'pending' and depertment='hr-01'";
                                    else if (this.Job == "depertment head")
                                        this.Sql = " select * from leavestatus where deptStatus = 'pending' and depertment='it-01'";
                                    this.PopulateDataGridView(this.Sql);

                                    DataAccess.ExecuteUpdate("insert into notification values('" + leaveid + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "', 'Leave application rejected', 'unseen')"); 


                                }

                                else
                                    MessageBox.Show("Application Rejected Failure");

                            }
                        }
                    }
                    catch(Exception ea)
                    {
                        MessageBox.Show(ea.Message);
                    }

                   


                }
            }
               
            
            
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string sql;
            if(this.cmbStatus.Text=="All")
            {
                if(this.Job=="hr")
                 this.Sql = " select * from leavestatus where not finalStatus='pending'";
                else if(this.Job=="manager")
                    this.Sql = " select * from leavestatus where not finalStatus='pending' and depertment='hr-01'";
                else if (this.Job == "depertment head")
                    this.Sql = " select * from leavestatus where not finalStatus='pending' and depertment='it-01'";



            }
            else
            {
                if(this.Job=="hr")
                this.Sql = " select * from leavestatus where deptStatus = 'accept' and finalStatus='pending'";
               else if (this.Job == "manager")
                    this.Sql = " select * from leavestatus where deptStatus = 'pending' and depertment='hr-01'";
                else if(this.Job=="depertment head")
                    this.Sql = " select * from leavestatus where deptStatus = 'pending' and depertment='it-01'";



            }
            this.PopulateDataGridView(this.Sql);
        }
    }
}
