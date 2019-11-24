using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailRu
{
    public class InvalidPageException:Exception
    {
        public InvalidPageException(string message) : base(message) { }
    }
}
