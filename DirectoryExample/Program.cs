using System;
using Business;// Call the Project where the business logic is sitting in.

namespace DirectoryExample
{
    //This is a mini version of how a repository is implemented.
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();//Create an object of the class which your logic is sitting in.
            //Call your methods by saying c.WhateverTheMethodIs();

            c.PathFind();
            c.Move();//File Is Moved

            c.Copying();
            c.CopyFile();//File Is Copied

            c.DeleteFile();//File Is Deleted
            Console.ReadLine();
        }

      
    }
}
