using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JukeWeb.Foundry.Exceptions
{
    public abstract class BaseException : SystemException
    {
        private LogLevel _loggingLevel = LogLevel.NoLogging;
        private IDictionary<string, object> _nameValuePairs = new Dictionary<string, object>();
        private SeverityLevel _severityOfException = SeverityLevel.Low;
        private ExceptionTypes _exceptionType = ExceptionTypes.NotSet;

        public ExceptionTypes ExceptionType
        { 
            get {return _exceptionType; }
            set { _exceptionType = value; } 
        }

        public LogLevel LoggingLevel
        {
            get { return _loggingLevel; }
            set { _loggingLevel = value; }
        }
        public SeverityLevel SeverityofException
        {
            get { return _severityOfException; }
            set { _severityOfException = value; }
        }

        public int ExceptionCode
        {
            get { return (int)_exceptionType; }
        }

        public IDictionary<string, object> NameValuePairs
        {
            get { return _nameValuePairs; }
            set { _nameValuePairs = value; }
        }

        public BaseException() { }
        public BaseException(string message) : base(message) { }
        public BaseException(string message, Exception innerException) : base(message, innerException) { }
#if !SILVERLIGHT
        public BaseException(IDictionary<string, object> nameValueMessages) : base(nameValueMessages.ToFormattedErrorMessage(), null) { }
        public BaseException(IDictionary<string, object> nameValueMessages, Exception innerException) : base(nameValueMessages.ToFormattedErrorMessage(), innerException) { }
#endif        
        public BaseException(string message, ExceptionTypes exceptionType, Exception innerException) : base(message, innerException) 
        {
            _exceptionType = exceptionType;
        }

        public BaseException(string message, string info, LogLevel loggingLevel, ExceptionTypes exceptionType, Exception innerException, SeverityLevel severityOfException): base(message, innerException)
        {
            _loggingLevel = loggingLevel;
            _severityOfException = severityOfException;
            InvokeLogging();
        }

        protected virtual void InvokeLogging()
        {             
        }
    }
}
