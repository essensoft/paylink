using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceVerificationResultSendModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceVerificationResultSendModel : AlipayObject
    {
        /// <summary>
        /// 部署单记录id
        /// </summary>
        [JsonPropertyName("record_id")]
        public long RecordId { get; set; }

        /// <summary>
        /// 验证结果列表
        /// </summary>
        [JsonPropertyName("result_items")]
        public List<DxVerifyResultItem> ResultItems { get; set; }
    }
}
