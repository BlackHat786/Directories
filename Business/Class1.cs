using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Business
{
    public class Class1
    {
        public void PathFind()
        {
            Console.WriteLine("Finding Path...");
        }

        public async Task Move()
        {
            //Find the Source Path
            string existingPath = @"C:\Users\Public\Music\text.txt";//Note that this is your file path on Your PC.
            //Create a variable that contains the new path of which the file is being moved to.
            string newPath = @"C:\Users\Public\Music\New folder\text.txt";//Note that this is your file path on Your PC.

            try
            {
                //Move the File if it exists
                File.Move(existingPath, newPath);
                Console.WriteLine("The file has been moved");
            }
            catch (Exception e)
            {
                //throw an exception if the path does not exist.
                Console.WriteLine("The file has Does not exist", e);
            }

            Console.ReadLine(); ;
        }

        public void Copying()
        {
            Thread.Sleep(100); //Done To see the how the file is being copied lived. Open the Directory and see if it's being done.
            Console.WriteLine("Finding Path...");
            Console.WriteLine("Copying File Path");
        }
        //The below is similar to the above but here we are coping a file from one 
        //Directory to another.
        public async Task CopyFile()
        {
            string existingPath = @"C:\Users\Public\Music\New folder\text.txt";//Note that this is your file path on Your PC.
            string newPath = @"C:\Users\Public\Music\text.txt";//Note that this is your file path on Your PC.
            Thread.Sleep(100);//Done To see the how the file is being copied lived. Open the Directory and see if it's being done.

            try
            {
                File.Copy(existingPath, newPath);               
                Console.WriteLine("The file has been Copied");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file has Does not exist", e);
            }

            Console.ReadLine(); ;
        }

        public async Task DeleteFile()
        {

            string existingFile = @"C:\Users\Public\Music\New folder\text.txt";//Note that this is your file path on Your PC.
            Thread.Sleep(100);//Done To see the how the file is being copied lived. Open the Directory and see if it's being done.

            try
            {
                //here we are deleting a file from an existing directory
                File.Delete(existingFile);
                Console.WriteLine("File Has Been Deleted");
            }
            catch (Exception)
            {

                Console.WriteLine("File Does Not Exist");
            }
        }
    }
}
