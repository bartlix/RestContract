using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Codeworx.Rest.UnitTests.Model;
using Codeworx.Rest.UnitTests.Api.Contract;
using Codeworx.Rest.Client;

namespace Codeworx.Rest.UnitTests.Generated
{
    public class SerializeResultControllerClient : RestClient<ISerializeResultController>, ISerializeResultController
    {
        public SerializeResultControllerClient(RestOptions<ISerializeResultController> options): base(options)
        {
        }

        public SerializeResultControllerClient(RestOptions options): base(options)
        {
        }

        public Task NoResult()
        {
            return CallAsync(c => c.NoResult());
        }

        public Task<string> StringResult()
        {
            return CallAsync(c => c.StringResult());
        }

        public Task<DateTime> DateTimeResult()
        {
            return CallAsync(c => c.DateTimeResult());
        }

        public Task<DateTime?> NullableDateTimeResult()
        {
            return CallAsync(c => c.NullableDateTimeResult());
        }

        public Task<Guid> GuidResult()
        {
            return CallAsync(c => c.GuidResult());
        }

        public Task<Guid?> NullableGuidResult()
        {
            return CallAsync(c => c.NullableGuidResult());
        }

        public Task<int> IntResult()
        {
            return CallAsync(c => c.IntResult());
        }

        public Task<int?> NullableIntResult()
        {
            return CallAsync(c => c.NullableIntResult());
        }

        public Task<double> DoubleResult()
        {
            return CallAsync(c => c.DoubleResult());
        }

        public Task<double?> NullableDoubleResult()
        {
            return CallAsync(c => c.NullableDoubleResult());
        }

        public Task<decimal> DecimalResult()
        {
            return CallAsync(c => c.DecimalResult());
        }

        public Task<decimal?> NullableDecimalResult()
        {
            return CallAsync(c => c.NullableDecimalResult());
        }

        public Task<float> FloatResult()
        {
            return CallAsync(c => c.FloatResult());
        }

        public Task<float?> NullableFloatResult()
        {
            return CallAsync(c => c.NullableFloatResult());
        }

        public Task<Item> ItemResult()
        {
            return CallAsync(c => c.ItemResult());
        }

        public Task<Item> ItemNullResult()
        {
            return CallAsync(c => c.ItemNullResult());
        }

        public Task<List<string>> StringListResult()
        {
            return CallAsync(c => c.StringListResult());
        }

        public Task<List<DateTime>> DateTimeListResult()
        {
            return CallAsync(c => c.DateTimeListResult());
        }

        public Task<List<Guid>> GuidListResult()
        {
            return CallAsync(c => c.GuidListResult());
        }

        public Task<List<Item>> ItemListResult()
        {
            return CallAsync(c => c.ItemListResult());
        }
    }
}