using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenIotMembershipcouponQueryResponse.
    /// </summary>
    public class AlipayOpenIotMembershipcouponQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动ID，用于获取相应的活动信息，来源于商家在B站的配置
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 配置商家发券时使用的商家信息，需要和进入商家中心（B站）时使用的相同
        /// </summary>
        [JsonPropertyName("auth_pid")]
        public string AuthPid { get; set; }
    }
}
