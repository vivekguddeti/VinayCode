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

    public partial class User_Delete : Form
    {
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;
        DataRow Rec;
        SqlCommand Cmd;
        SqlCommandBuilder BLDR;

        public User_Delete()
        {
            InitializeComponent();
        }

        private void User_Delete_Load(object sender, EventArgs e)
        {
            Con=new SqlConnection(@"Server=DESKTOP-UFMTAR5;user Id=Sa;Password=vickyvicky__1997;Database=MicroProject");
            string SqlQuery = "select UserName,FirstName,LastName from Users where IsActive='Yes' "; 
            DA = new SqlDataAdapter(SqlQuery, Con);
            DS = new DataSet();
            Con.Open();
            DA.Fill(DS, "Users");
            
            DA.FillSchema(DS, SchemaType.Source, "Users");
            BLDR= new SqlCommandBuilder(DA);
            Con.Close();
            DGVUsers.DataSource = DS.Tables[0];

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in DGVUsers.SelectedRows)
            {
                string S = DGVUsers.SelectedRows[0].Cells[0].Value.ToString();
                string SqlQuery = "update Users set IsActive='No' where UserName='" + S+ "'";
                Cmd = new SqlCommand(SqlQuery, Con);
                Cmd.CommandType = CommandType.Text;
                Con.Open();
                int D = Cmd.ExecuteNonQuery();
                Con.Close();
            }
            foreach (DataGridViewRow row in DGVUsers.SelectedRows)
            {
                DGVUsers.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("User Deleted");

        }
    }
}
