using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodBehaviorlogBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodBehaviorlogBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 行为日志类型，SCAN_CDOE:扫码/HEARTBEAT:心跳
        /// </summary>
        [JsonPropertyName("behavior_type")]
        public string BehaviorType { get; set; }

        /// <summary>
        /// 设备sn，device_sn/imei必须填一个，如果device_sn会优先通过device_sn查询
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备imei码，device_sn/imei必须填一个，如果device_sn会优先通过device_sn查询
        /// </summary>
        [JsonPropertyName("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 物料ID，支付宝提供，建议设置，当不同厂商设备device_sn/imei重复时，可过滤出关联指定物料ID的记录
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
