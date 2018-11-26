using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageQueryResponse.
    /// </summary>
    public class AlipayOpenPublicMessageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发送消息结果集。仅返回该用户已发送的消息
        /// </summary>
        [JsonProperty("list")]
        [XmlArray("list")]
        [XmlArrayItem("public_message_info")]
        public List<PublicMessageInfo> List { get; set; }
    }
}
