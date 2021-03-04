using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCreateResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
