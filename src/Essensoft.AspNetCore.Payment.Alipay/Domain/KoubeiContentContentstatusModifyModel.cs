using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiContentContentstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiContentContentstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 口碑端内容唯一id，必填
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作原因
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 需要修改的内容状态，必填.内容状态是审核拒绝(AUDIT_DENY),才可以修改否则不能修改.  状态枚举:  INIT,初始态,  AUDITING,审核中,  INFOSEC_AUDITING,风控审核中,  ENABLE,有效,  DISABLE,无效,  AUDIT_DENY,审核拒绝
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
