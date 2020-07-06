using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
