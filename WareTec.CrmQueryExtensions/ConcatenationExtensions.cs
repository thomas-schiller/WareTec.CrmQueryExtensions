using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions
{
    public static class ConcatExtensions
    {
        /// <summary>
        /// Adds AND concatenated sub-query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="subQuery">subQuery of type FilterExpressions</param>
        /// <returns></returns>
        public static QueryExpression And(this QueryExpression query, FilterExpression subQuery)
        {
            query.Criteria.FilterOperator = LogicalOperator.And;
            query.Criteria.AddFilter(subQuery);
            return query;
        }

        /// <summary>
        /// Adds AND concatenated sub-query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="subQuery">subQuery of type ConditionExpression</param>
        /// <returns></returns>
        public static QueryExpression And(this QueryExpression query, ConditionExpression subQuery)
        {
            query.Criteria.FilterOperator = LogicalOperator.And;
            query.Criteria.AddCondition(subQuery);
            return query;
        }

        /// <summary>
        /// Adds AND concatenated sub-query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="attributeName">Attribute name of compared field</param>
        /// <param name="conditionOperator">Condition operator</param>
        /// <param name="compareValue">Value that is compared with CRM value.</param>
        /// <returns></returns>
        public static QueryExpression And(this QueryExpression query, string attributeName, ConditionOperator conditionOperator, object compareValue)
        {
            query.Criteria.FilterOperator = LogicalOperator.And;
            query.Criteria.AddCondition(attributeName, conditionOperator, compareValue);
            return query;
        }

        /// <summary>
        /// Adds OR concatenated sub-query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="subQuery">subQuery of type FilterExpression</param>
        /// <returns></returns>
        public static QueryExpression Or(this QueryExpression query, FilterExpression subQuery)
        {
            query.Criteria.FilterOperator = LogicalOperator.Or;
            query.Criteria.AddFilter(subQuery);
            return query;
        }

        /// <summary>
        /// Adds OR concatenated sub-query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="subQuery">subQuery of type ConditionExpression</param>
        /// <returns></returns>
        public static QueryExpression Or(this QueryExpression query, ConditionExpression subQuery)
        {
            query.Criteria.FilterOperator = LogicalOperator.Or;
            query.Criteria.AddCondition(subQuery);
            return query;
        }

        /// <summary>
        /// Adds OR concatenated sub-query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="attributeName">Attribute name of compared field</param>
        /// <param name="conditionOperator">Condition operator</param>
        /// <param name="compareValue">Value that is compared with CRM value.</param>
        /// <returns></returns>
        public static QueryExpression Or(this QueryExpression query, string attributeName, ConditionOperator conditionOperator, object compareValue)
        {
            query.Criteria.FilterOperator = LogicalOperator.Or;
            query.Criteria.AddCondition(attributeName, conditionOperator, compareValue);
            return query;
        }
    }
}
