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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Microproject2
{
    public partial class Change_Password : Form
    {
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataReader DR;
        SqlParameter P;
        public string UserName = Login_UserName'.USERNAME;
        

        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            Con=new SqlConnection(@"Server=DESKTOP-UFMTAR5;user Id=Sa;Password=vickyvicky__1997;Database=MicroProject");
            CmbHQuestion.Items.Add("What is Your BestFriend Name");
            CmbHQuestion.Items.Add("What is Your Favorite Place");
            CmbHQuestion.Items.Add("What is Your Lucky Number");
        }

        private void OptoldPwd_CheckedChanged(object sender, EventArgs e)
        {
            lblHintQuestion.Visible = false;
            CmbHQuestion.Visible = false;
            lblHintAns.Visible = false;
            txtHintAns.Visible = false;
            lblOldPwd.Visible = true;
            txtOldPwd.Visible = true;
            foreach ( Control C in this.Controls)
            { 
                if (C is TextBox || C is ComboBox) 
                {
                    C.Text = "";
                }

            }

        }

        private void OptHQuestion_CheckedChanged(object sender, EventArgs e)
        {
            lblOldPwd.Visible = false;
            txtOldPwd.Visible = false;
            lblHintQuestion.Visible = true;
            txtHintAns.Visible = true;
            lblHintAns.Visible = true;
            CmbHQuestion.Visible = true;
            this.lblHintQuestion.Location = new System.Drawing.Point(250, 248);
            this.CmbHQuestion.Location = new System.Drawing.Point(487, 241);
            this.lblHintAns.Location = new System.Drawing.Point(250, 301);
            this.txtHintAns.Location = new System.Drawing.Point(487, 294);
            foreach (Control C in this.Controls)
            {

                if (C is TextBox || C is ComboBox)
                {
                    C.Text = "";
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtOldPwd_Leave(object sender, EventArgs e)
        {
            string SqlQuery = "select PassWord from Users where UserName = "+"'"+UserName+"'";
            Cmd = new SqlCommand(SqlQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            DR = Cmd.ExecuteReader();
            while (DR.Read() == true)
            {
                if (DR[0].ToString() == txtOldPwd.Text)
                {
                    txtNewPwd.Enabled = true;
                    txtRePwd.Enabled = true;
                    btnSubmit.Enabled = true;
                }
                else
                {
                    txtNewPwd.Enabled = false;
                    txtRePwd.Enabled = false;
                    txtOldPwd.Focus();
                    MessageBox.Show("You Entered InCorrect Password");
                    btnSubmit.Enabled = false;
                    break;
                }
            }
            Con.Close();
             

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.TextLength==0||txtRePwd.TextLength==0)
            {
                MessageBox.Show("Please Enter Proper Data");
            }
            else
            {
                Cmd = new SqlCommand("Change_Password_UOP", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                P = new SqlParameter("@PUserName", SqlDbType.VarChar, 20);
                P.Value = UserName;
                Cmd.Parameters.Add(P);
                P = new SqlParameter("@POldPassword", SqlDbType.VarChar, 10);
                P.Value = txtOldPwd.Text;
                Cmd.Parameters.Add(P);
                P = new SqlParameter("@PNewPassword", SqlDbType.VarChar, 10);
                P.Value = txtNewPwd.Text;
                Cmd.Parameters.Add(P);
                P = new SqlParameter("@PReEnterPassword", SqlDbType.VarChar, 10);
                P.Value = txtRePwd.Text;
                Cmd.Parameters.Add(P);
                Con.Open();
                int i = Cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Password Changed");
            }
        }

        private void txtRePwd_Leave(object sender, EventArgs e)
        {

            if (txtNewPwd.Text==txtRePwd.Text)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
                MessageBox.Show("Password Not Matched");
                txtNewPwd.Focus();
            }
        }

        private void CmbHQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SqlQuery = "Select HintQuestion from Users where UserName=" + "'" +UserName + "'";
            Cmd = new SqlCommand(SqlQuery, Con);
            Cmd.CommandType = CommandType.Text;
            string S = CmbHQuestion.SelectedItem.ToString();
            Con.Open();
            DR = Cmd.ExecuteReader();
            while (DR.Read())
            {
                if (DR[0].ToString() == S.ToString())
                {
                    txtHintAns.Enabled = true;
                }
                else
                {
                    txtHintAns.Enabled = false;
                    MessageBox.Show("HintQuestion Does Not Match with UserName"+" "+UserName);
                }
            }
            Con.Close();

        }

        private void txtHintAns_TextChanged(object sender, EventArgs e)
        {
            string SqlQuery = "Select HintAnswer from Users where UserName=" + "'" + UserName+ "'";
            Cmd = new SqlCommand(SqlQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            DR = Cmd.ExecuteReader();
            while (DR.Read())
            {
                if (DR[0].ToString() == txtHintAns.Text)
                {
                    txtNewPwd.Enabled = true;
                    txtRePwd.Enabled = true;
                    
                }
                else
                {
                    txtNewPwd.Enabled = false;
                    txtRePwd.Enabled = false;
                    MessageBox.Show("Hint Answer Does Not Match with UserName" + " " +
                   UserName);
                    txtHintAns.Focus();

                }
            }
            Con.Close();
        }
    }
}










