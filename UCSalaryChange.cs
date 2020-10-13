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
    public partial class UCSalaryChange : UserControl
    {
        public UCSalaryChange()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtSalary.Text = DataAccess.SingleVarification("Select salary from salary where job='" + this.cmbEmp.Text + "'");

            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
        private void PopulateDataGrid()
        {
            try
            {
                this.dgvSalary.DataSource = DataAccess.ExecuteQuery("Select * from salary");

            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Salary value update.?","Confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    if (DataAccess.ExecuteUpdate("update salary set salary=" + this.txtSalary.Text + " where job='" + this.cmbEmp.Text + "'") == 1)
                    {
                        PopulateDataGrid();
                        MessageBox.Show("Salary updated successfully");

                    }
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.Message);
                }
            }
        }
    }
}
