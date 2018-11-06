using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContractBasicInfo : AlipayObject
    {
        /// <summary>
        /// 合约简要描述
        /// </summary>
        [JsonProperty("brief_desc")]
        [XmlElement("brief_desc")]
        public string BriefDesc { get; set; }

        /// <summary>
        /// 合约中文名
        /// </summary>
        [JsonProperty("contract_name")]
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonProperty("contract_no")]
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合约过期时间
        /// </summary>
        [JsonProperty("expire_time")]
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 最后守约时间
        /// </summary>
        [JsonProperty("last_promise_date")]
        [XmlElement("last_promise_date")]
        public string LastPromiseDate { get; set; }

        /// <summary>
        /// 用户在输入场景下签约合同的序号
        /// </summary>
        [JsonProperty("order")]
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 合约签署时间
        /// </summary>
        [JsonProperty("sign_time")]
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 合同签约应用app标识
        /// </summary>
        [JsonProperty("source")]
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 合同状态，可选值：success, fail
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
