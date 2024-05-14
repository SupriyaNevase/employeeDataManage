using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;

namespace EmployeeData
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClsEmp objclsEmp = new ClsEmp();
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void btnSave_Click(object sender, EventArgs e)
        {


            objclsEmp.SaveEmp(txtName.Text, txtAdd.Text, txtNo.Text, txtGender.Text);
            txtName.Text = "";
            txtAdd.Text = "";
            txtNo.Text = "";
            txtGender.Text = "";
            Response.Write("<Script>alert('Emp Saved Successfully....')</Script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = objclsEmp.ShowAllEmp();
            GrdEmp.DataSource = dt;
            GrdEmp.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            objclsEmp.DeleteEmp(txtName.Text);
            Response.Write("<Script>alert('Employee Deleted Successfully....')</Script>");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            SqlDataReader dr;
            dr = objclsEmp.Show(txtName.Text);

            if (dr.Read())
            {
                txtName.Text = dr["EmpName"].ToString();
                txtAdd.Text = dr["Address"].ToString();
                txtNo.Text = dr["PhoneNumber"].ToString();
                txtGender.Text = dr["Gender"].ToString();
            }


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            objclsEmp.UpdateEmp(txtName.Text, txtAdd.Text, txtNo.Text, txtGender.Text);
            Response.Write("<Script>alert('Emp Updated Successfully....')</Script>");
        }
    }
}