using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceMessageUniversalSendModel Data Structure.
    /// </summary>
    public class AlipayEcoCityserviceMessageUniversalSendModel : AlipayObject
    {
        /// <summary>
        /// 模板中占位符模型列表
        /// </summary>
        [JsonPropertyName("keyword_list")]
        public List<UniversalKeyword> KeywordList { get; set; }

        /// <summary>
        /// 生活号/小程序/内部小程序/内部应用appId
        /// </summary>
        [JsonPropertyName("message_app_id")]
        public string MessageAppId { get; set; }

        /// <summary>
        /// 沟通平台模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 第三方消息Id
        /// </summary>
        [JsonPropertyName("third_msg_id")]
        public string ThirdMsgId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
