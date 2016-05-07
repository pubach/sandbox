using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using MongoDB.Bson;
=======
>>>>>>> 29b6cce5dcb1e225210a7473a972a40bb9716f9f

namespace pu.dataBase.mongoDb
{
    public class User
    {
<<<<<<< HEAD
        public ObjectId objectId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
=======
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
>>>>>>> 29b6cce5dcb1e225210a7473a972a40bb9716f9f
        public string[] Address { get; set; }
        public string[] PhoneNumbers { get; set; }
        public string[] Emails { get; set; }

    }
}
