using bookRent.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookRent.repo
{
    internal class AdminDB
    {
        Admin admin = new Admin();
        public List<Admin> admins = new List<Admin>();

        public void addAdmin (Admin admin)
        {
            admins.Add(admin);
        }
    }
}
