using System;
using System.Collections.Generic;
using ClassLibrary1;


namespace  ConsoleApp2

{
    public class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();
            var conn = DataBase.DataBaseConnect("", 0, "", "","");
        }
    }
}
