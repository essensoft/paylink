using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationPlatformNoticeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationPlatformNoticeCreateModel : AlipayObject
    {
        /// <summary>
        /// 站内信内容字段
        /// </summary>
        [JsonProperty("notice_content")]
        public string NoticeContent { get; set; }

        /// <summary>
        /// 站内信title字段
        /// </summary>
        [JsonProperty("notice_title")]
        public string NoticeTitle { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
