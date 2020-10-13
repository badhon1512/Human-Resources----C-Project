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
    public partial class UCResignEmployee : UserControl
    {
        private string Id { set; get; }
        private string Name { get; set; }
      //  private DataAccess Data { set; get; }
        private string  EmpJob{set;get;}

        public UCResignEmployee()
        {
            InitializeComponent();
          //  this.Data = new DataAccess();
            this.cmbEmp.SelectedItem = "All";

          //  this.txtSearch.Text = "Search";
          //  this.txtSearch.ForeColor = Color.DimGray;
            this.PopulateDataGridView();



        }
        private void PopulateDataGridView(string sql = "select * from employee where status='resigned'")
        {
            try
            {
                DataTable dt = DataAccess.ExecuteQuery(sql);
                this.dgvEmployeeInformation.AutoGenerateColumns = false;
                this.dgvEmployeeInformation.DataSource = dt;
                this.dgvEmployeeInformation.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.txtSearch.Text = "Search";
           // this.txtSearch.ForeColor = Color.DimGray; this.txtSearch.Text = "Search";
           // this.txtSearch.ForeColor = Color.DimGray;
            if (cmbEmp.SelectedItem == "All")
                this.PopulateDataGridView();
            else if (this.cmbEmp.SelectedItem == "Staff")

                this.PopulateDataGridView("select * from employee where job = 'staff' and status='deactivate';");
            else if (this.cmbEmp.SelectedItem == "Hr")
                this.PopulateDataGridView("select * from employee where job='hr' and status='deactivate';");
            else if (this.cmbEmp.SelectedItem == "Se")
                this.PopulateDataGridView("select * from employee where job = 'se' and status='resigned';");
            else if (this.cmbEmp.SelectedItem == "Jse")
                this.PopulateDataGridView("select * from employee where job = 'jse' and status='resigned';");
            else if (this.cmbEmp.SelectedItem == "Manager")
                this.PopulateDataGridView("select * from employee where job = 'manager' and status='resigned';");
            else if (this.cmbEmp.SelectedItem == "Hepertment Head")
                this.PopulateDataGridView("select * from employee where job = 'depertment head' and status='resigned';");
            else if (this.cmbEmp.SelectedItem == "It")
                this.PopulateDataGridView("select * from employee where depertmentid='it-01' and status='resigned';");
            else
                this.PopulateDataGridView();


        }

        private void btnReJoin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.EmpJob == "manager" || this.EmpJob == "depertment head")
                {
                    MessageBox.Show("Sorry this type of user can't be allow to re-joining");
                }
                else if (Id != null)
                {
                    if (MessageBox.Show("Confirm rejoining " + this.Name + "?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sql = "UPDATE employee SET status = 'active' WHERE id = '" + this.Id + "';";
                        int count = DataAccess.ExecuteUpdate(sql);
                        if (count > 0)
                        {
                            MessageBox.Show("Rejoining Successful of " + this.Name);
                        }
                        else
                            MessageBox.Show("Rejoining Failure of " + this.Name);

                        this.PopulateDataGridView();
                    }


                }
                else
                    MessageBox.Show("You don't select any Employee");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            } 
        }

        private void dgvEmployeeInformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmpJob= this.dgvEmployeeInformation.CurrentRow.Cells["job"].Value.ToString();
            this.Id = this.dgvEmployeeInformation.CurrentRow.Cells["id"].Value.ToString();
            this.Name= this.dgvEmployeeInformation.CurrentRow.Cells["name"].Value.ToString();
        }

        private void UCResignEmployee_Load(object sender, EventArgs e)
        {
          //  this.btnReJoin.Visible = false;
            this.PopulateDataGridView();
        }
    }
}
