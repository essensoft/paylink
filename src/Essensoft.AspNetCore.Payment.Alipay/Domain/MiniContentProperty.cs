using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniContentProperty Data Structure.
    /// </summary>
    public class MiniContentProperty : AlipayObject
    {
        /// <summary>
        /// 属性key，必须是平台预先定义的，否则不允许录入
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性状态，VALID：有效，INVALID：无效，MAN_AUDITING：审核中，MAN_AUDIT_REJECT：审核驳回
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonPropertyName("value_list")]
        public List<string> ValueList { get; set; }
    }
}
