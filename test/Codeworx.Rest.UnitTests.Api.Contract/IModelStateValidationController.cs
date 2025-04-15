using System;
using System.Threading.Tasks;
using Codeworx.Rest.UnitTests.Model;

namespace Codeworx.Rest.UnitTests.Api.Contract
{
    [RestRoute("api/model-state-validation")]
    public interface IModelStateValidationController
    {
        [RestPost("guid-query")]
        Task GuidQueryParameterAsync([QueryMember] Guid id);

        [RestPost("nullable-guid-query")]
        Task NullableGuidQueryParameterAsync([QueryMember] Guid? id);

        [RestPost("none-null-body")]
        Task ItemBodyNotNullAsync([BodyMember] Item item);

        [RestPost("nullable-body")]
        Task ItemBodyNullableAsync([BodyMember] Item? item);

        [RestPost("nullable-body-by-attribute")]
        Task ItemBodyNullableAttributeAsync([BodyMember(AllowNull = true)] Item item);
    }
}
