using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public class Account
    {
        public string _id { get; set; }
        public string _name { get; set; }
        public int _role { get; set; }
        public string _idEmp { get; set; }
        public Account()
        {
        }
        public Account(string id, string name, int role, string idEmp)
        {
            _id = id;
            _name = name;
            _role = role;
            _idEmp = idEmp;
        }   
    }
   
}
