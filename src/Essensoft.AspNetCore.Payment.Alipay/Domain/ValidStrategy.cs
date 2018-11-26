using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ValidStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class ValidStrategy : AlipayObject
    {
        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonProperty("gmt_invalid")]
        [XmlElement("gmt_invalid")]
        public string GmtInvalid { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonProperty("gmt_sign")]
        [XmlElement("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [JsonProperty("gmt_valid")]
        [XmlElement("gmt_valid")]
        public string GmtValid { get; set; }

        /// <summary>
        /// 失效方式：  01:到期失效  02:通知失效  03:截止日期失效
        /// </summary>
        [JsonProperty("invalid_type")]
        [XmlElement("invalid_type")]
        public string InvalidType { get; set; }

        /// <summary>
        /// 生效类型：  01:立即生效  02:通知生效  03:预约生效  04:倒签生效
        /// </summary>
        [JsonProperty("valid_type")]
        [XmlElement("valid_type")]
        public string ValidType { get; set; }
    }
}
