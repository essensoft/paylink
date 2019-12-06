using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessItemInventoryExternalSyncModel Data Structure.
    /// </summary>
    public class AlipayBusinessItemInventoryExternalSyncModel : AlipayObject
    {
        /// <summary>
        /// 商品库存信息列表
        /// </summary>
        [JsonPropertyName("inventories")]
        public List<ItemInventory> Inventories { get; set; }

        /// <summary>
        /// 请求ID，支持英文字母和数字，由调用者自行定义（不允许重复）
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
