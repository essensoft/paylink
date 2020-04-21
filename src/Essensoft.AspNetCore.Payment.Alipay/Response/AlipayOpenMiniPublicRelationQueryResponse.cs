using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniPublicRelationQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPublicRelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 生活号ID
        /// </summary>
        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 生活号名称
        /// </summary>
        [JsonPropertyName("public_name")]
        public string PublicName { get; set; }
    }
}
