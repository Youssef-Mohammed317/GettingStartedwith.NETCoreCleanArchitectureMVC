using CleanArch.Domain.CoreV2.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.CoreV2.Bus
{
    public interface IMediatRHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
