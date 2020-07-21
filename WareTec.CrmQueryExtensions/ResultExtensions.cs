using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace WareTec.CrmQueryExtensions
{
    public static class ResultExtensions
    {
        /// <summary>
        /// Executes query expression and returns flattened paged entity list.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="service">CRM organization service</param>
        /// <param name="pageCount">Number of page-size. Default: 1000</param>
        /// <returns>Flattened paged entity list.</returns>
        public static List<Entity> ToList(this QueryExpression query, IOrganizationService service, int pageCount = 1000)
        {
            query.PageInfo = new PagingInfo
            {
                Count = pageCount,
                PageNumber = 1,
                PagingCookie = null
            };

            bool moreResults;

            var resultList = new List<Entity>();

            do
            {
                var result = service.RetrieveMultiple(query);

                if (result.Entities != null && result.Entities.Any())
                {
                    resultList.AddRange(result.Entities);
                }

                moreResults = result.MoreRecords;

                if (moreResults)
                {
                    query.PageInfo.PageNumber++;
                    query.PageInfo.PagingCookie = result.PagingCookie;
                }

            } while (moreResults);

            return resultList;
        }

        /// <summary>
        /// Executes query expression and returns flattened paged typed entity list.
        /// </summary>
        /// <typeparam name="T">Type of entity e.g. account</typeparam>
        /// <param name="query"></param>
        /// <param name="service">CRM organization service</param>
        /// <param name="pageCount">Number of page-size. Default: 1000</param>
        /// <returns>Flattened paged entity list.</returns>
        public static List<T> ToList<T>(this QueryExpression query, IOrganizationService service, int pageCount = 1000) where T : Entity
        {
            query.PageInfo = new PagingInfo
            {
                Count = pageCount,
                PageNumber = 1,
                PagingCookie = null
            };

            bool moreResults;

            var resultList = new List<T>();

            do
            {
                var result = service.RetrieveMultiple(query);

                if (result.Entities != null && result.Entities.Any())
                {
                    resultList.AddRange(result.Entities.Select(resultEntity => resultEntity.ToEntity<T>()));
                }

                moreResults = result.MoreRecords;

                if (moreResults)
                {
                    query.PageInfo.PageNumber++;
                    query.PageInfo.PagingCookie = result.PagingCookie;
                }

            } while (moreResults);

            return resultList;
        }

        /// <summary>
        /// Returns single entity by Id.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="id">Id of queried entity</param>
        /// <param name="service">CRM organization service</param>
        /// <returns></returns>
        public static Entity ById(this QueryExpression query, Guid id, IOrganizationService service)
        {
            return service.Retrieve(query.EntityName, id, query.ColumnSet);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Concrete entity type. E.g. account</typeparam>
        /// <param name="query"></param>
        /// <param name="id">Id of queried entity</param>
        /// <param name="service">CRM organization service</param>
        /// <returns></returns>
        public static T ById<T>(this QueryExpression query, Guid id, IOrganizationService service) where T : Entity
        {
            return service.Retrieve(query.EntityName, id, query.ColumnSet).ToEntity<T>();
        }

        /// <summary>
        /// Returns the first entity that is found. If no entity is found, null will be returned.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="service">CRM organization service</param>
        /// <returns></returns>
        public static Entity FirstOrDefault(this QueryExpression query, IOrganizationService service)
        {
            var entityCollection = service.RetrieveMultiple(query);
            return entityCollection.Entities.Count > 0 ? entityCollection.Entities[0] : null;
        }

        /// <summary>
        ///  Returns the first entity that is found. If no entity is found, null will be returned.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="service">CRM organization service</param>
        /// <typeparam name="T">Type of derived proxy class.</typeparam>
        /// <returns></returns>
        public static T FirstOrDefault<T>(this QueryExpression query, IOrganizationService service) where T : Entity
        {
            var entityCollection = service.RetrieveMultiple(query);
            return entityCollection.Entities.Count > 0 ? entityCollection.Entities[0].ToEntity<T>() : null;
        }

        /// <summary>
        /// Returns the first entity that is found. If no entity is found, an exception will be thrown.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="service">CRM organization service</param>
        /// <returns></returns>
        public static Entity First(this QueryExpression query, IOrganizationService service)
        {
            var entityCollection = service.RetrieveMultiple(query);
            return entityCollection.Entities.Count > 0 ? entityCollection.Entities[0] : throw new Exception("No entity with the given criteria was found!");
        }

        /// <summary>
        /// Returns the first entity that is found. If no entity is found, an exception will be thrown.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="service">CRM organization service</param>
        /// <typeparam name="T">Type of derived proxy class.</typeparam>
        /// <returns></returns>
        public static T First<T>(this QueryExpression query, IOrganizationService service) where T : Entity
        {
            var entityCollection = service.RetrieveMultiple(query);
            return entityCollection.Entities.Count > 0 ? entityCollection.Entities[0].ToEntity<T>() : throw new Exception("No entity with the given criteria was found!");
        }


    }
}
