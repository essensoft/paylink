using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbsalesShopSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbsalesShopSyncModel : AlipayObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 申请绑定关系类型
        /// </summary>
        [JsonPropertyName("action_mode")]
        public string ActionMode { get; set; }

        /// <summary>
        /// 固定填elm
        /// </summary>
        [JsonPropertyName("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// { opId: 123456, applyInfo: '审核不通过', auditor:'123456'}
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 饿了么门店id
        /// </summary>
        [JsonPropertyName("external_shop_id")]
        public string ExternalShopId { get; set; }

        /// <summary>
        /// 口碑流水id， 饿了么leads开始的场景有该值  在线开店及绑定无该值
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 绑定关系类型
        /// </summary>
        [JsonPropertyName("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 饿了么审核任务id
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
