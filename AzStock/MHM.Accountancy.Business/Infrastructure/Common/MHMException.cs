using System;

namespace MHM.Accountancy.Business.Infrastructure.Common
{

    public class MHMException : Exception
    {
        public MHMException(string message)
            : base(message)
        {

        }
    }

    public class MHMWarning : Exception
        {
            public MHMWarning(string message)
                : base(message)
            {

            }
        }

        public class MHMInformation : Exception
        {
            public MHMInformation(string message)
                : base(message)
            {

            }
        }

    }
 
