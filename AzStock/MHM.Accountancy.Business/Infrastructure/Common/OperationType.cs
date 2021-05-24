namespace MHM.Accountancy.Business.Infrastructure.Common
{
    public enum OperationType : byte
    {
        None = 0,
        Add = 1,
        Edit = 2,
        Delete = 3,
        Select = 4,
        PrintWithSelect = 5,
        DeleteWithSelect = 6,
        Lock = 7,
        AddWithSelect = 11,
        EditWithSelect = 12,
        LockWithSelect = 15,
        Archive = 20,
        RetailReceiptSelect = 24,
        ArchiveWithRepair = 30
    }
}
