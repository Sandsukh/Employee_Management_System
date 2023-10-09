using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Form5 : Form
    {
        int Uid;
        public Form5(int id)
        {
            InitializeComponent();
            Uid= id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void btnEntrance_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AttendanceTableAdapter Adminada = new DataSet1TableAdapters.AttendanceTableAdapter();
            Adminada.UpdateQuery(Uid);
            MessageBox.Show("Thanks for Marking attendance!!!!!!!");
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.EmployeesTableAdapter Empada = new DataSet1TableAdapters.EmployeesTableAdapter();
            DataTable dt2 = Empada.GetData(Uid);
            string s = dt2.Rows[0]["EmpName"].ToString();
            label2.Text = s;
        }
    }
}
