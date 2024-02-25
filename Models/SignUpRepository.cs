using System;
using System.Collections.Generic;

#nullable disable
using Glamour_Estore.Models;
namespace Glamour_Estore
{
    public partial class SignUpRepository
    {
        public void AddSignUpInfo( SignUp s)
        {
            SignUpContext sx = new SignUpContext();
            sx.SignUps.Add(s);
            sx.SaveChanges();
        }

    }
}
