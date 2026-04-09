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
        //public static void ExistingAccounts(string email, string password, string userName)
        //{
        //    File.Create("RegisteredAccounts.txt");
        //    File.AppendAllText("RegisteredAccounts.txt", email, password, userName);

        //}
    }
}
