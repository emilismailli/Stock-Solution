using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Identity;
using MHM.Accountancy.Business.Infrastructure.Interfaces;


namespace MHM.Accountancy.Business.Infrastructure
{
    public static partial class Helper
    {
        public static int? AccountIdByCode(this IContainer container, string accountCode)
        {
            //var parameters = Helper.Init().Add("@code", accountCode);
            //return container.CurrentUser.ExecuteScalar<int>("select [Accounting].[SFnAccountIdByCode](@code)", parameters);
            return AccountIdByCode(container.CurrentUser,accountCode);
        }

        public static int? AccountIdByCode(this User currentUser, string accountCode)
        {
            var parameters = Helper.Init().Add("@code", accountCode);
            return currentUser.ExecuteScalar<int>("select [Accounting].[SFnAccountIdByCode](@code)", parameters);
        }


        //aliw qiymeti 
        public static decimal? BuyPricesByGoodId(this IContainer container, int goodId)
        {
            return BuyPricesByGoodId(container.CurrentUser, goodId);
        }

        public static decimal? BuyPricesByGoodId(this User currentUser, int goodId)
        {
            var parameters = Helper.Init().Add("@id", goodId);
            return currentUser.ExecuteScalar<decimal>("select PriceBuy from [Accounting].[IFnBuyPricesByGoodId](@id)", parameters, currentUser.CurrentConnection);
            }

        //topdan satiw qiymeti

        public static decimal? GoodPriceWholeById(this IContainer container, int goodId)
        {
            //var parameters = Helper.Init().Add("@id", goodId);
            //return container.CurrentUser.ExecuteScalar<decimal>("select [Accounting].[SFnGetGoodPriceWholeSale](@id)", parameters);
            return GoodPriceWholeById(container.CurrentUser,goodId);
        }

        public static decimal? GoodPriceWholeById(this User currentUser, int goodId)
        {
            var parameters = Helper.Init().Add("@id", goodId);
            return currentUser.ExecuteScalar<decimal>("select [Accounting].[SFnGetGoodPriceWholeSale](@id)", parameters);
        }
        //perakende satiw qimeti
        public static decimal? RetailPricesByGoodId(this IContainer container, int goodId)
        {
            return RetailPricesByGoodId(container.CurrentUser, goodId);
        }

        public static decimal? RetailPricesByGoodId(this User currentUser, int goodId)
        {
            var parameters = Helper.Init().Add("@id", goodId);
            return currentUser.ExecuteScalar<decimal>("select PriceRetail from [Accounting].[IFnPricesByGoodId](@id)", parameters, currentUser.CurrentConnection);
        }

    }
}

