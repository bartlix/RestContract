// <auto-generated />
[assembly: Codeworx.Rest.RestProxy(typeof(global::Codeworx.Rest.UnitTests.Api.Contract.IPathService), typeof(Codeworx.Rest.UnitTests.Generated.PathServiceClient))]
namespace Codeworx.Rest.UnitTests.Generated
{
    public class PathServiceClient : Codeworx.Rest.Client.RestClient<global::Codeworx.Rest.UnitTests.Api.Contract.IPathService>, global::Codeworx.Rest.UnitTests.Api.Contract.IPathService
    {
        public PathServiceClient(Codeworx.Rest.Client.RestOptions<global::Codeworx.Rest.UnitTests.Api.Contract.IPathService> options): base(options)
        {
        }

        public global::System.Threading.Tasks.Task<bool> ComplexPathWithAllParameters(global::Codeworx.Rest.UnitTests.Model.Item itemBody, string textQuery, int numberQuery, global::System.Guid idQuery, global::System.DateTime dateQuery, string textUrl, int numberUrl, global::System.Guid idUrl, global::System.DateTime dateUrl)
        {
            return CallAsync(c => c.ComplexPathWithAllParameters(itemBody, textQuery, numberQuery, idQuery, dateQuery, textUrl, numberUrl, idUrl, dateUrl));
        }

        public global::System.Threading.Tasks.Task<bool> ComplexPathWithBodyParameter(global::Codeworx.Rest.UnitTests.Model.Item item)
        {
            return CallAsync(c => c.ComplexPathWithBodyParameter(item));
        }

        public global::System.Threading.Tasks.Task<bool> ComplexPathWithoutParameters()
        {
            return CallAsync(c => c.ComplexPathWithoutParameters());
        }

        public global::System.Threading.Tasks.Task<bool> ComplexPathWithQueryParameters(string text, int number, global::System.Guid id, global::System.DateTime date)
        {
            return CallAsync(c => c.ComplexPathWithQueryParameters(text, number, id, date));
        }

        public global::System.Threading.Tasks.Task<bool> ComplexPathWithUrlParameters(string text, int number, global::System.Guid id, global::System.DateTime date)
        {
            return CallAsync(c => c.ComplexPathWithUrlParameters(text, number, id, date));
        }

        public global::System.Threading.Tasks.Task<bool> EmptyPathWithAllParameters(global::Codeworx.Rest.UnitTests.Model.Item itemBody, string textQuery, int numberQuery, global::System.Guid idQuery, global::System.DateTime dateQuery, string textUrl, int numberUrl, global::System.Guid idUrl, global::System.DateTime dateUrl)
        {
            return CallAsync(c => c.EmptyPathWithAllParameters(itemBody, textQuery, numberQuery, idQuery, dateQuery, textUrl, numberUrl, idUrl, dateUrl));
        }

        public global::System.Threading.Tasks.Task<bool> EmptyPathWithBodyParameter(global::Codeworx.Rest.UnitTests.Model.Item item)
        {
            return CallAsync(c => c.EmptyPathWithBodyParameter(item));
        }

        public global::System.Threading.Tasks.Task<bool> EmptyPathWithoutParameters()
        {
            return CallAsync(c => c.EmptyPathWithoutParameters());
        }

        public global::System.Threading.Tasks.Task<bool> EmptyPathWithQueryParameters(string text, int number, global::System.Guid id, global::System.DateTime date)
        {
            return CallAsync(c => c.EmptyPathWithQueryParameters(text, number, id, date));
        }

        public global::System.Threading.Tasks.Task<bool> EmptyPathWithUrlParameters(string text, int number, global::System.Guid id, global::System.DateTime date)
        {
            return CallAsync(c => c.EmptyPathWithUrlParameters(text, number, id, date));
        }

        public global::System.Threading.Tasks.Task<bool> SimplePathWithAllParameters(global::Codeworx.Rest.UnitTests.Model.Item itemBody, string textQuery, int numberQuery, global::System.Guid idQuery, global::System.DateTime dateQuery, string textUrl, int numberUrl, global::System.Guid idUrl, global::System.DateTime dateUrl)
        {
            return CallAsync(c => c.SimplePathWithAllParameters(itemBody, textQuery, numberQuery, idQuery, dateQuery, textUrl, numberUrl, idUrl, dateUrl));
        }

        public global::System.Threading.Tasks.Task<bool> SimplePathWithBodyParameter(global::Codeworx.Rest.UnitTests.Model.Item item)
        {
            return CallAsync(c => c.SimplePathWithBodyParameter(item));
        }

        public global::System.Threading.Tasks.Task<bool> SimplePathWithoutParameters()
        {
            return CallAsync(c => c.SimplePathWithoutParameters());
        }

        public global::System.Threading.Tasks.Task<bool> SimplePathWithQueryParameters(string text, int number, global::System.Guid id, global::System.DateTime date)
        {
            return CallAsync(c => c.SimplePathWithQueryParameters(text, number, id, date));
        }

        public global::System.Threading.Tasks.Task<bool> SimplePathWithUrlParameters(string text, int number, global::System.Guid id, global::System.DateTime date)
        {
            return CallAsync(c => c.SimplePathWithUrlParameters(text, number, id, date));
        }
    }
}