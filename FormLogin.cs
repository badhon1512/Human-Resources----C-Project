using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using HRUpdate.DB;
using System.Globalization;
//using HRUpdate.EF;
//using System.Data.Entity;




namespace HRUpdate
{
    public partial class FormLogin : Form
    {
        //   employee Emp = new employee();
        DataTable DT { set; get; }

     // private DataAccess Data { get; set; }
        private string Date { set; get; }
        private TimeSpan Systime { set; get; }
        private TimeSpan time { set; get; }
        private String[] splitDate;
        public FormLogin()
        {
            InitializeComponent();
            // Emp = new employee();
           // Data = new DataAccess();

        }

        private void MakeDefault()
        {
            this.txtPasswordd.PasswordChar = '\0';
            this.txtPasswordd.Text = "Password";

            this.txtPasswordd.ForeColor = Color.DimGray;
            this.txtUserName.Text = "UserId";
            this.txtUserName.ForeColor = Color.DimGray;
        }
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == "UserId")
            {
                this.txtUserName.Text = "";
                this.txtUserName.ForeColor = Color.LightGray;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == "")
            {
                this.txtUserName.Text = "UserId";
                this.txtUserName.ForeColor = Color.DimGray;
            }
        }

        private void txtPasswordd_Leave(object sender, EventArgs e)
        {
            if (this.txtPasswordd.Text == "")
            {
                this.txtPasswordd.PasswordChar = '\0';
                this.txtPasswordd.Text = "Password";

                this.txtPasswordd.ForeColor = Color.DimGray;
            }
        }

        private void txtPasswordd_Enter(object sender, EventArgs e)
        {
            if (this.txtPasswordd.Text == "Password")
            {
                this.txtPasswordd.Text = "";
                this.txtPasswordd.PasswordChar = '*';
                this.txtPasswordd.ForeColor = Color.LightGray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "select job from employee where id = '" + this.txtUserName.Text + "' and password = '" + this.txtPasswordd.Text + "' and status='active'";
                string job = DataAccess.SingleVarification(sql);

                this.Systime = DateTime.Now.TimeOfDay;
                this.time = new TimeSpan(1, 0, 0, 0);



                if (this.txtUserName.Text == "UserId" && this.txtPasswordd.Text == "Password")
                {
                    MessageBox.Show("Please Enter your user name and password");
                }
                else if (job == "hr")
                {

                    MessageBox.Show("Login Successful");
                    new FormHR(this, this.txtUserName.Text).Visible = true;
                    this.Date = DataAccess.SingleVarification("Select currentDate from presence where id='" + this.txtUserName.Text + "'");
                    // this.splitDate = this.Date.Split(null);
                    // /this.Date = this.splitDate[0];
                    // MessageBox.Show("yes");
                    // MessageBox.Show(this.Systime.ToString("H:mm"));
                    //  MessageBox.Show("yes 1");

                    //  MessageBox.Show(this.time.ToString("H:mm"));
                    // MessageBox.Show(System.DateTime.Now.Hour.ToString());
                    //    if ((DateTime.Parse(this.Date).ToString("MM/dd/yyyy") != DateTime.Today.ToString("MM/dd/yyyy")))
                    this.Visible = false;

                    if (DateTime.Parse(this.Date).ToString("MM/dd/yyyy") != DateTime.Today.ToString("MM/dd/yyyy"))
                    {
                        if (System.DateTime.Now.Hour <= 11)
                        {
                            // MessageBox.Show("In Time");
                            int count = DataAccess.ExecuteUpdate("update presence set totalPresence=totalPresence+1 , currentDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "' where id='" + this.txtUserName.Text + "'");
                            if (count == 1)
                                MessageBox.Show("your presence done");
                        }
                        else
                        {
                            int count = DataAccess.ExecuteUpdate("update presence set  currentDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "' where id='" + this.txtUserName.Text + "'");
                            if (count == 1)
                                MessageBox.Show("Sorry You are too late");
                        }






                    }





                    //  form.Visible = true;
                    //  System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
                    // this.MaximizedBounds = Screen.GetWorkingArea(this);
                    //  this.WindowState = FormWindowState.Maximized;






                    //  this.Visible = false;



                }

                else if (job == "manager")
                {
                    MessageBox.Show("Login Successful");
                    this.Visible = false;
                    new FormManager(this, this.txtUserName.Text).Visible = true;
                    this.Date = DataAccess.SingleVarification("Select currentDate from presence where id='" + this.txtUserName.Text + "'");

                    if ((DateTime.Parse(this.Date).ToString("MM/dd/yyyy") != DateTime.Today.ToString("MM/dd/yyyy")))
                    {
                        if (System.DateTime.Now.Hour <= 11)
                        {
                            // MessageBox.Show("In Time");
                            int count = DataAccess.ExecuteUpdate("update presence set totalPresence=totalPresence+1 , currentDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "' where id='" + this.txtUserName.Text + "'");
                            if (count == 1)
                                MessageBox.Show("your presence done");
                        }
                        else
                        {
                            int count = DataAccess.ExecuteUpdate("update presence set  currentDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "' where id='" + this.txtUserName.Text + "'");
                            if (count == 1)
                                MessageBox.Show("Sorry You are too late");
                        }






                    }
                    this.MakeDefault();





                    this.Visible = false;
                }
                else if (job == "depertment head")
                {
                    MessageBox.Show("Login Successful");
                    this.Visible = false;
                    new FormHepertmentHead(this, this.txtUserName.Text).Visible = true;
                    this.Date = DataAccess.SingleVarification("Select currentDate from presence where id='" + this.txtUserName.Text + "'");

                    // MessageBox.Show("yes");
                    if ((DateTime.Parse(this.Date).ToString("MM/dd/yyyy") != DateTime.Today.ToString("MM/dd/yyyy")))
                    {
                        //  MessageBox.Show("yes2");
                        if (System.DateTime.Now.Hour <= 11)
                        {
                            // MessageBox.Show("ye3");
                            // MessageBox.Show("In Time");
                            int count = DataAccess.ExecuteUpdate("update presence set totalPresence=totalPresence+1 , currentDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "' where id='" + this.txtUserName.Text + "'");
                            if (count == 1)
                                MessageBox.Show("your presence done");
                        }
                        else
                        {
                            int count = DataAccess.ExecuteUpdate("update presence set  currentDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "' where id='" + this.txtUserName.Text + "'");
                            if (count == 1)
                                MessageBox.Show("Sorry You are too late");
                        }






                    }
                    // new FormStaff().Visible = true;

                    //
                    this.MakeDefault();
                    // this.Visible = false;
                }
                else if (job == "staff" || job == "se" || job == "jse")
                {
                    MessageBox.Show("Login Successful");
                    this.Visible = false;
                    new FormOtherEmployees(this, this.txtUserName.Text).Visible = true;
                    this.Date = DataAccess.SingleVarification("Select currentDate from presence where id='" + this.txtUserName.Text + "'");

                    if ((DateTime.Parse(this.Date).ToString("MM/dd/yyyy") != DateTime.Today.ToString("MM/dd/yyyy")))
                    {
                        if (System.DateTime.Now.Hour <= 11)
                        {
                            //MessageBox.Show("In Time");
                            int count = DataAccess.ExecuteUpdate("update presence set totalPresence=totalPresence+1 , currentDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "' where id='" + this.txtUserName.Text + "'");
                            if (count == 1)
                                MessageBox.Show("your presence done");
                        }
                        else
                        {
                            int count = DataAccess.ExecuteUpdate("update presence set  currentDate='" + DateTime.Today.ToString("yyyy-MM-dd") + "' where id='" + this.txtUserName.Text + "'");
                            if (count == 1)
                                MessageBox.Show("Sorry You are too late");
                        }






                    }
                    // this.Visible = false;
                    this.MakeDefault();

                }
                else
                    MessageBox.Show("Invalid Login");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        
        private UserControl activeControl = null;
        private void OpenUserControl(UserControl childControl)
        {
            if (this.activeControl != null)
                this.activeControl.Hide();

            this.activeControl = childControl;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            childControl.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childControl);
            // this.Panel2.Tag = childControl;
            //
            childControl.BringToFront();
            childControl.Show();
        }

        private void llblForgatePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.uClPasswordRecovery1.Show();

            // this.UCPasswordRecovery.Show();
            OpenUserControl(new UClPasswordRecovery());
            //  this.panel2.Visible = false;


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
           // this.uClPasswordRecovery1.Hide();
            //this.UCPasswordRecovery.Hide();
            //  this.panel2.Visible = true;
        }

        private void UClPasswordRecovery_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           // this.uClPasswordRecovery1.Hide();
        }

        private void uClPasswordRecovery1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.activeControl.Dispose();
        }
    }
}
