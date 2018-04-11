using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayZdatafrontDatatransferedSendResponse.
    /// </summary>
    public class AlipayZdatafrontDatatransferedSendResponse : AlipayResponse
    {
        /// <summary>
        /// 表示数据传输是否成功
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
