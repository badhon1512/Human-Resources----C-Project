namespace HRUpdate
{
    public partial class FormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnPasswordChange = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLeaveApplication = new System.Windows.Forms.Button();
            this.pnlCrudMenu = new System.Windows.Forms.Panel();
            this.btnEmployeeInformation = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlEmployeeMenu = new System.Windows.Forms.Panel();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnDepertment = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelf = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlCrudMenu.SuspendLayout();
            this.pnlEmployeeMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(61)))));
            this.pnlLeft.Controls.Add(this.panel3);
            this.pnlLeft.Controls.Add(this.btnLeaveApplication);
            this.pnlLeft.Controls.Add(this.pnlCrudMenu);
            this.pnlLeft.Controls.Add(this.btnEmployee);
            this.pnlLeft.Controls.Add(this.pnlEmployeeMenu);
            this.pnlLeft.Controls.Add(this.btnDepertment);
            this.pnlLeft.Controls.Add(this.pnlLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(315, 1050);
            this.pnlLeft.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.pnlSettings);
            this.panel3.Controls.Add(this.btnSettings);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 538);
            this.panel3.TabIndex = 6;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSettings.Controls.Add(this.btnPasswordChange);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 77);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(315, 86);
            this.pnlSettings.TabIndex = 6;
            this.pnlSettings.Visible = false;
            // 
            // btnPasswordChange
            // 
            this.btnPasswordChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPasswordChange.FlatAppearance.BorderSize = 0;
            this.btnPasswordChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordChange.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPasswordChange.Location = new System.Drawing.Point(0, 0);
            this.btnPasswordChange.Name = "btnPasswordChange";
            this.btnPasswordChange.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnPasswordChange.Size = new System.Drawing.Size(315, 79);
            this.btnPasswordChange.TabIndex = 5;
            this.btnPasswordChange.Text = "Password Change";
            this.btnPasswordChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasswordChange.UseVisualStyleBackColor = true;
            this.btnPasswordChange.Click += new System.EventHandler(this.btnPasswordChange_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(315, 77);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLeaveApplication
            // 
            this.btnLeaveApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaveApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeaveApplication.FlatAppearance.BorderSize = 0;
            this.btnLeaveApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveApplication.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveApplication.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLeaveApplication.Location = new System.Drawing.Point(0, 425);
            this.btnLeaveApplication.Name = "btnLeaveApplication";
            this.btnLeaveApplication.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnLeaveApplication.Size = new System.Drawing.Size(315, 87);
            this.btnLeaveApplication.TabIndex = 5;
            this.btnLeaveApplication.Text = "Leave Application :  0";
            this.btnLeaveApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaveApplication.UseVisualStyleBackColor = true;
            this.btnLeaveApplication.Click += new System.EventHandler(this.btnLeaveApplication_Click);
            // 
            // pnlCrudMenu
            // 
            this.pnlCrudMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlCrudMenu.Controls.Add(this.btnEmployeeInformation);
            this.pnlCrudMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCrudMenu.Location = new System.Drawing.Point(0, 335);
            this.pnlCrudMenu.Name = "pnlCrudMenu";
            this.pnlCrudMenu.Size = new System.Drawing.Size(315, 90);
            this.pnlCrudMenu.TabIndex = 4;
            // 
            // btnEmployeeInformation
            // 
            this.btnEmployeeInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeInformation.FlatAppearance.BorderSize = 0;
            this.btnEmployeeInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeInformation.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeInformation.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeInformation.Location = new System.Drawing.Point(0, 0);
            this.btnEmployeeInformation.Name = "btnEmployeeInformation";
            this.btnEmployeeInformation.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnEmployeeInformation.Size = new System.Drawing.Size(315, 84);
            this.btnEmployeeInformation.TabIndex = 2;
            this.btnEmployeeInformation.Text = " Employee Information";
            this.btnEmployeeInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeInformation.UseVisualStyleBackColor = true;
            this.btnEmployeeInformation.Click += new System.EventHandler(this.btnEmployeeInformation_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.Location = new System.Drawing.Point(0, 250);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(315, 85);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click_1);
            // 
            // pnlEmployeeMenu
            // 
            this.pnlEmployeeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlEmployeeMenu.Controls.Add(this.btnHR);
            this.pnlEmployeeMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployeeMenu.Location = new System.Drawing.Point(0, 175);
            this.pnlEmployeeMenu.Name = "pnlEmployeeMenu";
            this.pnlEmployeeMenu.Size = new System.Drawing.Size(315, 75);
            this.pnlEmployeeMenu.TabIndex = 2;
            // 
            // btnHR
            // 
            this.btnHR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHR.FlatAppearance.BorderSize = 0;
            this.btnHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHR.ForeColor = System.Drawing.Color.DarkGray;
            this.btnHR.Location = new System.Drawing.Point(0, 0);
            this.btnHR.Name = "btnHR";
            this.btnHR.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnHR.Size = new System.Drawing.Size(315, 69);
            this.btnHR.TabIndex = 4;
            this.btnHR.Text = "HR";
            this.btnHR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnDepertment
            // 
            this.btnDepertment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepertment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepertment.FlatAppearance.BorderSize = 0;
            this.btnDepertment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepertment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepertment.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDepertment.Location = new System.Drawing.Point(0, 100);
            this.btnDepertment.Name = "btnDepertment";
            this.btnDepertment.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnDepertment.Size = new System.Drawing.Size(315, 75);
            this.btnDepertment.TabIndex = 1;
            this.btnDepertment.Text = "Depertment";
            this.btnDepertment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepertment.UseVisualStyleBackColor = true;
            this.btnDepertment.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox3);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(315, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::HRUpdate.Properties.Resources.company;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(315, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btnSelf);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(315, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnSelf
            // 
            this.btnSelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(61)))));
            this.btnSelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelf.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelf.ForeColor = System.Drawing.Color.Coral;
            this.btnSelf.Location = new System.Drawing.Point(633, 26);
            this.btnSelf.Name = "btnSelf";
            this.btnSelf.Size = new System.Drawing.Size(468, 57);
            this.btnSelf.TabIndex = 7;
            this.btnSelf.Text = "Welcome , ";
            this.btnSelf.UseVisualStyleBackColor = false;
            this.btnSelf.Click += new System.EventHandler(this.btnSelf_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1399, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(315, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1477, 950);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRUpdate.Properties.Resources.company;
            this.pictureBox1.Location = new System.Drawing.Point(486, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHR_FormClosed);
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.pnlLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlCrudMenu.ResumeLayout(false);
            this.pnlEmployeeMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlCrudMenu;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel pnlEmployeeMenu;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnDepertment;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmployeeInformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLeaveApplication;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnPasswordChange;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSelf;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        // private UCITDepertment ucitDepertment1;
        // private UCHRDepertment uchrDepertment1;
        // private UCEmployee ucEmployee1;
        //private UCITDepertment ucitDepertment1;
    }
}

