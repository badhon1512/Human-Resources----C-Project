using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRUpdate.DB;

namespace HRUpdate
{
    
    public partial class UCNotification : UserControl
    {
       // private DataAccess Data { set; get; }
        private string ID { set; get; }
        public UCNotification(string id)
        {
            InitializeComponent();
            this.ID = id;
           // this.Data =data;
            this.PupulateDataGridView();
        }
        private void PupulateDataGridView()
        {
            try
            {
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = DataAccess.ExecuteQuery("Select * from notification where id='" + this.ID + "'");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void UCNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
