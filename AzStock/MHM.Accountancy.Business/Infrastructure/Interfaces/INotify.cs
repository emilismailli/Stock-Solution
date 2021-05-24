using System;

namespace MHM.Accountancy.Business.Infrastructure.Interfaces
{
    public interface INotify
    {
        void PrintError(Exception exception,bool clear=false);
        void PrintSuccess(string message, bool clear = true);
    }
}
