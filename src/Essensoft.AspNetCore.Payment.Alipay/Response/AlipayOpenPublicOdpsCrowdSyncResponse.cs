using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicOdpsCrowdSyncResponse.
    /// </summary>
    public class AlipayOpenPublicOdpsCrowdSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步单号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 生活号对应的人群id，不一定返回，成功同步情况下会返回
        /// </summary>
        [JsonPropertyName("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 没有dmp平台人群id
        /// </summary>
        [JsonPropertyName("dmp_id")]
        public string DmpId { get; set; }
    }
}
