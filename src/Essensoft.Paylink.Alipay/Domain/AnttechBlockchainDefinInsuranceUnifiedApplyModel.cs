using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceUnifiedApplyModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceUnifiedApplyModel : AlipayObject
    {
        /// <summary>
        /// 附加条款信息
        /// </summary>
        [JsonPropertyName("additional_item")]
        public string AdditionalItem { get; set; }

        /// <summary>
        /// 投保人证件号码
        /// </summary>
        [JsonPropertyName("apply_card_code")]
        public string ApplyCardCode { get; set; }

        /// <summary>
        /// 投保人证件类型 01-居民身份证 03-营业执照
        /// </summary>
        [JsonPropertyName("apply_card_type")]
        public string ApplyCardType { get; set; }

        /// <summary>
        /// 投保人（企业或者自然人）名称
        /// </summary>
        [JsonPropertyName("apply_name")]
        public string ApplyName { get; set; }

        /// <summary>
        /// 中台客户服务中的业务线编码
        /// </summary>
        [JsonPropertyName("defin_business_code")]
        public string DefinBusinessCode { get; set; }

        /// <summary>
        /// 平台在客户服务中心的会员类型
        /// </summary>
        [JsonPropertyName("defin_platform_access_type")]
        public string DefinPlatformAccessType { get; set; }

        /// <summary>
        /// 保险止期
        /// </summary>
        [JsonPropertyName("insure_end_date")]
        public string InsureEndDate { get; set; }

        /// <summary>
        /// 保险起期
        /// </summary>
        [JsonPropertyName("insure_start_date")]
        public string InsureStartDate { get; set; }

        /// <summary>
        /// 被保人证件号码
        /// </summary>
        [JsonPropertyName("insured_card_code")]
        public string InsuredCardCode { get; set; }

        /// <summary>
        /// 被保人证件类型： 01-居民身份证 03-营业执照
        /// </summary>
        [JsonPropertyName("insured_card_type")]
        public string InsuredCardType { get; set; }

        /// <summary>
        /// 被保人姓名
        /// </summary>
        [JsonPropertyName("insured_name")]
        public string InsuredName { get; set; }

        /// <summary>
        /// 主险条款代码
        /// </summary>
        [JsonPropertyName("main_item_code")]
        public string MainItemCode { get; set; }

        /// <summary>
        /// 主险条款内容
        /// </summary>
        [JsonPropertyName("main_item_content")]
        public string MainItemContent { get; set; }

        /// <summary>
        /// 客户平台编码
        /// </summary>
        [JsonPropertyName("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 保费，单位为：元（保留两位小数）
        /// </summary>
        [JsonPropertyName("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 产品运营中心开通的产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 费率，最多兼容9位小数
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 业务线内全局唯一请求号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 特别约定
        /// </summary>
        [JsonPropertyName("special")]
        public string Special { get; set; }

        /// <summary>
        /// 标的信息
        /// </summary>
        [JsonPropertyName("subject_information")]
        public string SubjectInformation { get; set; }
    }
}
