using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCreditAutofinanceVidGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCreditAutofinanceVidGetModel : AlipayObject
    {
        /// <summary>
        /// 机构编号
        /// </summary>
        [JsonProperty("orgcode")]
        [XmlElement("orgcode")]
        public string Orgcode { get; set; }

        /// <summary>
        /// 支付宝账号数字ID
        /// </summary>
        [JsonProperty("uid")]
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 当前安装的支付宝钱包版本号
        /// </summary>
        [JsonProperty("version")]
        [XmlElement("version")]
        public string Version { get; set; }
    }
}
