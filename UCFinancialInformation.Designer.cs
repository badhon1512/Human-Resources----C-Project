namespace HRUpdate
{
    partial class UCFinancialInformation
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
            this.dgvFinancialInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalExpense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvFinancialInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 950);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvFinancialInfo
            // 
            this.dgvFinancialInfo.AllowUserToAddRows = false;
            this.dgvFinancialInfo.AllowUserToDeleteRows = false;
            this.dgvFinancialInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinancialInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.monthName,
            this.totalRevenue,
            this.totalExpense,
            this.profit});
            this.dgvFinancialInfo.Location = new System.Drawing.Point(14, 200);
            this.dgvFinancialInfo.Name = "dgvFinancialInfo";
            this.dgvFinancialInfo.ReadOnly = true;
            this.dgvFinancialInfo.RowHeadersWidth = 62;
            this.dgvFinancialInfo.RowTemplate.Height = 28;
            this.dgvFinancialInfo.Size = new System.Drawing.Size(1460, 451);
            this.dgvFinancialInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Financial Information";
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
            // monthName
            // 
            this.monthName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monthName.DataPropertyName = "monthName";
            this.monthName.HeaderText = "Month";
            this.monthName.MinimumWidth = 8;
            this.monthName.Name = "monthName";
            this.monthName.ReadOnly = true;
            // 
            // totalRevenue
            // 
            this.totalRevenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalRevenue.DataPropertyName = "totalRevenue";
            this.totalRevenue.HeaderText = "Revenue";
            this.totalRevenue.MinimumWidth = 8;
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.ReadOnly = true;
            // 
            // totalExpense
            // 
            this.totalExpense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalExpense.DataPropertyName = "totalExpense";
            this.totalExpense.HeaderText = "Expense";
            this.totalExpense.MinimumWidth = 8;
            this.totalExpense.Name = "totalExpense";
            this.totalExpense.ReadOnly = true;
            // 
            // profit
            // 
            this.profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profit.DataPropertyName = "profit";
            this.profit.HeaderText = "Profit/loss";
            this.profit.MinimumWidth = 8;
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            // 
            // UCFinancialInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCFinancialInformation";
            this.Size = new System.Drawing.Size(1477, 950);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFinancialInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
    }
}
