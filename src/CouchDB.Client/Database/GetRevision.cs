﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CouchDB.Client.FluentMango;
using RestSharp;

namespace CouchDB.Client
{
    public partial class CouchDatabase
    {
        /// <summary>
        /// http://docs.couchdb.org/en/2.0.0/api/document/common.html#obtaining-a-specific-revision
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CouchResponse> GetRevisionAsync(string id, string rev)
        {
            var request = new RestSharp.RestRequest(Helper.EncodeID(id), RestSharp.Method.GET);
            request.AddQueryParameter("rev", rev);
            return await client.http.ExecuteAsync(request);
        }
    }
}