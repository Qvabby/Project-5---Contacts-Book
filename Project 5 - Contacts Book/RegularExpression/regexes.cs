using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project_5___Contacts_Book.RegularExpression
{
    public class regexes
    {
        ////+995 xx xx xx
        public static Regex NumberRegex = new Regex(@"^\+995\s[0-9]{3}\s[0-9]{2}\s[0-9]{2}\s[0-9]{2}$");
        public static Regex NumberRegex2 = new Regex(@"^\+995[0-9]{3}[0-9]{2}[0-9]{2}[0-9]{2}$");
    }
}
