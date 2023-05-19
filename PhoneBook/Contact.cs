using PhoneBook.Interface;
using PhoneBook.Utils;
using System.Text.RegularExpressions;

namespace PhoneBook
{
    public class Contact : IContact
    {
        public int ContactId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        private string _separator;
        public string Separator
        {
            get
            {
                return _separator;
            }
            set
            {
                _separator = value;
                ValidateSeparator(_separator);
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get 
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                ValidatePhoneNumber(_phoneNumber);
            }
        }

        public string ErrorMessage { get; set; } = string.Empty;

        public void ValidatePhoneNumber(string phoneNumber)
        {
            bool isDigits = Regex.IsMatch(phoneNumber, @"^\d+$");
            bool isValid = phoneNumber.Length == 9 && isDigits;
            if (!isValid)
            {
                ErrorMessage += Constants.PHONE_VALIDATION_ERROR_MESSAGE;
            }
        }

        public void ValidateSeparator(string separator)
        {
            bool isValid = separator.Equals(":") || separator.Equals("-");
            if (!isValid)
            {
                ErrorMessage += Constants.SEPARATOR_VALIDATION_ERROR_MESSAGE;
            }
        }
    }
}
