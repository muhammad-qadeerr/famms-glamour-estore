using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Glamour_Estore.Models;
namespace Glamour_Estore.Models
{
    public class loginRepository
    {
        public string CheckLogIn(login s)
        {

            SignUpContext sx = new SignUpContext();

            var user1 = sx.SignUps.ToList();
            foreach(var s1 in user1)
            {
                if (s1.Email.TrimEnd() == s.email.TrimEnd() && s1.Password.TrimEnd() == s.password.TrimEnd())
                {
                    string username = s1.Username;
                    return username;
                }
                
            }
            return null;
        }


    }
}
