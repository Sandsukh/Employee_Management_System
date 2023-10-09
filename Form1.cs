using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Form1 : Form
    {
        public int id;//tostore id
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int  index=comboBox1.SelectedIndex;
            if (index == 0)
            {
               
                DataSet1TableAdapters.AdminTableAdapter Adminada = new DataSet1TableAdapters.AdminTableAdapter();
                DataTable dt = Adminada.GetDataByAdminIdandPassword(textBox1.Text, textBox2.Text);
                
                //MessageBox.Show(id.ToString());
                if (dt.Rows.Count > 0)
                {
                    id = int.Parse(dt.Rows[0]["AdminId"].ToString());
                    this.Hide();
                    Form2 form = new Form2(id);
                    form.ShowDialog();
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("Wrong username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (index == 1)
            {
                DataSet1TableAdapters.EmployeesTableAdapter Empada = new DataSet1TableAdapters.EmployeesTableAdapter();
                DataTable dt2 = Empada.GetDataBy(textBox1.Text, textBox2.Text);
                
                if (dt2.Rows.Count > 0)
                {
                    id = int.Parse(dt2.Rows[0]["EmpId"].ToString());
                    this.Hide();
                    Form5 f = new Form5(id);
                    f.ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
