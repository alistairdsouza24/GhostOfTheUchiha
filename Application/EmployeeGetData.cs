using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class EmployeeGetData : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeGetData(IEmployeeRepository _employeeRepository)
        {
            _employeeRepository = _employeeRepository;
        }
        public void Delete(string username)
        {
            
        }

        public void Edit(EmployeeInfo editdata)
        {
            
        }

        public List<EmployeeInfo> Get()
        {
            var employeeinfo=new List<EmployeeInfo>();
            return employeeinfo;
            
        }

        public EmployeeInfo Get(string username)
        {
            


        }

        public void Post(EmployeeInfo getdata)
        {
            
        }
    }
}
