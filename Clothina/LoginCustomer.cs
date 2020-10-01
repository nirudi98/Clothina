using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothina
{
    public partial class LoginCustomer : Form
    {
        public LoginCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String user = txtUsername.Text;
            String pass = txtPassword.Text;


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\ClothinaDB.mdf;Integrated Security=True;Connect Timeout=30");
            //sql query


            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM CustomerDetails WHERE CustName ='" + user + "' AND CustPassword = '" + pass + "'", con);






            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                /*CustomerDashboard c1 = new CustomerDashboard(user);
                this.Hide();
                c1.Show();
                */
                MessageBox.Show("successful");
            }
            else
                MessageBox.Show("Invalid username or password");




        }
    }
}
