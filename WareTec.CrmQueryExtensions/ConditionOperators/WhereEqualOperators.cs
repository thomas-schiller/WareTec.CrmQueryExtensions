using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions
{
    public static partial class CrmQueryExtensions
    {
        /// <summary>
        /// Adds query expressions with ConditionOperator.Equal
        /// </summary>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="values">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereEqual(this QueryExpression query, string attribute, params object[] values)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.Equal, values);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.Equal
        /// </summary>
        /// <typeparam name="TIn">Type of attribute comparison value</typeparam>
        /// <param name="query"></param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereEqual<TIn>(this QueryExpression query, string attribute, TIn value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.Equal, value);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.NotEqual
        /// </summary>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="values">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereNotEqual(this QueryExpression query, string attribute, params object[] values)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.Equal, values);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.NotEqual
        /// </summary>
        /// <typeparam name="TIn">Type of attribute comparison value</typeparam>
        /// <param name="query"></param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereNotEqual<TIn>(this QueryExpression query, string attribute, TIn value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.Equal, value);

            return query;
        }
    }
}
