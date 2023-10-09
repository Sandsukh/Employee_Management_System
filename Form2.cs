using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMS
{
    public partial class Form2 : Form
    {
        int Uid;
        
        public Form2(int id)
        {
            InitializeComponent();
            Uid= id;
        }
       


        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            f3.ShowDialog();
        }

        public  void Form2_Load(object sender, EventArgs e)
        {
            
            DataSet1TableAdapters.Admin1TableAdapter Adminada = new DataSet1TableAdapters.Admin1TableAdapter();
            DataTable dt = Adminada.GetData(Uid);
            string s = dt.Rows[0]["AdminName"].ToString();
            label6.Text = s;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
