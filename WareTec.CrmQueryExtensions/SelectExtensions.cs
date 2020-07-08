using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions
{
    public static class CrmQueryExtensions
    {
        /// <summary>
        /// Sets the column that should be fetched.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="attributes">Comma separated list of attributes.</param>
        /// <returns></returns>
        public static QueryExpression Select(this QueryExpression query, params string[] attributes)
        {

            query.ColumnSet = new ColumnSet(attributes);
            return query;
        }

        /// <summary>
        /// Fetches ALL columns! Just do it if you know what mass of data you are fetching for.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static QueryExpression SelectAll(this QueryExpression query)
        {
            query.ColumnSet = new ColumnSet(true);
            return query;
        }
    }
}
