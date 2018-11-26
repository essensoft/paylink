using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FeeRecords Data Structure.
    /// </summary>
    [Serializable]
    public class FeeRecords : AlipayObject
    {
        /// <summary>
        /// 费用余额，单位为元，小数点保留2位
        /// </summary>
        [JsonProperty("balance")]
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonProperty("date")]
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 费用交易流水备注
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 费用交易额度
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
