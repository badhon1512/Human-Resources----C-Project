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
using HRUpdate.HR.Repo;
using HRUpdate.HR.Entity;

namespace HRUpdate
{
    public partial class UCRevenue : UserControl
    {
        private ProjectRevenueRepository Repo { set; get; }
        private DataAccess Data { set; get; }
        public UCRevenue()
        {
            InitializeComponent();
            this.Repo = new ProjectRevenueRepository();
            this.Data = new DataAccess();
            this.PopolateDataGridView();
        }

        private void PopolateDataGridView()
        {
            this.dgvProject.DataSource = Repo.GetProjectRevenue().ToList();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtName.TextLength > 2 && this.txtPrice.TextLength > 2)
            {
                if(MessageBox.Show("Are you sure to add the project","confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    string sql = "insert into projectRevenue values('" + this.txtName.Text + "','" + this.cmbMonth.Text + "',"+this.txtPrice.Text+")";
                    if(Repo.AddProject(sql))
                        MessageBox.Show("Project added successfully");
                    else
                        MessageBox.Show("Project added Failure");
                    this.PopolateDataGridView();

                    this.txtName.Clear();
                    this.txtPrice.Clear();
                }

            }
            else
                MessageBox.Show("Please Fill up all the information");
        }
    }
}
