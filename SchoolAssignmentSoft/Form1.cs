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

    public partial class form1 : Form
    {

        string connectionString = @"server=localhost;user id=root;pwd=1234;database=facebookdatabase;persistsecurityinfo=True;allowuservariables=True";
        int id = 0;
        public form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            using(MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("UserAddOrEditWithMoreCode", mysqlCon);

                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", id);
                mySqlCmd.Parameters.AddWithValue("_FirstName", txtFname.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_LastName", txtLname.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Gender", txtGender.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_HomeTown", txtHometown.Text.Trim() );
                mySqlCmd.Parameters.AddWithValue("_City", txtCity.Text.Trim() );
                mySqlCmd.Parameters.AddWithValue("_RelationshipStatus", txtRelationshipStatus.Text.Trim());

                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Succcessfully");
                Clear();
                GridFill();
            }
        }

        void GridFill()
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("UserViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblUser = new DataTable();

                sqlDa.Fill(dtblUser);
                dgvUser.DataSource = dtblUser;
                dgvUser.Columns[0].Visible = true;

            }


        }

        private void txtFirstName_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }


        void Clear()

        {

            txtFname.Text = txtLname.Text = txtGender.Text = txtHometown.Text = txtCity.Text = txtRelationshipStatus.Text = "";
            id = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;

        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {

            if(dgvUser.CurrentRow.Index != -1)
            {

                txtFname.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
                txtLname.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
                txtGender.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
                txtHometown.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
                txtCity.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();
                txtRelationshipStatus.Text = dgvUser.CurrentRow.Cells[6].Value.ToString();
                id = Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;

            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("UserDeleteById", mysqlCon);

                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", id);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Succcessfully");
                Clear();
                GridFill();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();


        }


    }
}
