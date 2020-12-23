using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenter
{
    class Person
    {
        public int ID;
        public string Firstname;
        public string Lastname;
        public string Email;
        public string Phone;
        public string Gender;
        public string Address;
        public string Username;
        public string password;
        public int role;
        public const string DBC = "Data Source=DESKTOP-NC87HB1;Initial Catalog=TrainingCenter;Integrated Security=True";

    }
}
