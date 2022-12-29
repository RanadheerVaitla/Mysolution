using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BusinessObjects;

namespace DataAccessLayer
{
    public class Employee
     {
        public int AddEmp(BusinessObjects.Employee objmodelemp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());//create connection
            con.Open();//open connection
            string query = "insert into emp values('"+objmodelemp.Eno+"','"+objmodelemp.Ename+"','"+objmodelemp.Salary+"')";//write query
            SqlCommand cmd = new SqlCommand(query,con);//pass the query
            int i = cmd.ExecuteNonQuery();//execute the query(if the recored inserted successfully. then this method will return 1)
            con.Close();//close connection
            return i;
            //int obj  = cmd.ExecuteScalar();
            //SqlDataReader obj1 = cmd.ExecuteReader();

        }

        public int DeleteEmp(BusinessObjects.Employee objmodelemp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            string query = "delete from emp where eno = '" + objmodelemp.Eno + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        //public int UpdateEmp(BusinessObjects.Employee objmodelemp)
        //{
        //    SqlConnection con = new SqlConnection()
        //}
        public List<BusinessObjects.Employee> GetEmp()//this method will return one collection
        {
            List<BusinessObjects.Employee> emps = new List<BusinessObjects.Employee>();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            string query = "select * from emp";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BusinessObjects.Employee objemp = new BusinessObjects.Employee();
                    objemp.Eno = Convert.ToInt32(dr[0]);
                    objemp.Ename = dr[1].ToString() ;
                    objemp.Salary = Convert.ToDouble(dr[2]);
                    emps.Add(objemp);
                }                
            }
            return emps;
        }
    }
}
