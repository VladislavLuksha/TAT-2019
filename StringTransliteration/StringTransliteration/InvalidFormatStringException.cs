using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTransliteration
{
    public class InvalidFormatStringException:Exception
    {
        public InvalidFormatStringException(string message) : base(message) { }
    }
}
