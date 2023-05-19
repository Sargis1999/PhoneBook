using PhoneBook.Interface;
using PhoneBook.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class ContactBook : IContactBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void PrintContacts()
        {
            Console.WriteLine(Constants.FILE_STRUCTURE_MESSAGE);
            foreach (var item in Contacts)
            {
                string contact = string.IsNullOrEmpty(item.Surname) ? $"{item.Name} {item.Separator} {item.PhoneNumber}" : $"{item.Name} {item.Surname} {item.Separator} {item.PhoneNumber}";
                Console.WriteLine(contact);
            }
            Console.WriteLine();
        }

        public void PrintValidations()
        {
            Console.WriteLine(Constants.VALIDATION_MESSAGE);
            int i = 1;
            foreach (var item in Contacts)
            {
                if (!string.IsNullOrEmpty(item.ErrorMessage))
                {
                    Console.WriteLine($"Line{i}: {item.ErrorMessage}");
                }
                i++;
            }
            Console.WriteLine();
        }

        public void Sort(string criteria, string order)
        {
            switch (criteria)
            {
                case Constants.NAME:
                    {
                        if (Constants.DESCENDING.Equals(order))
                        {
                            Contacts = Contacts.OrderByDescending(x => x.Name).ToList();
                        }
                        else if (Constants.ASCENDING.Equals(order))
                        {
                            Contacts = Contacts.OrderBy(x => x.Name).ToList();
                        }
                        else 
                        {
                            Console.WriteLine(Constants.WRONG_SORTING_ORDER);
                        }
                        break;
                    }
                case Constants.SURNAME:
                    {
                        if (Constants.DESCENDING.Equals(order))
                        {
                            Contacts = Contacts.OrderByDescending(x => x.Surname).ToList();
                        }
                        else if (Constants.ASCENDING.Equals(order))
                        {
                            Contacts = Contacts.OrderBy(x => x.Surname).ToList();
                        }
                        else
                        {
                            Console.WriteLine(Constants.WRONG_SORTING_ORDER);
                        }
                        break;
                    }
                case Constants.PHONENUMBER_CODE:
                    {
                        if (Constants.DESCENDING.Equals(order))
                        {
                            Contacts = Contacts.OrderByDescending(item => (item.PhoneNumber.Length <= 3 ? item.PhoneNumber : item.PhoneNumber.Substring(0, 3))).ToList();
                        }
                        else if (Constants.ASCENDING.Equals(order))
                        {
                            Contacts = Contacts.OrderByDescending(item => (item.PhoneNumber.Length <= 3 ? item.PhoneNumber : item.PhoneNumber.Substring(0, 3))).ToList();
                        }
                        else
                        {
                            Console.WriteLine(Constants.WRONG_SORTING_ORDER);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(Constants.WRONG_SORTING_OR_CRITERIA);
                        break;
                    }
            }
        }
    }
}
