using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace ServiceLayer
{
    public class Employee
    {
        DataAccessLayer.Employee objdalemp = new DataAccessLayer.Employee();
        public int AddEmp(BusinessObjects.Employee objmodelemp)
        {
            int i = objdalemp.AddEmp(objmodelemp);
            return i;
        }


        public int DeleteEmp(BusinessObjects.Employee objmodelemp)
        {
            int i = objdalemp.DeleteEmp(objmodelemp);
            return i;
        }

        public List<BusinessObjects.Employee> GetEmp()//this method will return one collection
        {
            var emps = objdalemp.GetEmp();
            return emps;
        }
    }
}
