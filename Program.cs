using System;
using System.IO;

namespace Day08_Assignment_10
{
    internal class Program
    {
        public static void createFile()
        {
            Console.WriteLine("Enter the Path for the new file");
            string fpath = Console.ReadLine();
            Console.WriteLine("Enter the New File's name");
            string name = Console.ReadLine();
            string thePath = fpath + name;
            if (File.Exists(thePath))
            {
                Console.WriteLine("The File Already Exists");
            }
            else
            {
                StreamWriter sw = File.AppendText(thePath);
                sw.WriteLine("This is Assignment No : 10");
                sw.WriteLine("Topic : File Handling");
                sw.Dispose();
                sw.Close();
                Console.WriteLine("Now the File is Created in the Directory");
            }
        }
        public static void readFiles()
        {
            Console.WriteLine("Enter the File name and its Path to read");
            string readFile = Console.ReadLine();
            StreamReader sr = new StreamReader(readFile);
            string text = "";
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            sr.Close();
        }
        public static void appendFiles()
        {
            Console.WriteLine("Enter the Path for the file to Open");
            string openFile = Console.ReadLine();
            Console.WriteLine("Enter the Content to Append");
            string appendFile = Console.ReadLine();
            File.AppendAllText(openFile, appendFile);
        }
        public static void deleteFiles()
        {
            Console.WriteLine("Enter the Path for the file to Delete");
            string deleteFile = Console.ReadLine();
            File.Delete(deleteFile);
            Console.WriteLine("The File is Deleted from the Directory");
        }

        static void Main(string[] args)
        {
        again:
            try
            {
                Console.WriteLine("Choose An Operation");
                Console.WriteLine("1. Create a new file");
                Console.WriteLine("2. Read a file");
                Console.WriteLine("3. Append to a file");
                Console.WriteLine("4. Delete a file");
                Console.WriteLine("Enter the operation number");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            createFile();
                            break;
                        }
                    case 2:
                        {
                            readFiles();
                            break;
                        }
                    case 3:
                        {
                            appendFiles();
                            break;
                        }
                    case 4:
                        {
                            deleteFiles();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choice not Found");
                            break;
                        }

                }
                Console.WriteLine("\n\n");
                Console.WriteLine("Do you want to Continue?\n1.Yes\t2.No");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    goto again;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting file: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("*** The Program is End ***");
            }







        }


    }

}
