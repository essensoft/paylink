using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCertCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCertCreateModel : AlipayObject
    {
        /// <summary>
        /// 凭证批次名称
        /// </summary>
        [JsonProperty("cert_name")]
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [JsonProperty("extend_info")]
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 凭证有效次数，数值(最大为10000)
        /// </summary>
        [JsonProperty("valid_count")]
        [XmlElement("valid_count")]
        public string ValidCount { get; set; }
    }
}
