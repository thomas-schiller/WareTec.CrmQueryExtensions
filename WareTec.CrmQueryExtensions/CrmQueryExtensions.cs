using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions
{
    public static partial class CrmQueryExtensions
    {

        public static QueryExpression Select(this QueryExpression query, params string[] attributes)
        {
            query.ColumnSet = new ColumnSet(attributes);
            return query;
        }

        public static QueryExpression SelectAll(this QueryExpression query)
        {
            query.ColumnSet = new ColumnSet(true);
            return query;
        }

        public static QueryExpression And(this QueryExpression query)
        {
            query.Criteria.FilterOperator = LogicalOperator.And;
            return query;
        }

        public static QueryExpression Or(this QueryExpression query)
        {
            query.Criteria.FilterOperator = LogicalOperator.Or;
            return query;
        }

        public static List<Entity> ToList(this QueryExpression query, IOrganizationService service)
        {
            var result = service.RetrieveMultiple(query);
            return result.Entities.ToList();
        }

        public static List<T> ToList<T>(this QueryExpression query, IOrganizationService service) where T : Entity
        {
            var result = service.RetrieveMultiple(query);
            return result.Entities.ToList().Select(x => x.ToEntity<T>()).ToList();
        }

        public static Entity ById(this QueryExpression query, Guid id, IOrganizationService service)
        {
            return service.Retrieve(query.EntityName, id, query.ColumnSet);
        }

        public static T ById<T>(this QueryExpression query, Guid id, IOrganizationService service) where T : Entity
        {
            return service.Retrieve(query.EntityName, id, query.ColumnSet).ToEntity<T>();
        }

        public static string ToFetchXml(this QueryExpression query, IOrganizationService service)
        {
            var queryExpToFetchRequest = new QueryExpressionToFetchXmlRequest
            {
                Query = query
            };
            var conversionResponse = (QueryExpressionToFetchXmlResponse)service.Execute(queryExpToFetchRequest);
            return conversionResponse.FetchXml;
        }
    }
}
