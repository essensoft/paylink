using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicTemplateMessageGetResponse.
    /// </summary>
    public class AlipayOpenPublicTemplateMessageGetResponse : AlipayResponse
    {
        /// <summary>
        /// 消息模板id--商户领取母版后生成的唯一模板id
        /// </summary>
        [JsonProperty("msg_template_id")]
        [XmlElement("msg_template_id")]
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [JsonProperty("template")]
        [XmlElement("template")]
        public string Template { get; set; }
    }
}
