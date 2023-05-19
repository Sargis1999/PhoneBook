using PhoneBook.Utils;
using System;
using System.IO;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "";
            while (true)
            {
                Console.Write(Constants.PATH_MESSAGE);
                path = Console.ReadLine();
                string baseDirectory = AppContext.BaseDirectory;
                string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.Parent.FullName;
                path  = Path.Combine(projectDirectory, Constants.FOLDER_NAME, path);
                if (!File.Exists(path))
                {
                    Console.WriteLine(Constants.WRONG_PATH_MESSAGE);
                }
                else 
                {
                    break;
                }
            }

            Console.WriteLine(Constants.SORTING_ORDER_MESSAGE);
            string sortingOrder = Console.ReadLine();

            Console.WriteLine(Constants.SORTING_CRITERIA_MESSAGE);
            string criteria = Console.ReadLine();
            Console.WriteLine();

            PhoneBookManager.Instance.ReadPhoneBook(path);
            PhoneBookManager.Instance.PrintPhoneBook(criteria, sortingOrder);
        }
    }
}
