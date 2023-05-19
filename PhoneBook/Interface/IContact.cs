using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Interface
{
    public interface IContact
    {
        void ValidatePhoneNumber(string phoneNumber);

        void ValidateSeparator(string separator);
    }
}
