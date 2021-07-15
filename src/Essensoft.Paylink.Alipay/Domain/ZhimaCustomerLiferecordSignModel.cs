using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerLiferecordSignModel Data Structure.
    /// </summary>
    public class ZhimaCustomerLiferecordSignModel : AlipayObject
    {
        /// <summary>
        /// 是否授权
        /// </summary>
        [JsonPropertyName("auth")]
        public bool Auth { get; set; }

        /// <summary>
        /// 业务时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 芝麻内部配置的商户白名单,只有配置过的白名单才允许接入
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
