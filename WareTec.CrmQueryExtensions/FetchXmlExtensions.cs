using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions
{
    public static class FetchXmlExtensions
    {
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
