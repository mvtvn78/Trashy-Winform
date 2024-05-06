using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trashy_WinForm
{
     class User
    {
        public User() { }
        public User(int _id , string _u,string _p,string _f,string _a,string _e) 
        {
            this.Codeid = _id;
            this.Username = _u;
            this.Password = _p;
            this.Fullname = _f;
            this.Email = _e;
            this.Address = _a;
        }
        public int Codeid {get;set;}
        public string Username { get;set;}
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
      
    }
}
