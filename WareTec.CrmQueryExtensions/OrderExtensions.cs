using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions
{
    public static class OrderExtensions
    {
        /// <summary>
        /// Adds ordering to query expression.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="attribute">Attribute name which is used for ordering.</param>
        /// <param name="orderType">Ascending or descending ordering.</param>
        /// <returns></returns>
        public static QueryExpression OrderBy(this QueryExpression query, string attribute, OrderType orderType = OrderType.Ascending)
        {
            query.AddOrder(attribute, orderType);

            return query;
        }

    }
}
