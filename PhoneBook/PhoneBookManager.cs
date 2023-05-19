using System;
using System.IO;

namespace PhoneBook
{
    public class PhoneBookManager
    {
        private static PhoneBookManager _instance;

        public static PhoneBookManager Instance
        {
            get
            {
                _instance = _instance == null ? new PhoneBookManager() : _instance;
                return _instance;
            }
        }

        private ContactBook _contacts { get; set; } = new ContactBook();

        public void ReadPhoneBook(string path)
        {
            try
            {
                string[] test = File.ReadAllLines(path);
            
            for (int i = 0; i < test.Length; i++)
            {
                string[] splited = test[i].Split(' ');
                var contact = new Contact();
                if (splited.Length < 4)
                {
                    contact.Name = splited[0];
                    contact.Separator = splited[1];
                    contact.PhoneNumber = splited[2];
                }
                else
                {
                    contact.Name = splited[0];
                    contact.Surname = splited[1];
                    contact.Separator = splited[2];
                    contact.PhoneNumber = splited[3];
                }

                _contacts.Contacts.Add(contact);
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void PrintPhoneBook(string sortingCriteria, string sortingOrder)
        {
            _contacts.Sort(sortingCriteria, sortingOrder);
            _contacts.PrintContacts();
            _contacts.PrintValidations();
        }
    }
}
