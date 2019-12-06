using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertProcessMissionResponse Data Structure.
    /// </summary>
    public class KbAdvertProcessMissionResponse : AlipayObject
    {
        /// <summary>
        /// 标识ID
        /// </summary>
        [JsonPropertyName("identify")]
        public string Identify { get; set; }

        /// <summary>
        /// 主键类型  activity_id：运营活动ID  voucher：商品ID  mission：分佣任务ID
        /// </summary>
        [JsonPropertyName("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 任务状态  UNCONFIRMED-未确认（代表任务还在等待商户确认）  EFFECTIVE-有效  INVALID-无效
        /// </summary>
        [JsonPropertyName("promote_status")]
        public string PromoteStatus { get; set; }
    }
}
