using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SchoolAssignmentSoft
{
    public partial class Form2 : Form
    {

        string connectionString = @"server=localhost;user id=root;pwd=1234;database=facebookdatabase;persistsecurityinfo=True;allowuservariables=True";
        int id = 0;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new form1();
            f1.ShowDialog();
            this.Close();
        }

        void GridFill()
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("UserViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblUser2 = new DataTable();

                sqlDa.Fill(dtblUser2);
                dgvUser2.DataSource = dtblUser2;
                dgvUser2.Columns[0].Visible = true;

            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GridFill();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                if (queryComboBox.SelectedItem.ToString() == "List of users with largest number of friends")
                {


                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("UserLargestFriend", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtblUser2 = new DataTable();

                    sqlDa.Fill(dtblUser2);
                    dgvUser2.DataSource = dtblUser2;
                    dgvUser2.Columns[0].Visible = true;


                }
                else if (queryComboBox.SelectedItem.ToString() == "List of users whos id is a multiple of 985")
                {

                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("userIdMultiple985", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtblUser2 = new DataTable();

                    sqlDa.Fill(dtblUser2);
                    dgvUser2.DataSource = dtblUser2;
                    dgvUser2.Columns[0].Visible = true;
                }

                else if (queryComboBox.SelectedItem.ToString() == "List of users who are Male")
                {

                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("userMale", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtblUser2 = new DataTable();

                    sqlDa.Fill(dtblUser2);
                    dgvUser2.DataSource = dtblUser2;
                    dgvUser2.Columns[0].Visible = true;
                }


                else if (queryComboBox.SelectedItem.ToString() == "List of users who are Female whos id is a multiple of 985")
                {

                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("UserFemale985", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtblUser2 = new DataTable();

                    sqlDa.Fill(dtblUser2);
                    dgvUser2.DataSource = dtblUser2;
                    dgvUser2.Columns[0].Visible = true;
                }

                else if (queryComboBox.SelectedItem.ToString() == "List of users who are Male whos id is a multiple of 985 sorted alphabetically")
                {

                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("userMale985AlphaLast", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtblUser2 = new DataTable();

                    sqlDa.Fill(dtblUser2);
                    dgvUser2.DataSource = dtblUser2;
                    dgvUser2.Columns[0].Visible = true;

                }

            }
        }


    }
}
