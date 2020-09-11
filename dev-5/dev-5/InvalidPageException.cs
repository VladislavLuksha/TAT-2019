using System;

namespace dev_5
{
    /// <summary>
    /// 
    /// </summary>
    public class InvalidPageException:Exception
    {
        public InvalidPageException(string message) : base(message) { }
    }
}
