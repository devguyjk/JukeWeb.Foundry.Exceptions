using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JukeWeb.Foundry.Exceptions
{
    public partial class WebGeneralException : BaseException
    {
        public WebGeneralException(string message) : base(message) { }
        public WebGeneralException(string message, Exception innerException) : base(message, innerException) { }
        public WebGeneralException(string message, ExceptionTypes exceptionType, Exception innerException) : base(message, exceptionType, innerException) 
        { 
        }
    }
}
