using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions.ConditionOperators
{
    public static partial class CrmQueryExtensions
    {
        /// <summary>
        /// Adds query expressions with ConditionOperator.GreaterEqual
        /// </summary>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereGreaterEqual(this QueryExpression query, string attribute, params object[] value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.GreaterEqual, value);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.GreaterEqual
        /// </summary>
        /// <typeparam name="TIn">Type of attribute comparison value</typeparam>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereGreaterEqual<TIn>(this QueryExpression query, string attribute, TIn value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.GreaterEqual, value);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.GreaterThan
        /// </summary>
        /// <typeparam name="TIn">Type of attribute comparison value</typeparam>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereGreaterThan<TIn>(this QueryExpression query, string attribute, TIn value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.GreaterThan, value);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.GreaterThan
        /// </summary>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereGreaterThan(this QueryExpression query, string attribute, params object[] value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.GreaterThan, value);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.LessEqual
        /// </summary>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereLessEqual(this QueryExpression query, string attribute, params object[] value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.LessEqual, value);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.LessEqual
        /// </summary>
        /// <typeparam name="TIn">Type of attribute comparison value</typeparam>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereLessEqual<TIn>(this QueryExpression query, string attribute, TIn value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.LessEqual, value);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.LessThan
        /// </summary>
        /// <typeparam name="TIn">Type of attribute comparison value</typeparam>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereLessThan<TIn>(this QueryExpression query, string attribute, TIn value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.GreaterThan, value);

            return query;
        }

        /// <summary>
        /// Adds query expressions with ConditionOperator.LessThan
        /// </summary>
        /// <param name="query">Extended query</param>
        /// <param name="attribute">Attribute name of compared entity</param>
        /// <param name="value">Comparison value</param>
        /// <returns></returns>
        public static QueryExpression WhereLessThan(this QueryExpression query, string attribute, params object[] value)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.LessThan, value);

            return query;
        }
    }
}
