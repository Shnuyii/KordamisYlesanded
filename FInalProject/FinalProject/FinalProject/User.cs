using FinalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

//- -user klass on, tal on email username ja parool

namespace FinalProject
{
    public class User
    {
        public string userName = "";
        public string email = "";
        public string password = "";
        static void ExistingAccounts(string email, string userName, string password)
        {
            File.Create("RegisteredAccounts.txt");
        }
    }
}
