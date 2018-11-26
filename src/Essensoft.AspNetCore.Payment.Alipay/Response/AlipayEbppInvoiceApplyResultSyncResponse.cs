using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplyResultSyncResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplyResultSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 标注是否需要调用方重试，在请求失败的情况下返回，如果该字段返回true表明该失败的情况通过重试补偿可解决，为false表明失败情况通过重试无法解决
        /// </summary>
        [JsonProperty("retry_flag")]
        [XmlElement("retry_flag")]
        public bool RetryFlag { get; set; }
    }
}
