using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceAddResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceAddResponse : AlipayResponse
    {
        /// <summary>
        /// 请求操作成功与否，200为成功
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 请求的处理结果
        /// </summary>
        [JsonProperty("msg")]
        [XmlElement("msg")]
        public new string Msg { get; set; }
    }
}
