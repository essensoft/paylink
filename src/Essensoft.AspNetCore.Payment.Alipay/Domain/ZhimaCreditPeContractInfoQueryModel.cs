using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeContractInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动名称，由芝麻分配
        /// </summary>
        [JsonProperty("activity_name")]
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [JsonProperty("category")]
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 电子合约号
        /// </summary>
        [JsonProperty("contract_no")]
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 支付宝ID
        /// </summary>
        [JsonProperty("uid")]
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
