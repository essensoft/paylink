using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandWarehouseOrderSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandWarehouseOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送指令ID
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonPropertyName("new_warehouse_id")]
        public string NewWarehouseId { get; set; }

        /// <summary>
        /// 指令类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
