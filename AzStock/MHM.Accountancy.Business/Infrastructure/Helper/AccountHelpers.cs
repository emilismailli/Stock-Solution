
using MHM.Accountancy.Business.Infrastructure.Extension;

namespace MHM.Accountancy.Business.Infrastructure
{
    public static partial class Helper
    {
        public static int AccountIdByCode(this IContainer container,string accountCode)
        {
            var parameters = Extension.Extension.InitParameters().Add("@code", accountCode);
            return container.CurrentUser.ExecuteScalar<int>("select [Accounting].[SFnAccountIdByCode](@code)", parameters);
        }

        public static decimal GoodPriceWholeById(this IContainer container, int goodId)
        {
            var parameters = Extension.Extension.InitParameters().Add("@id", goodId);
            return container.CurrentUser.ExecuteScalar<decimal>("select [Accounting].[SFnGetGoodPriceWholeSale](@id)", parameters);
        }

    }
}
