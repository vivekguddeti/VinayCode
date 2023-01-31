using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Microproject2
{
    public partial class Create_User : Form
    {
        SqlParameter P;
        SqlCommand cmd;
        SqlConnection con;
        string Sqlquery;
        SqlDataReader DR;


        public Create_User()
        {
            InitializeComponent();
        }

        private void Create_User_Load(object sender, EventArgs e,Label CmbHQuestions)
        {
           
          /*  CmbHQuestions..Add("What is Your BestFriend Name");
            CmbHQuestions.Items.Add("What is Your Favorite Place");
            CmbHQuestions.Items.Add("What is Your Lucky Number");
           */

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (TxtUser.TextLength==0||TxtPwd.TextLength==0||TxtConfirmpwd.TextLength==0||TxtFName.TextLength==0||TxtLName.TextLength==0||TxtHAns.TextLength==0)
            {
                MessageBox.Show("Please Enter Valid Details");
                btnCreate.Enabled = true;
            }
            else
            {
                /* Cmd = new SqlCommand("User_Create", Con); 
                Cmd.CommandType = CommandType.StoredProcedure; 
                P = new SqlParameter("@PUserName", SqlDbType.VarChar, 20); 
                P.Value = txtUser.Text; 
                Cmd.Parameters.Add(P); 
                P = new SqlParameter("@PPassword", SqlDbType.VarChar, 10); 
                P.Value = txtPwd.Text; 
                Cmd.Parameters.Add(P); 
                P = new SqlParameter("@PConfirmPassword", SqlDbType.VarChar, 10); 
                P.Value = txtConfirmPwd.Text; 
                Cmd.Parameters.Add(P); 
                 P = new SqlParameter("@PFirstName", SqlDbType.VarChar, 20); 
                P.Value = txtFName.Text; 
                Cmd.Parameters.Add(P); 
                P = new SqlParameter("@PLastName", SqlDbType.VarChar, 20); 
                P.Value = txtLName.Text; 
                Cmd.Parameters.Add(P); 
                P = new SqlParameter("@PHintQuestion", SqlDbType.VarChar, 50); 
                P.Value = CmbHintQues.SelectedItem; 
                Cmd.Parameters.Add(P); 
                P = new SqlParameter("@PHintAnswer", SqlDbType.VarChar, 50); 
                P.Value = txtHintAns.Text; 
                Cmd.Parameters.Add(P); 
                Con.Open(); 
                int i = Cmd.ExecuteNonQuery(); 
                Con.Close(); 
                MessageBox.Show(i + " User Account is Created");*/


                string SqlQuery = "Insert into Users values(@P1,@P2,@P3,@P4,@P5,@P6,@P7)";
                cmd=new SqlCommand(SqlQuery, con);
                cmd.CommandType= CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", TxtUser.Text);
                cmd.Parameters.AddWithValue("@P2", TxtPwd.Text);
                cmd.Parameters.AddWithValue("@P3",TxtFName.Text);
                cmd.Parameters.AddWithValue("@P4", TxtLName.Text);
                cmd.Parameters.AddWithValue("@P5", CmbHQuestions.CanSelect);
                cmd.Parameters.AddWithValue("@P6", TxtHAns.Text);
                cmd.Parameters.AddWithValue("@P7", "Yes");
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(i + "User Account is Created");
            }
        }

        private void TxtcPwd_Click(object sender, EventArgs e)
        {

         
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control C in this.Controls)
            {
                if (C is TextBox|| C is ComboBox)
                {
                    C.Text = " ";
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtUName_Click(object sender, EventArgs e)
        {
           
        }

        private void Create_User_Load(object sender, EventArgs e)
        {
            con=new SqlConnection(@"Server=DESKTOP-UFMTAR5;user Id=Sa;Password=vickyvicky__1997;Database=MicroProject");
            CmbHQuestions.Items.Add("What is Your BestFriend Name");
            CmbHQuestions.Items.Add("What is Your Favorite Place");
            CmbHQuestions.Items.Add("What is Your Lucky Number");
            TxtFName.Enabled = false;
            TxtLName.Enabled = false;
            TxtHAns.Enabled = false;
            CmbHQuestions.Enabled = false;
            btnCreate.Enabled = true;
            TxtPwd.Enabled = false;
            TxtConfirmpwd.Enabled = false;
            
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            Sqlquery = "select UserName from Users";
            cmd = new SqlCommand(Sqlquery, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            DR = cmd.ExecuteReader();

            while (DR.Read()==true)
            {
                if (DR[0].ToString()==TxtUser.Text)
                {
                    TxtPwd.Enabled = false;
                    TxtConfirmpwd.Enabled = false;
                    TxtUser.Focus();
                    MessageBox.Show("Can Not Create Multiple Users with Same Name");
                    break;
                }
                else
                {
                    TxtPwd.Enabled = true;
                    TxtConfirmpwd.Enabled = true;
                }
            }
            con.Close();
        }

        private void TxtConfirmpwd_Leave(object sender, EventArgs e)
        {
            if (TxtPwd.Text == TxtConfirmpwd.Text)
            {

                TxtFName.Enabled = true;
                TxtLName.Enabled=true;
                TxtHAns.Enabled=true;
                CmbHQuestions.Enabled= true;
                btnCreate.Enabled = true;
            }
            else
            {
                TxtFName.Enabled = false;
                TxtLName.Enabled = false;
                TxtHAns.Enabled = false;
                CmbHQuestions.Enabled = false;
                btnCreate.Enabled = false;
                TxtPwd.Focus();
                MessageBox.Show("Password does not Match");
            }
        }
    }
}
