using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdFingerprintDeleteResponse.
    /// </summary>
    public class AlipaySecurityProdFingerprintDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 去注册阶段服务端返回的协议体数据，对应《IFAA本地免密技术规范》中的IFAFMessage，内容中包含服务端的去注册数据。
        /// </summary>
        [JsonProperty("server_response")]
        [XmlElement("server_response")]
        public string ServerResponse { get; set; }
    }
}
