using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskIpprofileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskIpprofileQueryModel : AlipayObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 交易发生的城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 交易发生的区
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// 调用服务的商户id ，如果是第三方服务商，需要将其实际的商户id透传过来，如果是普通商户传入自己的appid即可
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
