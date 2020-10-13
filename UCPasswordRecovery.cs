using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Microsoft.VisualBasic;
using HRUpdate.DB;


namespace HRUpdate
{
    public partial class UClPasswordRecovery : UserControl
    {
        private int Code { set; get; }
        //private DataAccess Data { set; get; }
        public UClPasswordRecovery()
        {
            InitializeComponent();
            //this.Data = new DataAccess();

        }

        private bool TxtCheck()
        {
            if (this.txtEmail.Text != "" && this.txtUserId.Text != "" && this.txtPassword.Text != "" && this.txtConfirmPassword.Text != "" && this.txtUserId.Text != "UserId" && this.txtEmail.Text != "Email" && this.txtPassword.Text != "New Password" && this.txtConfirmPassword.Text != "Confirm Password")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please Fill up all the information");
                return false;
            }
            return false;


        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.TxtCheck())
            {
                if (this.txtPassword.Text != this.txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password does't match");
                }
                else if (this.txtPassword.Text.Length < 5)
                {
                    MessageBox.Show("Password length must be at least 5");
                }
                else
                {
                    string sql = @"select count(*) from employee
                               where id = '" + this.txtUserId.Text + "' and email = '" + this.txtEmail.Text + "'";

                    int count = DataAccess.CountMethod(sql);

                    if (count > 0)
                    {
                        Random rnd = new Random();
                        Code = rnd.Next(11111, 99999);
                        try
                        {
                            MailMessage mail = new MailMessage("badhon1512@gmail.com", this.txtEmail.Text, "Regarding Varification", "Varification Code -" + Code.ToString());
                            SmtpClient client = new SmtpClient("smtp.gmail.com");
                            client.Port = 587;
                            client.Credentials = new System.Net.NetworkCredential("badhon1512@gmail.com", "ba01751467587");
                            client.EnableSsl = true;
                            client.Send(mail);
                            MessageBox.Show("Code sent to email");

                            byte c = 0;
                            while (c < 3)
                            {
                                string s = Interaction.InputBox("Confirmation Code :", "Password Recovery", "", -1, -1);
                                if (s == Code.ToString())
                                {
                                    string sql2 = @"UPDATE employee SET password = '" + this.txtPassword.Text + "' WHERE id ='" + this.txtUserId.Text + "'";

                                    //  MessageBox.Show(sql2);
                                    int i = DataAccess.ExecuteUpdate(sql2);
                                    //    MessageBox.Show(i.ToString());


                                    if (i > 0)
                                    {
                                        MessageBox.Show("Password Change Successful");
                                        this.Dispose();
                                        this.txtConfirmPassword.Clear();
                                        this.txtEmail.Clear();
                                        this.txtPassword.Clear();
                                        this.txtUserId.Clear();
                                        break;

                                    }
                                    else
                                        MessageBox.Show("Sorry your password isn't change");


                                    break;

                                }
                                else if (c == 2)
                                {
                                    MessageBox.Show("Your entered code is wrong.");
                                    break;

                                }
                                else
                                    MessageBox.Show("Your entered code is wrong Please try again.!");
                                c++;
                            }


                        }
                        catch (Exception edd)
                        {
                            MessageBox.Show(edd.Message);
                        }
                    }

                    else
                        MessageBox.Show("You are not an empoyee");








                }

            }





        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserId_Enter(object sender, EventArgs e)
        {
            if (this.txtUserId.Text == "UserId")
            {
                this.txtUserId.Text = "";
                this.txtUserId.ForeColor = Color.LightGray;
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (this.txtUserId.Text == "")
            {
                this.txtUserId.ForeColor = Color.DimGray;
                this.txtUserId.Text = "UserId";

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (this.txtEmail.Text == "")
            {
                this.txtEmail.ForeColor = Color.DimGray;
                this.txtEmail.Text = "Email";

            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (this.txtEmail.Text == "Email")
            {
                this.txtEmail.Text = "";
                this.txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "New Password")
            {
                this.txtPassword.PasswordChar = '*';
                this.txtPassword.Text = "";
                this.txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {
                this.txtPassword.PasswordChar = '\0';
                this.txtPassword.ForeColor = Color.DimGray;
                this.txtPassword.Text = "New Password";

            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtConfirmPassword.Text == "")
            {
                this.txtConfirmPassword.PasswordChar = '\0';
                this.txtConfirmPassword.ForeColor = Color.DimGray;
                this.txtConfirmPassword.Text = "Confirm Password";

            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtConfirmPassword.Text == "Confirm Password")
            {
                this.txtConfirmPassword.PasswordChar = '*';
                this.txtConfirmPassword.Text = "";
                this.txtConfirmPassword.ForeColor = Color.LightGray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void UClPasswordRecovery_Load(object sender, EventArgs e)
        {
            /*var trackBar = new Bunifu.Framework.UI.BunifuTrackBar();
            trackBar.

            this.Controls.Add((Form)trackBar);*/


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}



