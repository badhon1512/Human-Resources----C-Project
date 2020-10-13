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
    public partial class UCEmployeeInformation : UserControl
    {
       // public delegate void DelPupulateDataGridView(string sql);

      //  private DataAccess Data { set; get; }
        private string Id { set; get; }
        private string Job { set; get; }

        public UCEmployeeInformation(string id)
        {
            
            InitializeComponent();
           // this.Data = new DataAccess();
            this.Id = id;
            try
            {
                this.Job = DataAccess.SingleVarification("select job from employee where id='" + this.Id + "'");
                //  DelPupulateDataGridView delDgv = this.PopulateDataGridView;
                //   delGridView = this.PopulateDataGridView;
                //MessageBox.Show(Job);
                if (Job == "manager")
                {
                    this.PopulateDataGridView();
                    // this.PopulateDataGridView("select * from employee where status='active' depertmentid='hr-01'");
                }
                else if (Job == "depertmnt head")
                {
                    this.PopulateDataGridView();
                    // this.PopulateDataGridView("select * from employee where depertmentid='it-01'");
                }
                else
                    this.PopulateDataGridView();
                this.cmbEmp.SelectedItem = "All";
            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }


        }


        
        private void PopulateDataGridView(string sql = "")
        {
            try
            {
                if (sql == "" && this.Job == "hr")
                    sql = "select * from employee where status='active'";
                else if (sql == "" && this.Job == "manager")
                    sql = "select * from employee where depertmentid='hr-01' and status='active'";
                if (sql == "" && this.Job == "depertment head")
                    sql = "select * from employee where depertmentid='it-01' and status='active'";


                this.dgvEmployeeInformation.AutoGenerateColumns = false;
                this.dgvEmployeeInformation.ScrollBars = ScrollBars.Both;

                DataTable dt = DataAccess.ExecuteQuery(sql);
                this.dgvEmployeeInformation.AutoGenerateColumns = false;
                this.dgvEmployeeInformation.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (this.txtSearch.Text != "Search")
                {
                    this.cmbEmp.SelectedItem = "All";
                    this.cmbEmp.Text = "All";
                    if (this.Job == "hr")
                    {
                        this.PopulateDataGridView();
                        string sql = "select * from employee where status='active' and name like'" + this.txtSearch.Text + "%'";
                        this.PopulateDataGridView(sql);

                    }


                    else if (this.Job == "manager")
                    {
                        this.PopulateDataGridView("select * from employee where depertmentid='hr-01'");
                        string sql = "select * from employee where depertmentid='hr-01' and status='active' and name like'" + this.txtSearch.Text + "%'";
                        this.PopulateDataGridView(sql);
                    }
                    else if (this.Job == "depertment head")
                    {
                        this.PopulateDataGridView("select * from employee where depertmentid='it-01'");
                        string sql = "select * from employee where depertmentid='it-01' and status='active' and name like'" + this.txtSearch.Text + "%'";
                        this.PopulateDataGridView(sql);
                    }



                }
            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtSearch.Clear();

                if (this.cmbEmp.Text == "All" && Job == "hr")
                {

                    this.PopulateDataGridView();
                }
                else if (this.cmbEmp.Text == "All" && Job == "manager")
                    this.PopulateDataGridView("select * from employee where depertmentid='hr-01' and status='active'");
                else if (this.cmbEmp.Text == "All" && Job == "depertment head")
                    this.PopulateDataGridView("select * from employee where depertmentid='it-01' and status='active'");
                else

                    this.PopulateDataGridView("select * from employee where status='active' and job='" + this.cmbEmp.Text + "' ");

            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }


        }

        private void UCEmployeeInformation_Load(object sender, EventArgs e)
        {
          if(this.Job=="manager")
            {
                this.cmbEmp.DataSource =new List<string>{
                    "All",
                    "manager",
                    "staff",
                    
                };
            }
          else if(this.Job == "depertment head")
          {
                this.cmbEmp.DataSource = new List<string>{
                    "All",
                    "se",
                    "jse",
                    "depertment head"
                };
            }
            else if (this.Job == "hr")
            {
                this.cmbEmp.DataSource = new List<string>{
                    "All",
                    "manager",
                    "staff",
                    "se",
                    "jse",
                    "hr",
                    "depertment head"
                };
            }
        }

        private void dgvEmployeeInformation_DoubleClick(object sender, EventArgs e)
        {
            //this.dgvEmployeeInformation.CurrentRow.Co
          
        }

        private void dgvEmployeeInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {


         DeligateForEmployee.DelegatePopulateDataGridView delGridView =this.PopulateDataGridView;
         new FormUpdateEmployee(delGridView,this.Id).Visible = true;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // this.dgvEmployeeInformation_CellContextMenuStripNeeded(sender, e);
                if (this.dgvEmployeeInformation.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select a Employee .!");
                }
                else if (this.dgvEmployeeInformation.CurrentRow.Cells["job"].Value.ToString() == "hr")
                {
                    MessageBox.Show("Sorry HR is primary user");
                }
                else if (this.dgvEmployeeInformation.CurrentRow.Cells["job"].Value.ToString() == "manager" && this.Job == "manager")
                {
                    MessageBox.Show("You can't delete yourself");
                }
                else if (this.dgvEmployeeInformation.CurrentRow.Cells["job"].Value.ToString() == "depertment head" && this.Job == "depertment head")
                {
                    MessageBox.Show("You can't delete yourself");
                }

                else
                {
                    string id = this.dgvEmployeeInformation.CurrentRow.Cells["id"].Value.ToString();
                    if ((MessageBox.Show("Are you sure to delete id :" + id + "  ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        string sql = "UPDATE employee SET status = 'resigned' where id = '" + id + "'";
                        MessageBox.Show(sql);
                        int count = DataAccess.ExecuteUpdate(sql);
                        if (count == 1)
                        {

                            MessageBox.Show("Id " + id + " deleted successfully");
                            this.PopulateDataGridView();
                        }
                        else
                            MessageBox.Show("Id " + id + " delete Failure");

                    }
                }
            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);

            }
              


        }

        private void dgvEmployeeInformation_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            
               
           
           
           

        }

        private void refToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                this.PopulateDataGridView();


        }

        private void updateEmployeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DeligateForEmployee.DelegatePopulateDataGridView delGridView = this.PopulateDataGridView;
                if (this.dgvEmployeeInformation.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select a Employee .!");
                }
                else if (this.dgvEmployeeInformation.CurrentRow.Cells["job"].Value.ToString() == this.Job && this.Job != "hr")
                {
                    MessageBox.Show("Sorry you can't update your own information ");
                }
                else if (this.dgvEmployeeInformation.CurrentRow.Cells["job"].Value.ToString() == "hr" && this.Job != "hr")
                {
                    MessageBox.Show("Sorry you can't  update HR's information ");
                }
                else
                {
                    DeligateForEmployee.DelegatePopulateDataGridView delGridViewUpdate = this.PopulateDataGridView;
                    string id = this.dgvEmployeeInformation.CurrentRow.Cells["id"].Value.ToString();
                    List<string> employee = new List<string>
                {
                   this.dgvEmployeeInformation.CurrentRow.Cells["id"].Value.ToString(),
                   this.dgvEmployeeInformation.CurrentRow.Cells["name"].Value.ToString(),
                   this.dgvEmployeeInformation.CurrentRow.Cells["job"].Value.ToString(),
                   this.dgvEmployeeInformation.CurrentRow.Cells["salary"].Value.ToString(),
                   this.dgvEmployeeInformation.CurrentRow.Cells["gender"].Value.ToString(),
                   this.dgvEmployeeInformation.CurrentRow.Cells["deptid"].Value.ToString(),
                   this.dgvEmployeeInformation.CurrentRow.Cells["email"].Value.ToString()
            };

                    if ((MessageBox.Show("Are you sure to update id :" + id + "'s Information  ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        new FormUpdateEmployee(delGridViewUpdate, this.Id, employee).Visible = true;

                    }



                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }
        }
}

