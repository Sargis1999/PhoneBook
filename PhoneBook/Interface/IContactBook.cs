using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Interface
{
    interface IContactBook
    {
        void PrintContacts();

        void PrintValidations();

        void Sort(string criteria, string order);
    }
}
