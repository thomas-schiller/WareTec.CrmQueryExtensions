using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions
{
    public static partial class WhereExtensions
    {
       
        public static QueryExpression WhereAbove(this QueryExpression query, string attribute, params object[] values)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.Above, values);

            return query;
        }

        public static QueryExpression WhereAboveAboveOrEqual(this QueryExpression query, string attribute, params object[] values)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.AboveOrEqual, values);

            return query;
        }

        public static QueryExpression WhereDoesNotContain(this QueryExpression query, string attribute, params object[] values)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.DoesNotContain, values);

            return query;
        }

        public static QueryExpression WhereContainValues(this QueryExpression query, string attribute, params object[] values)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, ConditionOperator.ContainValues, values);

            return query;
        }

        public static QueryExpression Where(this QueryExpression query, string attribute, ConditionOperator conditionOperator,
            params object[] values)
        {
            if (query.Criteria == null)
            {
                query.Criteria = new FilterExpression();
            }

            query.Criteria.AddCondition(attribute, conditionOperator, values);

            return query;
        }
    }
}
