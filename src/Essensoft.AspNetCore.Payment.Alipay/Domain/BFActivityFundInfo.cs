using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BFActivityFundInfo Data Structure.
    /// </summary>
    public class BFActivityFundInfo : AlipayObject
    {
        /// <summary>
        /// 计收费主体是否激活
        /// </summary>
        [JsonPropertyName("activity")]
        public bool Activity { get; set; }

        /// <summary>
        /// 老场景 活动模板ID
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 签署的贴息协议ID
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 收费产品码
        /// </summary>
        [JsonPropertyName("charge_code")]
        public string ChargeCode { get; set; }

        /// <summary>
        /// 老场景 活动ID
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 计收费减收配置ID
        /// </summary>
        [JsonPropertyName("platform_subsidy_id")]
        public string PlatformSubsidyId { get; set; }

        /// <summary>
        /// bigdecimal subsidyMode=rate 表示折扣值 eg: 0.5 表示承担50%
        /// </summary>
        [JsonPropertyName("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 商家可见费率
        /// </summary>
        [JsonPropertyName("seller_rate")]
        public string SellerRate { get; set; }

        /// <summary>
        /// rate:折扣,fixed:定额扣减
        /// </summary>
        [JsonPropertyName("subsidy_mode")]
        public string SubsidyMode { get; set; }

        /// <summary>
        /// 贴息商户ID
        /// </summary>
        [JsonPropertyName("subsidy_user")]
        public string SubsidyUser { get; set; }

        /// <summary>
        /// 期数信息
        /// </summary>
        [JsonPropertyName("term")]
        public string Term { get; set; }

        /// <summary>
        /// 计收费主体类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
