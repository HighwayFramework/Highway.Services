// [[Highway.Onramp.Services]]
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Templates.App_Architecture.Services
{
    public interface IStopServiceEvent
    {
        int Order { get; }
        void Execute();
    }
}
