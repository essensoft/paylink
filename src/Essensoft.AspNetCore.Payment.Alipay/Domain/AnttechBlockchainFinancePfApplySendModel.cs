using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinancePfApplySendModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinancePfApplySendModel : AlipayObject
    {
        /// <summary>
        /// 融资支用申请业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 资金渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支用申请标识
        /// </summary>
        [JsonPropertyName("financing_id")]
        public string FinancingId { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [JsonPropertyName("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [JsonPropertyName("platform_id")]
        public string PlatformId { get; set; }
    }
}
