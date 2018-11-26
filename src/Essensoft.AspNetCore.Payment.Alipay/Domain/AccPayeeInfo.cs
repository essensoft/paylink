using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccPayeeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AccPayeeInfo : AlipayObject
    {
        /// <summary>
        /// 收款方电子钱包账号。
        /// </summary>
        [JsonProperty("payee_account")]
        [XmlElement("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款方电子钱包持有者姓名。
        /// </summary>
        [JsonProperty("payee_name")]
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }
    }
}
