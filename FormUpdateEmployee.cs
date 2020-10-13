using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRUpdate.DB;
using System.Net.Mail;

namespace HRUpdate
{
    public partial class FormUpdateEmployee : Form
    {
        DeligateForEmployee.DelegatePopulateDataGridView delGridView { set; get; }
        string count;
        private int DHCount { set; get; }
        private int ManagerCount { get; set; }
        private string Job { get; set; }
        private string gender;
        private string Id { get; set; }
        private string id, job;
        private int pass;
        bool update = false;
        private DataAccess Data { get; set; }

        private List<string> dept = new List<string>()
        {
            "hr-01",
            "it-01"
        };
        public FormUpdateEmployee(DeligateForEmployee.DelegatePopulateDataGridView delGridView,string id)
        {
            InitializeComponent();
            this.Data = new DataAccess();
            this.Id = id;
            this.delGridView = delGridView;
            this.Job = DataAccess.SingleVarification("select job from employee where id='" + this.Id + "'");
            
          //  this.job = this.cmbJob.SelectedItem.ToString();
           
            string sqlCount = "select count(*) from employee";
            
            int total = DataAccess.CountMethod(sqlCount) + 1;
         
            count = total.ToString("D4");
            this.id="un-"+count+"";
           // MessageBox.Show(this.id);
            this.txtId.Text = this.id;
            this.cmbDepertment.DropDownStyle= ComboBoxStyle.DropDownList;
            this.cmbJob.DropDownStyle= ComboBoxStyle.DropDownList;
            this.rbtnMale.Checked = true;

            if (Job == "manager")
            {

               
                this.cmbDepertment.DataSource = new List<string>
                {
                    "hr-01"
                };
            }
            else if (Job == "depertment head")
            {
              //  this.PopulateDataGridView("select * from employee where status='active' and depertmentid='it-01'");
                
                this.cmbDepertment.DataSource = new List<string>
                {
                    "it-01"
                };
            }
            else
            {
              //  this.PopulateDataGridView("select * from employee where status='active' and depertmentid='it-01'");
               
                this.cmbDepertment.DataSource = new List<string>
                {
                    "it-01",
                    "hr-01"

                };

            }




        }





        public FormUpdateEmployee(DeligateForEmployee.DelegatePopulateDataGridView delgrid,string id,List<string> employee)
        {
            InitializeComponent();
            this.Data = new DataAccess();
            this.Id = id;
            this.update = true;
            this.delGridView = delgrid;

            //  this.txtId.Visible= false;
            this.cmbDepertment.Enabled = false;
            this.cmbJob.Enabled = false;
            this.Job = DataAccess.SingleVarification("select job from employee where id='" + this.Id + "'");
            //  this.txtName.Text = dataTeble.Rows[0][1].ToString();
            this.txtId.Text = employee[0];
            this.txtName.Text = employee[1];
            this.cmbJob.Text = employee[2];
            this.txtSalary.Text = employee[3];
            if (employee[4] == "male")
                this.rbtnMale.Checked = true;
            else
                this.rbtnFemale.Checked = true;
            this.cmbDepertment.Text = employee[5];
            this.txtEmail.Text = employee[6];
           

            }




        














        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbDepertment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.DHCount = DataAccess.CountMethod("select count(*) from employee where job='depertment head' and status='active'");
            if (this.cmbDepertment.SelectedItem == "it-01")
            {
                if(this.DHCount==0)
                {
                    this.cmbJob.DataSource = new List<string>
                {
                    "depertment head",
                    "se",
                    "jse"

                };
                }
                else
                {
                    this.cmbJob.DataSource = new List<string>
                {
                    "se",
                    "jse"

                };
                }
                
            }
            else
            {
                this.ManagerCount = DataAccess.CountMethod("select count(*) from employee where job='manager' and status='active'");

                if(this.ManagerCount==0)
                {
                    this.cmbJob.DataSource = new List<string>
                {
                    "manager",
                    "staff"


                };
                }
                else
                {
                    this.cmbJob.DataSource = new List<string>
                {
                   
                    "staff"


                };
                }
                
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            if (this.update)
            {
                if (this.txtName.TextLength > 3 && this.txtEmail.TextLength > 10 && this.txtSalary.TextLength > 2)
                {
                    string updateSql = "update employee set name='" + this.txtName.Text + "',salary='" + this.txtSalary.Text + "',gender='"+ this.gender +"',email='" + this.txtEmail.Text + "' where id='" + this.txtId.Text + "'";
                    if (DataAccess.ExecuteUpdate(updateSql) > 0)
                    {
                        MessageBox.Show("Updated Successful");
                        this.delGridView("");
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("Updated Fail");


                }
                else
                    MessageBox.Show("Please Fill up all the information properly");

            }
            else
            {
                Random rnd = new Random();
                pass = rnd.Next(11111, 99999);




                if (this.rbtnMale.Checked)
                {
                    this.gender = "male";
                }
                else if (this.rbtnFemale.Checked)
                {
                    this.gender = "female";
                }



                //  MessageBox.Show(id);

                if (this.txtName.TextLength > 3 && this.txtEmail.TextLength > 10 && this.txtSalary.TextLength > 2)
                {

                    string sqlAdd = "insert into Employee Values('" + this.id + "', '" + this.txtName.Text + "', '" + this.cmbJob.SelectedItem + "', '" + this.txtSalary.Text + "', '" + pass.ToString() + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "',0, '" + this.gender + "', '" + this.cmbDepertment.SelectedItem + "', '" + this.txtEmail.Text + "','active')";
                    string presenceSql = "insert into presence values('" + this.id + "','Current','" + DateTime.Today.ToString("yyyy-MM-dd") + "',0)";

                    // MessageBox.Show(sqlAdd);




                    //this.PopulateDataGridView();

                    try
                    {
                       
                       
                           
                            string sqlCount = "select count(*) from employee";

                           

                        
                           
                           // this.delGridView(" ");
                            MailMessage mail = new MailMessage("badhon1512@gmail.com", this.txtEmail.Text, "User Info", "Your  UserId-" + this.id + " and Password-" + this.pass.ToString() + "");
                            SmtpClient client = new SmtpClient("smtp.gmail.com");
                            client.Port = 587;
                            client.Credentials = new System.Net.NetworkCredential("badhon1512@gmail.com", "ba01751467587");
                            client.EnableSsl = true;
                            client.Send(mail);
                          
                           
                           

                          MessageBox.Show("Details Information sent to email");
                        int check = DataAccess.ExecuteUpdate(sqlAdd);
                        DataAccess.ExecuteUpdate(presenceSql);
                        int total = DataAccess.CountMethod(sqlCount) + 1;
                        count = total.ToString("D4");
                        this.id = "un-" + count + "";
                        //  MessageBox.Show(this.id);
                        this.txtId.Text = this.id;
                        if (check>0)
                        {
                            MessageBox.Show("" + this.txtName.Text + " added successfully");
                            this.delGridView("");
                            ClearAll();
                        }
                        else
                            MessageBox.Show("" + this.txtName.Text + " added Failure");







                    }
                    catch (Exception ea)
                    {
                       // MessageBox.Show(ea.Message);
                    }
                }
                else
                    MessageBox.Show("Please Fill up all the information properly");
            }

        }
          

        private void ClearAll()
        {
            this.txtEmail.Clear();
            this.txtName.Clear();
            this.txtSalary.Clear();
            if(this.cmbDepertment.Text=="hr-01")
                {
                this.cmbDepertment.Text = "it-01";
                this.cmbJob.Text = "se";
            }
            else
            {
                this.cmbDepertment.Text = "hr-01";
                this.cmbJob.Text = "staff";
            }
            
            
        }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int salary = Convert.ToInt32(DataAccess.SingleVarification("Select salary from salary where job='" + this.cmbJob.Text + "'"));
                this.txtSalary.Text = salary.ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            this.gender="male";
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            this.gender = "female";
        }

        private void FormUpdateEmployee_Load(object sender, EventArgs e)
        {
            
                this.Size = new Size(this.Size.Width, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            // this.CenterToScreen()
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormUpdateEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

       
    }
}


   

















 