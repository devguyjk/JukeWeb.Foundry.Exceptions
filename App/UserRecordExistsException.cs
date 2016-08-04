using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JukeWeb.Foundry.Exceptions.App
{
    public class UserRecordExistsException : BaseException
    {
        public UserRecordExistsException(string message) : base(message) { }
    }
}
