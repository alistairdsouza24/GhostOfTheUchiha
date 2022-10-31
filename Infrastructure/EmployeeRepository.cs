using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Delete(string username)
        {
            throw new NotImplementedException();
        }

        public void Edit(EmployeeInfo editdata)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeInfo> Get()
        {
            throw new NotImplementedException();
        }

        public EmployeeInfo Get(string username)
        {
            throw new NotImplementedException();
        }

        public void Post(EmployeeInfo getdata)
        {
            throw new NotImplementedException();
        }
    }
}
