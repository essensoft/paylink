using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnContractGetResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnContractGetResponse : AlipayResponse
    {
        /// <summary>
        /// 合同的内容文本 string 合同的内容文本，为HTML格式
        /// </summary>
        [JsonProperty("contract_content")]
        [XmlElement("contract_content")]
        public string ContractContent { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [JsonProperty("contract_no")]
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 唯一标识这次请求
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
