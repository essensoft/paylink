using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCrowdQueryResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCrowdQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分组圈出的人群数量
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }
    }
}
