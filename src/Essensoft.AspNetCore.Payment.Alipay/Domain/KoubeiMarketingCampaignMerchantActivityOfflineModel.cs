using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityOfflineModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignMerchantActivityOfflineModel : AlipayObject
    {
        /// <summary>
        /// 活动ActivityId
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 下架备注memo
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 指定operator字段操作人类型，目前支持枚举：外部商户：MER、商户操作员：MER_OPERATOR、外部服务商：PROVIDER、外部服务商员工：PROVIDER_STAFF
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
