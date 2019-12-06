using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneHealthActivitySyncModel Data Structure.
    /// </summary>
    public class AlipayInsSceneHealthActivitySyncModel : AlipayObject
    {
        /// <summary>
        /// 活动编号参数，比如01
        /// </summary>
        [JsonPropertyName("activity_no")]
        public string ActivityNo { get; set; }

        /// <summary>
        /// 申请编号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 业务数据，比如邮寄信息，结果信息等
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 订单编号唯一幂等校验
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 状态参数，比如0，初始状态，1完成状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
