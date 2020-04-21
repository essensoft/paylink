using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataEquitySyncModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataEquitySyncModel : AlipayObject
    {
        /// <summary>
        /// biz_time
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// equity_code
        /// </summary>
        [JsonPropertyName("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// equity_from
        /// </summary>
        [JsonPropertyName("equity_from")]
        public string EquityFrom { get; set; }

        /// <summary>
        /// equity_id
        /// </summary>
        [JsonPropertyName("equity_id")]
        public string EquityId { get; set; }

        /// <summary>
        /// equity_info
        /// </summary>
        [JsonPropertyName("equity_info")]
        public EquityInfo EquityInfo { get; set; }

        /// <summary>
        /// original_biz_no
        /// </summary>
        [JsonPropertyName("original_biz_no")]
        public string OriginalBizNo { get; set; }

        /// <summary>
        /// original_biz_type
        /// </summary>
        [JsonPropertyName("original_biz_type")]
        public string OriginalBizType { get; set; }

        /// <summary>
        /// out_biz_no
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
