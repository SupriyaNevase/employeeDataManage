using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
namespace EmployeeData
{
    public class ClsEmp
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6EEOFMV\\SQLEXPRESS01;Initial Catalog=EmployeeData;Integrated Security=True");
        private string text1;
        private string text2;
        private string text3;

        public int Id { get; }
        public string EmpName { get; }
        public string Address { get; }
        public string PhoneNumber { get; }

        public string Gender { get; }


        public ClsEmp()
        {

        }

        //public ClsEmp(string EmpName, string Address, string phone, string Gender)
        //{
        //    EmpName = EmpName;
        //    Address = Address;
        //    PhoneNumber = PhoneNumber;

        //    Gender = Gender;
        //}

        //public ClsEmp(int Id, string EmpName, string Address, string phone, string Gender)
        //{
        //    Id = Id;
        //    EmpName = EmpName;
        //    Address = Address;
        //    PhoneNumber = PhoneNumber;

        //    Gender = Gender;

        //}


        public void SaveEmp(string EmpName, string Address, string PhoneNumber, string Gender)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EmpSave");
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable ShowAllEmp()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAllEMP");
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public void DeleteEmp(string EmpName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteEmp");
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataReader Show(string EmpName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Show");
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            //SqlDataAdapter adpt = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            //adpt.SelectCommand = cmd;
            //adpt.Fill(dt);
            //return dt;
            return dr;
            con.Close();
        }
        public void UpdateEmp(string EmpName, string Address, string PhoneNumber, string Gender)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Update");
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }

}