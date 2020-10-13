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


    public partial class FormHepertmentHead : Form
    {
        private Button currentbutton;

        private Random random;
        private int tempIndex;
        private FormLogin LoginInstance { set; get; }
        private string Id { get; set; }
        private DataTable Dt { set; get; }
       // private DataAccess Data { get; set; }
        public FormHepertmentHead(FormLogin login, string id)
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
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

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
                    if (PreviousBtn.Text == "Depertment" || PreviousBtn.Text == "Employee" || PreviousBtn.Text == "Settings"|| PreviousBtn.Text == "Leave Application")
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
           // this.pnlFinancialMenu.Visible = false;

            this.pnlCrudMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (this.pnlEmployeeMenu.Visible == true)
                this.pnlEmployeeMenu.Visible = false;
          
            if (this.pnlCrudMenu.Visible == true)
                this.pnlCrudMenu.Visible = false;

            if (this.pnlSettings.Visible == true)
                this.pnlSettings.Visible = false;
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

       

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {


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
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            //this.OpenUserControl(new UCUpdateEmployee(this.Id));
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnResignedEmployee_Click(object sender, EventArgs e)
        {

            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnManagerSalary_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new FormUpdateEmployee());
            this.hideSubMenu();
            ActiveButton(sender);
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
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.hideSubMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            
        }

        private void ucitDepertment1_Load(object sender, EventArgs e)
        {

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
            this.LoginInstance.Visible = true;
            //.Visible = true;
        }

        private void btnEmployeeInformation_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCEmployeeInformation(this.Id));
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnLeaveApplication_Click(object sender, EventArgs e)
        {
            this.btnLeaveApplication.Text = "Leave Application";
            this.OpenUserControl(new UCLeaveDetails("depertment head"));
            this.hideSubMenu();
            ActiveButton(sender);
            this.btnLeaveApplication.Text = "Leave Application";
        }

        private void btnHrDepertment_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCHRDepertmentInformation());
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.showSubMenu(this.pnlSettings);
        }

        private void pnlSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.showSubMenu(this.pnlSettings);
            this.OpenUserControl(new UClPasswordRecovery());
        }

        private void btnResignedEmployee_Click_1(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCResignEmployee());
        }

        private void lblSelf_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCSelfInformation(this.Id));
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void btnSelf_Click(object sender, EventArgs e)
        {
            this.OpenUserControl(new UCSelfInformation(this.Id));
            this.hideSubMenu();
            ActiveButton(sender);
        }

        private void FormHepertmentHead_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            try
            {
                string sqlLeave = "select count(*) from leaveStatus where deptStatus='pending' and depertment='it-01'";

                int count = DataAccess.CountMethod(sqlLeave);

                this.btnLeaveApplication.Text = "Leave Application : " + count.ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.activeControl != null)
                this.activeControl.Visible = false;
        }
    }
}

