using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Variables
            string fullName = "Mr. Rio Adhi Pratama";
            Console.WriteLine($"Hi, {fullName}");

            //SPLIT
            //string[] names = fullName.Split(' '); 
            //Console.WriteLine(names[1]);

            //SUBSTRING
            //string nickName, middleName, lastName;
            //nickName = fullName.Substring(4, 3);
            //middleName = fullName.Substring(8, 4);
            //lastName = fullName.Substring(13, 7);
            //Console.WriteLine(nickName);
            #endregion


            Console.ReadLine();
        }
    }
}
