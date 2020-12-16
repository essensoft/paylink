using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneLifemssageSingleSendModel Data Structure.
    /// </summary>
    public class AlipayInsSceneLifemssageSingleSendModel : AlipayObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 生活号ID
        /// </summary>
        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 推送模板上下文
        /// </summary>
        [JsonPropertyName("push_context")]
        public string PushContext { get; set; }

        /// <summary>
        /// 模板消息上下文
        /// </summary>
        [JsonPropertyName("template_context")]
        public string TemplateContext { get; set; }

        /// <summary>
        /// 生活号模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 发送到的用户ID
        /// </summary>
        [JsonPropertyName("to_user_id")]
        public string ToUserId { get; set; }
    }
}
