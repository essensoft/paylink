using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommunityRelationshipCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityRelationshipCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 物业和小区的绑定实体ID
        /// </summary>
        [JsonPropertyName("relationship_id")]
        public string RelationshipId { get; set; }
    }
}
