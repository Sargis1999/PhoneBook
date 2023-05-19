using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Utils
{
    public static class Constants
    {
        public const string PHONE_VALIDATION_ERROR_MESSAGE = "Phone number number should be with 9 digits.";
        
        public const string SEPARATOR_VALIDATION_ERROR_MESSAGE = "The separator should be `:` or `-`.";
        
        public const string FILE_STRUCTURE_MESSAGE = "File Structures:";
        
        public  const string VALIDATION_MESSAGE = "Validations";
        
        public  const string NAME = "Name";

        public  const string SURNAME = "Surname";

        public  const string PHONENUMBER_CODE = "PhoneNumberCode";

        public const string DESCENDING = "Descending";
        
        public const string ASCENDING = "Ascending";

        public const string WRONG_SORTING_ORDER = "Wrong sorting order";

        public const string WRONG_SORTING_OR_CRITERIA = "Wrong criteria or sorting order";

        public const string PATH_MESSAGE = "Enter File path:";

        public const string FOLDER_NAME = "Files";

        public const string WRONG_PATH_MESSAGE = "Wrong path.";

        public const string SORTING_ORDER_MESSAGE = "Please choose an ordering to sort: “Ascending” or “Descending”.";

        public const string SORTING_CRITERIA_MESSAGE = "Please choose criteria: “Name”, “Surname” or “PhoneNumberCode”.";

    }
}
