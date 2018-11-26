using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantBaseEnterOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantBaseEnterOpenModel : AlipayObject
    {
        /// <summary>
        /// 商户logo文件流信息，该字段为文件流经base64编码后得到的字符串。
        /// </summary>
        [JsonProperty("logo_info")]
        [XmlElement("logo_info")]
        public string LogoInfo { get; set; }

        /// <summary>
        /// 商户品牌全称。
        /// </summary>
        [JsonProperty("m_name")]
        [XmlElement("m_name")]
        public string MName { get; set; }

        /// <summary>
        /// 商户品牌简称，只能由大写字母、下划线、数字组成，且必须以大写字母开头。
        /// </summary>
        [JsonProperty("m_short_name")]
        [XmlElement("m_short_name")]
        public string MShortName { get; set; }
    }
}
