using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSyncModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSyncModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息，JSON字符串格式
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 当前节点名称
        /// </summary>
        [JsonPropertyName("cur_node")]
        public string CurNode { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
