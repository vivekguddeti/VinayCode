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

    public partial class View_User : Form
    {
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;

        public View_User()
        {
            InitializeComponent();
        }

        private void View_User_Load(object sender, EventArgs e)
        {
            Con=new SqlConnection(@"Server=DESKTOP-UFMTAR5;user Id=Sa;Password=vickyvicky__1997;Database=MicroProject");
            string SqlQuery = "select UserName,FirstName,LastName from Users ";
            //string SqlQuery = "select UserName,FirstName,LastName from Users where  IsActive='Yes' ";
            DA = new SqlDataAdapter(SqlQuery, Con);
            DS = new DataSet();
            Con.Open();
            DA.Fill(DS, "Users");
            DA.FillSchema(DS, SchemaType.Source, "Users");
            Con.Close();
            dataGridView1.DataSource = DS.Tables[0];


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void View_User_Load_1(object sender, EventArgs e)
        {

        }
    }
}
