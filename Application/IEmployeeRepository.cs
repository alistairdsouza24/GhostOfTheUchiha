using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IEmployeeRepository
    {

        public List<EmployeeInfo> Get();
        public EmployeeInfo Get(string username);
        void Post(EmployeeInfo getdata);
        void Edit(EmployeeInfo editdata);

        void Delete(string username);

        //void Post(Designation desdata);
    }
}
