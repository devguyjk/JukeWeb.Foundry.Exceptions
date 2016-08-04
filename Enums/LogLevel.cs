using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JukeWeb.Foundry.Exceptions
{
    // Enum values are bitwise for 
    public enum LogLevel
    {
        NoLogging=1,
        Trace=2,
        Debug=4,
        OutputWindow=8,
        Email=64,
        EventLog=4096,
    }
}
