using HRUpdate.HR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRUpdate.DB;

using System.Data;
using HRUpdate.HR.Entity;






namespace HRUpdate.HR.Repo
{
    class ProjectRevenueRepository
    {

       // private DataAccess data { get; set; }
        public List<ProjectRevenue> GetProjectRevenue()
        {
            try
            {
                // this.data = new DataAccess();
                var productList = new List<ProjectRevenue>();
                var sql = "select * from projectRevenue";
                var dt = DataAccess.ExecuteQuery(sql);

                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    ProjectRevenue p = ConvertToEntity(dt.Rows[index]);
                    productList.Add(p);
                }
                return productList;
            }
            catch (Exception ea)
            {
                //  MessageBox.Show(ea.Message);
                return null;

            }
        }

        private ProjectRevenue ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var p = new ProjectRevenue();
            p.id = Convert.ToInt32(row["id"].ToString());
            p.projectName = row["projectName"].ToString();
            p.month = row["month"].ToString();
           
            p.price =Convert.ToInt32( (row["price"]));
            return p;
        }


        public bool AddProject(string sql)
        {

           // string sql = "insert into projectRevenue values('" + this.txtName.Text + "','" + this.cmbMonth.Text + "'," + this.txtPrice.Text + ")";
            int count = DataAccess.ExecuteUpdate(sql);
            if (count == 1)
                return true;

            else
                return false;
        }

       

    }
}
