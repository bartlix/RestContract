﻿using System.Threading.Tasks;
using Codeworx.Rest.UnitTests.Api.Contract.Model;

namespace Codeworx.Rest.UnitTests.Api.Contract
{
    [RestRoute("api/StatusCode")]
    public interface IStatusCodeController
    {
        [RestGet("Success")]
        Task<bool> GetValueSuccess();

        [RestGet("Exception")]
        Task<bool> GetValueException();


        [RestGet("Delete")]
        [ResponseType((int)System.Net.HttpStatusCode.OK)]
        [ResponseType((int)System.Net.HttpStatusCode.Gone, typeof(EntryNotFoundError))]
        [ResponseType((int)System.Net.HttpStatusCode.Conflict, typeof(StillInUseError))]
        Task DeleteEntry(string id);

        [RestGet("Data")]
        [ResponseType((int)System.Net.HttpStatusCode.OK, typeof(SampleDataItem))]
        [ResponseType((int)System.Net.HttpStatusCode.Gone, typeof(EntryNotFoundError))]
        [ResponseType((int)System.Net.HttpStatusCode.Conflict, typeof(StillInUseError))]
        Task<SampleDataItem> GetDataItemAsync(string id);
    }
}
