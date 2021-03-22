using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMessagetemplateSubscribeQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMessagetemplateSubscribeQueryModel : AlipayObject
    {
        /// <summary>
        /// 消息模板id，可以填写多个，最多不超过3个。模板id需要保持同一个应用主体，并且展示在同一个订阅组件中的模板id
        /// </summary>
        [JsonPropertyName("template_id_list")]
        public List<string> TemplateIdList { get; set; }

        /// <summary>
        /// 订阅消息模板的用户的userid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
