using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoUserMsgSendModel Data Structure.
    /// </summary>
    public class AlipayInsAutoUserMsgSendModel : AlipayObject
    {
        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 扩展信息。因为车险触达用户的渠道有多种。不同渠道所需的扩展信息不同，开发前需和车险技术同学确认好。
        /// </summary>
        [JsonPropertyName("extend_info")]
        public List<AutoMktTouchExtendInfoEntry> ExtendInfo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 场景码。【车险技术分配的场景码】
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 模版中的可变字段的值，根据不同场景，所需要的字段都不一样。要和车险业务以及技术确认好。
        /// </summary>
        [JsonPropertyName("template_content_info")]
        public List<AutoMktTouchExtendInfoEntry> TemplateContentInfo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
