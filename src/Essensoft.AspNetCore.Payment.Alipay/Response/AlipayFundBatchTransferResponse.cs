using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundBatchTransferResponse.
    /// </summary>
    public class AlipayFundBatchTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 商户请求的批次流水号，同请求中的"batch_no"。
        /// </summary>
        [JsonProperty("batch_no")]
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 支付宝系统内部批次请求id。
        /// </summary>
        [JsonProperty("batch_trans_id")]
        [XmlElement("batch_trans_id")]
        public string BatchTransId { get; set; }
    }
}
