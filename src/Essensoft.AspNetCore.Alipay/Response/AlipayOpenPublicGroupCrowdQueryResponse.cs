using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCrowdQueryResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCrowdQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分组圈出的人群数量
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; set; }
    }
}
