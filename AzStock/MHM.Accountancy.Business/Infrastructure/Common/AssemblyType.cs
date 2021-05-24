using System;

namespace MHM.Accountancy.Business.Infrastructure.Common
{
    public class AssemblyType
    {
        public string AssemblyName { get; set; }
        public string AssemblyPath { get; set; }
        public string AssemblyDescription { get; set; }
        public DateTime FileModified { get; set; }
        public string Version { get; set; }
        public byte[] AssemblyBuffer { get; set; }
    }
}
