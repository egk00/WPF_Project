using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Cloning_Evernote.Model
{
    public class User
    {
        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        [MaxLength(50)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string lastname;
        [MaxLength(50)]
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private string usesrname;

        public string Username
        {
            get { return usesrname; }
            set { usesrname = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
