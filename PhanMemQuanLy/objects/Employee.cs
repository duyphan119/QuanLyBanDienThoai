using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.objects
{
    public class Employee
    {
        public string id, name;
        public string password;
        public int permission;

        public Employee(string id, string name, string password, int permission)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.permission = permission;
        }

        public Employee() { }
    }
}
