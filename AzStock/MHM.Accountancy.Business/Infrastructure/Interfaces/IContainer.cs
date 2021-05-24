

using MHM.Accountancy.Business.Infrastructure.Identity;
using System;

namespace MHM.Accountancy.Business.Infrastructure.Interfaces
{
    public interface IContainer : INotify
    {
        void InvokeAction(Action action);
        User CurrentUser { get; }
        string[] LisancedModules { get; }

        void RefreshNewCount(IManager manager);
        int SendError(Exception exception, IManager manager);
         
        ////Logger
        ////void Info();
        ////void Warn();
        ////void Debug();
        ////void Trace();
        ////void Error();
        ////void Fatal();
        //User CurrentUser { get; }
        //string[] LisancedModules { get; }

        //int SendError(Exception exception, IManager manager);

        //void RefreshNewCount(IManager manager);
    }
}
