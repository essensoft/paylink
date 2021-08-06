using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceApplyCreateModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceApplyCreateModel : AlipayObject
    {
        /// <summary>
        /// 投保基本信息
        /// </summary>
        [JsonPropertyName("apply_basic_info")]
        public ApplyBasicInfo ApplyBasicInfo { get; set; }

        /// <summary>
        /// 统一客户平台的业务线编码
        /// </summary>
        [JsonPropertyName("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [JsonPropertyName("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 统一客户平台的会员类型
        /// </summary>
        [JsonPropertyName("platform_access_type")]
        public string PlatformAccessType { get; set; }

        /// <summary>
        /// 统一客户平台编码
        /// </summary>
        [JsonPropertyName("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 产品运营中心开通的产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 标的信息
        /// </summary>
        [JsonPropertyName("subject_information")]
        public string SubjectInformation { get; set; }

        /// <summary>
        /// 唯一交易流水号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
