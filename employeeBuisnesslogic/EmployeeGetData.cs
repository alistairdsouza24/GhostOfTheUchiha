using employeeBuisnesslogic.Interface;
using employeerepositorylayer;
using Microsoft.EntityFrameworkCore;
using Modellayer;
using ModeLlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeBuisnesslogic
{
    public class EmployeeGetData : IEmployeeInterface
    {
        private readonly AppContextDB _dbcontext;
        public EmployeeGetData(AppContextDB dbcontext)
        {
            _dbcontext = dbcontext;
        }



        public void Post(Adduserdetails getdata)
        {
            _dbcontext.Employee.Add(getdata);
            _dbcontext.SaveChanges();
        }

        public List<Adduserdetails> Get()
        {
            return _dbcontext.Employee.ToList();
        }

        


        public void Delete(string UserName)
        {

           Adduserdetails newadduserdetails = _dbcontext.Employee.FirstOrDefault(i => i.UserName == UserName);
            if (newadduserdetails != null)
            {
                _dbcontext.Remove(newadduserdetails);
                _dbcontext.SaveChanges();
            }
        }

        public void Edit(Adduserdetails editdata)
        {
            Adduserdetails newadduserdetails = _dbcontext.Employee.FirstOrDefault(i => i.UserName == editdata.UserName);
            if (newadduserdetails != null)
            {
                _dbcontext.Remove(newadduserdetails);
                _dbcontext.Employee.Add(editdata);
                _dbcontext.SaveChanges();

            }
        }

        public Adduserdetails Get(string username)
        {
            return _dbcontext.Employee.FirstOrDefault(i => i.UserName == username);
        }

        public void Post(Designation desdata)
        {
            _dbcontext.Employees.Add(desdata);
            _dbcontext.SaveChanges();
        }
    }
}

