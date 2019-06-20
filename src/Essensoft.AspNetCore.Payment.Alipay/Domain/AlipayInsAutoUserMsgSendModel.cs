using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoUserMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoUserMsgSendModel : AlipayObject
    {
        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonProperty("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 扩展信息。因为车险触达用户的渠道有多种。不同渠道所需的扩展信息不同，开发前需和车险技术同学确认好。
        /// </summary>
        [JsonProperty("extend_info")]
        public List<AutoMktTouchExtendInfoEntry> ExtendInfo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 场景码。【车险技术分配的场景码】
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 模版中的可变字段的值，根据不同场景，所需要的字段都不一样。要和车险业务以及技术确认好。
        /// </summary>
        [JsonProperty("template_content_info")]
        public List<AutoMktTouchExtendInfoEntry> TemplateContentInfo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
