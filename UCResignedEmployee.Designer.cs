namespace HRUpdate
{
    partial class UCResignEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.dgvEmployeeInformation = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnReJoin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbEmp);
            this.panel1.Controls.Add(this.dgvEmployeeInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1522, 791);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReJoin
            // 
            this.btnReJoin.BackColor = System.Drawing.Color.Lime;
            this.btnReJoin.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReJoin.Location = new System.Drawing.Point(432, 629);
            this.btnReJoin.Name = "btnReJoin";
            this.btnReJoin.Size = new System.Drawing.Size(603, 56);
            this.btnReJoin.TabIndex = 10;
            this.btnReJoin.Text = "RE-JOIN";
            this.btnReJoin.UseVisualStyleBackColor = false;
            this.btnReJoin.Click += new System.EventHandler(this.btnReJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(617, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resigned Employee List";
            // 
            // cmbEmp
            // 
            this.cmbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmp.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Items.AddRange(new object[] {
            "All",
            "Hr",
            "Hepertment Head",
            "Manager",
            "It",
            "Jse",
            "Se",
            "Staff"});
            this.cmbEmp.Location = new System.Drawing.Point(34, 113);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(251, 31);
            this.cmbEmp.TabIndex = 1;
            this.cmbEmp.SelectedIndexChanged += new System.EventHandler(this.cmbEmp_SelectedIndexChanged);
            // 
            // dgvEmployeeInformation
            // 
            this.dgvEmployeeInformation.AllowUserToAddRows = false;
            this.dgvEmployeeInformation.AllowUserToDeleteRows = false;
            this.dgvEmployeeInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.job,
            this.salary,
            this.password,
            this.hiredate,
            this.experience,
            this.email,
            this.deptid,
            this.gender});
            this.dgvEmployeeInformation.Location = new System.Drawing.Point(34, 162);
            this.dgvEmployeeInformation.Name = "dgvEmployeeInformation";
            this.dgvEmployeeInformation.ReadOnly = true;
            this.dgvEmployeeInformation.RowHeadersWidth = 62;
            this.dgvEmployeeInformation.RowTemplate.Height = 28;
            this.dgvEmployeeInformation.Size = new System.Drawing.Size(1447, 429);
            this.dgvEmployeeInformation.TabIndex = 0;
            this.dgvEmployeeInformation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInformation_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // job
            // 
            this.job.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.job.DataPropertyName = "job";
            this.job.HeaderText = "job";
            this.job.MinimumWidth = 8;
            this.job.Name = "job";
            this.job.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "salary";
            this.salary.MinimumWidth = 8;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            this.password.Width = 150;
            // 
            // hiredate
            // 
            this.hiredate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hiredate.DataPropertyName = "hiredate";
            this.hiredate.HeaderText = "hiredate";
            this.hiredate.MinimumWidth = 8;
            this.hiredate.Name = "hiredate";
            this.hiredate.ReadOnly = true;
            // 
            // experience
            // 
            this.experience.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.experience.DataPropertyName = "experience";
            this.experience.HeaderText = "experience";
            this.experience.MinimumWidth = 8;
            this.experience.Name = "experience";
            this.experience.ReadOnly = true;
            this.experience.Visible = false;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // deptid
            // 
            this.deptid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deptid.DataPropertyName = "depertmentid";
            this.deptid.HeaderText = "deptid";
            this.deptid.MinimumWidth = 8;
            this.deptid.Name = "deptid";
            this.deptid.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "gender";
            this.gender.MinimumWidth = 8;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // UCResignEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCResignEmployee";
            this.Size = new System.Drawing.Size(1522, 791);
            this.Load += new System.EventHandler(this.UCResignEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmployeeInformation;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn experience;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
    }
}
