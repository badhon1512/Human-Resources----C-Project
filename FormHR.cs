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


namespace HRUpdate
{


    public partial class FormHR : Form
    {
        private Button currentbutton;
        private int SESalary { set; get; }

        private Random random;
       // private FormLogin LoginInstance { set; get; }
        private string EmpId { set; get; }
        private string EmpName { set; get; }
        private int Salary { get; set; }
        private int Presence { get; set; }
        private int Leave { set; get; }
        
        private int tempIndex;
        private FormLogin LoginInstance { set; get; }
        private string Id { get; set; }
        private DataTable Dt { set; get; }
      //  private DataAccess Data { get; set; }
        
        public FormHR(FormLogin login,string id)
        {
            InitializeComponent();
            this.customizeDesign();
            random = new Random();
            this.Id = id;
            this.LoginInstance = login;
            // this.Data = new DataAccess();
            try
            {
                Dt = DataAccess.ExecuteQuery("Select name from employee where id='" + this.Id + "'");
                this.btnSelf.Text = "Welcome ," + Dt.Rows[0][0].ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

            // MessageBox.Show();


            //  int count = ThemeColor.ColorList.Count;



        }

        public Color SelectThemeColor()
        {

            int index = this.random.Next(HRUpdate.ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(HRUpdate.ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = HRUpdate.ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }
        private void ActiveButton(Object btnSender)
        {
            DisableButton();
            if (currentbutton != btnSender)
            {
                Color color = this.SelectThemeColor();
                currentbutton = (Button)btnSender;
                currentbutton.BackColor = color;
                currentbutton.ForeColor = Color.White;
                currentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void DisableButton()
        {
            foreach (Control PreviousBtn in this.pnlLeft.Controls)
            {
                if (PreviousBtn.GetType() == typeof(Button))
                {
                    if (PreviousBtn.Text == "Salary Change" ||PreviousBtn.Text == "Depertment" || PreviousBtn.Text == "Financial" || PreviousBtn.Text == "Employee"||PreviousBtn.Text=="Financial"||PreviousBtn.Text=="Presence"||PreviousBtn.Text=="Settings")
                        PreviousBtn.BackColor = Color.FromArgb(31, 30, 61);
                    else
                        PreviousBtn.BackColor = Color.FromArgb(35, 32, 39);

                    PreviousBtn.ForeColor = Color.DarkGray;

                    PreviousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void customizeDesign()
        {
            this.pnlEmployeeMenu.Visible = false;
            this.pnlFinancialMenu.Visible = false;

            this.pnlCrudMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (this.pnlEmployeeMenu.Visible == true)
                this.pnlEmployeeMenu.Visible = false;
            if (this.pnlFinancialMenu.Visible == true)
                this.pnlFinancialMenu.Visible = false;
            if (this.pnlCrudMenu.Visible == true)
                this.pnlCrudMenu.Visible = false;
            if (this.pnlPresence.Visible == true)
                this.pnlPresence.Visible = false;
            if (this.pnlSettings.Visible == true)
                this.pnlSettings.Visible = false;
            if (this.pnlPresence.Visible == true)
                this.pnlPresence.Visible = false;

            // this.pnlFinalcialMenu.Visible = false;


        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                this.hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;


        }
        private UserControl activeControl = null;

        public object ThemeColor { get; private set; }

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




        private void pnlChildFormContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.showSubMenu(this.pnlEmployeeMenu);
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.showSubMenu(this.pnlFinancialMenu);
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
           // OpenChildForm(new FormAddNewEmployee());
            this.hideSubMenu();
            ActiveButton(sender);
        }


        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.hideSubMenu();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            //// this.ucitDepertment1.Hide();
            //this.UcHide();
            //   this.uchrDepertment1.Show();
            this.OpenUserControl(new UCHRDepertmentInformation());
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
           // new FormUpdateEmployee(this.Id).Visible = true;
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnResignedEmployee_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCResignEmployee());
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnManagerSalary_Click(object sender, EventArgs e)
        {
           
            this.hideSubMenu();
            ActiveButton(sender);
            this.OpenUserControl(new UCSalary());
        }

        private void btnStaffSalary_Click(object sender, EventArgs e)
        {
            this.hideSubMenu();
        }

        private void btnHRSalary_Click(object sender, EventArgs e)
        {
            this.hideSubMenu();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            this.hideSubMenu();
            ActiveButton(sender);
            this.OpenUserControl(new UCRevenue());
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.hideSubMenu();
           
        }
        

        private void btnIT_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCItDepertmentInformation());
            
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void lblTittle_Click(object sender, EventArgs e)
        {
            // this.pnlChildFormContainer.Visible = true;
        }

        private void HR_Load(object sender, EventArgs e)
        {
            //is.pbdept.
            // this.pbdept.Image = new Bitmap(@"C:\Users\BADHON\Desktop\logo");
            // pictureBox1.Image = Image.FromFile(@"Images\a.bmp");
            // FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.hideSubMenu();
            int count;
            try
            {
                string sqlLeave = "select count(*) from leaveStatus where deptStatus='accept' and finalStatus='pending'";

                count = DataAccess.CountMethod(sqlLeave);
               // if (count > 0)
                  //  this.btnLeaveApplication.BackColor = Color.Orange;
               // else
                //    this.btnLeaveApplication.BackColor = Color.Green;
                this.btnLeaveApplication.Text = "Leave Application : " + count.ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            // TopMost = true;

            //this.ucEmployee1.Show();

        }

        private void FormHR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
           // OpenChildForm(new FormSalary());
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void llblSelf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OpenUserControl(new UCSelfInformation(this.Id));
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            
            ActiveButton(sender);
            this.showSubMenu(this.pnlCrudMenu);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FormLogin().Visible = true;
        }

        private void btnEmployeeInformation_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCEmployeeInformation(this.Id));
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // this.OpenUserControl(new UCNotification());
        }

        private void btnLeaveApplication_Click(object sender, EventArgs e)
        {
        }

       

        private void btnPresence_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.showSubMenu(this.pnlPresence);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.showSubMenu(this.pnlSettings);
        }

        private void btnPasswordChange_Click_1(object sender, EventArgs e)
        {

            ActiveButton(sender);
            this.hideSubMenu();
            // this.showSubMenu(this.pnlPresence);
            this.OpenUserControl(new UClPasswordRecovery());
        }

        private void btnLeaveApplication_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.hideSubMenu();
            this.btnLeaveApplication.Text = "Leave Application";
            this.OpenUserControl(new UCLeaveDetails("hr"));
            this.btnLeaveApplication.Text = "Leave Application";

        }

        private void btnPresenceDetails_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.OpenUserControl(new UCPrresenceInformation());
            this.hideSubMenu();
        }

        private void btnHRSalary_Click_1(object sender, EventArgs e)
        {
            this.hideSubMenu();
        }

        private void btnSynchronized_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            try
            {
                //MessageBox.Show();
                if (System.DateTime.Now.ToString("MMMM") != DataAccess.SingleVarification("select synchronizeMonth  from synchronize;"))
                {


                    if (Convert.ToInt32(DateTime.Now.Date.ToString("dd")) >= 15)
                    {
                        //salary calculation
                        this.Dt = DataAccess.ExecuteQuery("Select * from employee where Status = 'active'");
                        //MessageBox.Show(this.Dt.Columns.Count.ToString());
                        for (int i = 0; i < this.Dt.Rows.Count; i++)
                        {


                            this.EmpId = this.Dt.Rows[i][0].ToString();
                            //  MessageBox.Show(this.EmpId);
                            this.Salary = Convert.ToInt32(this.Dt.Rows[i][3]);
                            this.EmpName = this.Dt.Rows[i][1].ToString();
                            this.Presence = Convert.ToInt32(DataAccess.SingleVarification("select totalPresence from presence where id = '" + this.EmpId + "'"));
                            this.Leave = Convert.ToInt32(DataAccess.SingleVarification("select ISNULL(sum(duration),0) from leaveStatus where id = '" + this.EmpId + "' and finalStatus='accept' and Month(toDate)= MONTH(CURRENT_TIMESTAMP)"));
                            // MessageBox.Show(Presence.ToString());
                            // MessageBox.Show(Leave.ToString());
                            DataAccess.ExecuteUpdate("insert into monthlyPresence values('" + this.EmpId + "','" + System.DateTime.Now.ToString("MMMM") + "'," + this.Presence + "); ");
                            if (this.Presence + this.Leave >= 20)
                            {
                                DataAccess.ExecuteUpdate("insert into monthlySalary values('" + this.EmpId + "','" + System.DateTime.Now.ToString("MMMM") + "'," + this.Salary + ",'" + this.EmpName + "'");
                            }
                            else
                            {
                                int absence = 20 - (this.Presence + this.Leave);
                                // MessageBox.Show((20 - (this.Presence + this.Leave)).ToString());
                                this.Salary -= (absence * 6);
                                DataAccess.ExecuteUpdate("insert into monthlySalary values('" + this.EmpId + "','" + System.DateTime.Now.ToString("MMMM") + "'," + this.Salary + ",'" + this.EmpName + "')");


                            }
                        }
                        DataAccess.ExecuteUpdate("update employee set experience = experience + 1 where status = 'active'");

                        this.Dt = DataAccess.ExecuteQuery("select * from employee where job='jse' and experience>5; ");
                        if (Dt.Rows.Count > 0)
                          this.SESalary= Convert.ToInt32(DataAccess.SingleVarification("select salary from salary where job = 'se'"));


                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            DataAccess.ExecuteUpdate("update employee set job = 'se' ,salary="+this.SESalary+"  where id='"+this.Dt.Rows[i][0].ToString()+"'");
                            MessageBox.Show(""+ this.Dt.Rows[i][1]+" got promotion frsom jse to se ");
                            DataAccess.ExecuteUpdate("insert into Notification values('"+this.Dt.Rows[0][0].ToString()+ "', '"+ DateTime.Today.ToString("yyyy-MM-dd") + "', 'got promotion', 'unseen')");

                        }
                        //  MessageBox.Show("Yes");

                        int revenue = Convert.ToInt32(DataAccess.SingleVarification("select IsNull(sum(price),0) from Projectrevenue where month = '" + System.DateTime.Now.ToString("MMMM") + "'"));
                       // MessageBox.Show("select IsNull(sum(price),0) from Projectrevenue where month = '" + System.DateTime.Now.ToString("MMMM") + "'");
                       // MessageBox.Show(revenue.ToString());
                        int expence = Convert.ToInt32(DataAccess.SingleVarification("select IsNull(sum(monthlysalary),0) from monthlysalary where _monthName = '" + System.DateTime.Now.ToString("MMMM") + "'"));
                      //  MessageBox.Show(expence.ToString());
                        int profit = revenue - expence;
                        DataAccess.ExecuteUpdate("insert into AllFinancialInformation values('" + System.DateTime.Now.ToString("MMMM") + "'," + revenue + "," + expence + "," + profit + ")");
                        //MessageBox.Show("Yes3");
                        DataAccess.ExecuteUpdate("update Presence set totalPresence=0");
                        DataAccess.ExecuteUpdate("update synchronize set synchronizeMonth='"+ System.DateTime.Now.ToString("MMMM") +"'");

                        MessageBox.Show("Synchronize done successfully");




                    }
                    else
                        MessageBox.Show("Sorry it's too early");

                }
                else
                    MessageBox.Show("already synchronized done");
            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
           
        }

        private void btnFinancialInfo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.hideSubMenu();
            this.OpenUserControl(new UCFinancialInformation());
        }

        private void lblSelf_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelf_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCSelfInformation(this.Id));
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(this.activeControl!=null)
            this.activeControl.Visible = false;
        }

        private void btnSalaryChange_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCSalaryChange());
            this.hideSubMenu();
            ActiveButton(sender);
        }
    }
}

