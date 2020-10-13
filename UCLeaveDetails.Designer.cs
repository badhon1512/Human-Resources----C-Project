namespace HRUpdate
{
    partial class UCLeaveDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLeave = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.applicationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depertmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.cmbMonth);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.dgvLeave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 950);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave Application Details";
            // 
            // dgvLeave
            // 
            this.dgvLeave.AllowUserToAddRows = false;
            this.dgvLeave.AllowUserToDeleteRows = false;
            this.dgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicationNo,
            this.id,
            this.causes,
            this.deptStatus,
            this.hrStatus,
            this.finalStatus,
            this.employeeStatus,
            this.fromDate,
            this.toDate,
            this.duration,
            this.depertmentid});
            this.dgvLeave.Location = new System.Drawing.Point(25, 229);
            this.dgvLeave.Name = "dgvLeave";
            this.dgvLeave.ReadOnly = true;
            this.dgvLeave.RowHeadersWidth = 62;
            this.dgvLeave.RowTemplate.Height = 28;
            this.dgvLeave.Size = new System.Drawing.Size(1429, 439);
            this.dgvLeave.TabIndex = 1;
            this.dgvLeave.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvLeave_CellContextMenuStripNeeded);
            this.dgvLeave.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLeave_CellMouseDown);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Pending"});
            this.cmbStatus.Location = new System.Drawing.Point(25, 181);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(244, 28);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February"});
            this.cmbMonth.Location = new System.Drawing.Point(1210, 181);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(244, 28);
            this.cmbMonth.TabIndex = 3;
            // 
            // applicationNo
            // 
            this.applicationNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.applicationNo.DataPropertyName = "applicationNo";
            this.applicationNo.HeaderText = "applicationNo";
            this.applicationNo.MinimumWidth = 8;
            this.applicationNo.Name = "applicationNo";
            this.applicationNo.ReadOnly = true;
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
            // causes
            // 
            this.causes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.causes.DataPropertyName = "causes";
            this.causes.HeaderText = "causes";
            this.causes.MinimumWidth = 8;
            this.causes.Name = "causes";
            this.causes.ReadOnly = true;
            // 
            // deptStatus
            // 
            this.deptStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deptStatus.DataPropertyName = "deptStatus";
            this.deptStatus.HeaderText = "deptStatus";
            this.deptStatus.MinimumWidth = 8;
            this.deptStatus.Name = "deptStatus";
            this.deptStatus.ReadOnly = true;
            // 
            // hrStatus
            // 
            this.hrStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hrStatus.DataPropertyName = "hrStatus";
            this.hrStatus.HeaderText = "hrStatus";
            this.hrStatus.MinimumWidth = 8;
            this.hrStatus.Name = "hrStatus";
            this.hrStatus.ReadOnly = true;
            // 
            // finalStatus
            // 
            this.finalStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.finalStatus.DataPropertyName = "finalStatus";
            this.finalStatus.HeaderText = "Status";
            this.finalStatus.MinimumWidth = 8;
            this.finalStatus.Name = "finalStatus";
            this.finalStatus.ReadOnly = true;
            // 
            // employeeStatus
            // 
            this.employeeStatus.DataPropertyName = "employeeStatus";
            this.employeeStatus.HeaderText = "employeeStatus";
            this.employeeStatus.MinimumWidth = 8;
            this.employeeStatus.Name = "employeeStatus";
            this.employeeStatus.ReadOnly = true;
            this.employeeStatus.Visible = false;
            this.employeeStatus.Width = 150;
            // 
            // fromDate
            // 
            this.fromDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fromDate.DataPropertyName = "fromDate";
            this.fromDate.HeaderText = "fromDate";
            this.fromDate.MinimumWidth = 8;
            this.fromDate.Name = "fromDate";
            this.fromDate.ReadOnly = true;
            // 
            // toDate
            // 
            this.toDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.toDate.DataPropertyName = "toDate";
            this.toDate.HeaderText = "toDate";
            this.toDate.MinimumWidth = 8;
            this.toDate.Name = "toDate";
            this.toDate.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "duration";
            this.duration.MinimumWidth = 8;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // depertmentid
            // 
            this.depertmentid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depertmentid.DataPropertyName = "depertmentid";
            this.depertmentid.HeaderText = "depertmentid";
            this.depertmentid.MinimumWidth = 8;
            this.depertmentid.Name = "depertmentid";
            this.depertmentid.ReadOnly = true;
            this.depertmentid.Visible = false;
            // 
            // UCLeaveDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCLeaveDetails";
            this.Size = new System.Drawing.Size(1477, 950);
            this.Load += new System.EventHandler(this.UCLeaveDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvLeave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn causes;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn depertmentid;
    }
}
