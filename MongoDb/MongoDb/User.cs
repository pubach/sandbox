using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pu.dataBase.mongoDb
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string[] Address { get; set; }
        public string[] PhoneNumbers { get; set; }
        public string[] Emails { get; set; }

    }
}
