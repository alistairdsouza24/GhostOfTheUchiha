using Modellayer;
using ModeLlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeBuisnesslogic.Interface
{
    public interface IEmployeeInterface
    {
       public List<Adduserdetails> Get();
        public Adduserdetails Get(string username);
        void Post(Adduserdetails getdata);
        void Edit(Adduserdetails editdata);

        void Delete(string username);

        void Post(Designation desdata);
    }
}
