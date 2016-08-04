using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JukeWeb.Foundry.Exceptions
{
    public partial class ServiceGeneralException : BaseException
    {
        public ServiceGeneralException(string message) : base(message) { }
        public ServiceGeneralException(string message, Exception innerException) : base(message, innerException) { }
        public ServiceGeneralException(string message, ExceptionTypes exceptionType, Exception innerException) : base(message, exceptionType, innerException) { }
    }
}
