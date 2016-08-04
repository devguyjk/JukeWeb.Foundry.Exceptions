using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JukeWeb.Foundry.Exceptions
{
    public class GeneralException : BaseException
    {
        public GeneralException() { }
        public GeneralException(string message) : base(message) { }
        public GeneralException(string message, Exception innerException) : base(message, innerException) { }
        public GeneralException(string message, ExceptionTypes exceptionType, Exception innerException) : base(message, exceptionType, innerException) { }
#if !SILVERLIGHT
        public GeneralException(IDictionary<string, object> nameValueMessages) : base(nameValueMessages.ToFormattedErrorMessage(), null) { }
        public GeneralException(IDictionary<string, object> nameValueMessages, Exception innerException) : base(nameValueMessages.ToFormattedErrorMessage(), innerException) { }
#endif
    
    }
}
